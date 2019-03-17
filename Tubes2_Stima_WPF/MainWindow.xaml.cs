using System;
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

            MapReader Peta = new MapReader("input.txt");

            Peta.Parse();

            Find_Solution(Peta);
        }

        static void Find_Solution(MapReader Peta)
        {
            // memberi level pada semua rumah
            List<int> path = new List<int>();
            DFS_Graph.TentukanLevel(1, 0, path, Peta.Map);

            // DFS
            int DekatJauh = 0;
            int TempatJose = 1;
            int TempatFerdiant = 6;
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
    }
}
