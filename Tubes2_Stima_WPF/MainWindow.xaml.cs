﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using GraphX.PCL.Common.Enums;
using GraphX.PCL.Logic.Algorithms.LayoutAlgorithms;
using GraphX.Controls;
using Tubes2_Stima_WPF.Models;
using Tubes2_Stima_WPF.Handlers;
using Tubes2_Stima_WPF.Algorithms;

namespace Tubes2_Stima_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Console.Write("Masukkan nama file peta: ");
            string mapName = Console.ReadLine();

            MapReader Peta = new MapReader(mapName);
            Peta.Parse();


            Console.Write("Masukkan nama file query: ");
            string queryName = Console.ReadLine();

            QueryHandler Queries = new QueryHandler(queryName);
            Queries.Parse();
            

            //Customize Zoombox a bit
            //Set minimap (overview) window to be visible by default
            ZoomControl.SetViewFinderVisibility(zoomctrl, Visibility.Visible);
            //Set Fill zooming strategy so whole graph will be always visible
            zoomctrl.ZoomToFill();

            //Lets setup GraphArea settings

            GraphKingdomArea_Setup(Peta.Map);

            ShowGraph();


            // memberi level pada semua rumah
            List<int> path = new List<int>();
            DFS_Graph.TentukanLevel(1, 0, path, Peta.Map);

            foreach(var Query in Queries.Queries)
            {
                Console.WriteLine(Query);
                Find_Solution_DFS(Peta, Query.Item1, Query.Item2, Query.Item3);
            }
        }



        static void Find_Solution_DFS(MapReader Peta, int DekatJauh, int TempatJose, int TempatFerdiant)
        {
            // DFS
            List<int> route = new List<int>();
            bool Jawaban;

            if (DekatJauh == 0)
            {
                if ((TempatJose <= Peta.House_Count) && (TempatFerdiant <= Peta.House_Count))
                {
                    DFS_Graph.DFS(0, 1, TempatFerdiant, route, Peta.Map);
                }
            }
            else if (DekatJauh == 1)
            {
                if ((TempatJose <= Peta.House_Count) && (TempatFerdiant <= Peta.House_Count))
                {
                    foreach (var vert in Peta.Map.Vertices)
                    {
                        if (vert.NomorRumah == TempatFerdiant)
                        {
                            int startLevel = vert.Level;
                            DFS_Graph.DFS(startLevel, TempatFerdiant, TempatJose, route, Peta.Map);
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Input tidak valid.");
                return;
            }

            // mencari jawaban
            List<int> trimmedRoute = DFS_Graph.Trim(route);
            Jawaban = trimmedRoute.Contains<int>(TempatJose);
            Console.WriteLine(Jawaban);

            // print rute DFS
            foreach (int member in route)
            {
                Console.Write(" -> " + member);
            }
            Console.WriteLine();

            // print rute jawaban yang benar jika ada
            if (Jawaban)
            {
                foreach (int member in trimmedRoute)
                {
                    Console.Write(" -> " + member);
                }
                Console.WriteLine();
            }
        }

        private void ShowGraph()
        {
            Area.GenerateGraph(true, true);

            Area.SetEdgesDashStyle(EdgeDashStyle.Solid);

            Area.ShowAllEdgesArrows(false);

            zoomctrl.ZoomToFill();
        }

        private void GraphKingdomArea_Setup(GraphKingdomMap graph)
        {
            //create logic core and fill Graph
            var logicCore = new GraphXLogicCore() { Graph = graph };
            //This property sets layout algorithm that will be used to calculate vertices positions
            //Different algorithms uses different values and some of them uses edge Weight property.
            logicCore.DefaultLayoutAlgorithm = LayoutAlgorithmTypeEnum.KK;
            //Now we can set parameters for selected algorithm using AlgorithmFactory property. This property provides methods for
            //creating all available algorithms and algo parameters.
            logicCore.DefaultLayoutAlgorithmParams = logicCore.AlgorithmFactory.CreateLayoutParameters(LayoutAlgorithmTypeEnum.KK);
            //Unfortunately to change algo parameters you need to specify params type which is different for every algorithm.
            ((KKLayoutParameters)logicCore.DefaultLayoutAlgorithmParams).MaxIterations = 100;

            //This property sets vertex overlap removal algorithm.
            //Such algorithms help to arrange vertices in the layout so no one overlaps each other.
            logicCore.DefaultOverlapRemovalAlgorithm = OverlapRemovalAlgorithmTypeEnum.FSA;
            //Default parameters are created automaticaly when new default algorithm is set and previous params were NULL
            logicCore.DefaultOverlapRemovalAlgorithmParams.HorizontalGap = 50;
            logicCore.DefaultOverlapRemovalAlgorithmParams.VerticalGap = 50;

            //This property sets edge routing algorithm that is used to build route paths according to algorithm logic.
            //For ex., SimpleER algorithm will try to set edge paths around vertices so no edge will intersect any vertex.
            //Bundling algorithm will try to tie different edges that follows same direction to a single channel making complex graphs more appealing.
            logicCore.DefaultEdgeRoutingAlgorithm = EdgeRoutingAlgorithmTypeEnum.SimpleER;

            //This property sets async algorithms computation so methods like: Area.RelayoutGraph() and Area.GenerateGraph()
            //will run async with the UI thread. Completion of the specified methods can be catched by corresponding events:
            //Area.RelayoutFinished and Area.GenerateGraphFinished.
            logicCore.AsyncAlgorithmCompute = false;

            //Finally assign logic core to GraphArea object
            Area.LogicCore = logicCore;
        }
    }
}
