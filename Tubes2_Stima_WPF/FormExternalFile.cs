using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tubes2_Stima_WPF.Algorithms;
using Tubes2_Stima_WPF.Models;
using Tubes2_Stima_WPF.Handlers;

namespace Tubes2_Stima_WPF
{
    public partial class FormExternalFile : Form
    {
        public FormExternalFile()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            //memastikan richTextBox tidak ada isinya
            richTextBoxAnswer.Text = "";
            richTextBoxQuery.Text = "";
            richTextBoxDFS.Text = "";
            richTextBoxPath.Text = "";

            MapReader Peta = new MapReader("Map.txt");

            Peta.Parse();

            QueryHandler Ask = new QueryHandler(textBoxQueryFile.Text);
            Ask.Parse();

            // memberi level pada semua rumah
            List<int> path = new List<int>();
            DFS_Graph.TentukanLevel(1, 0, path, Peta.Map);

            for(int i =1;i<=Ask.Query_Count;i++)
            {
                richTextBoxQuery.Text += i+") "+Ask.ResultString[i] + "\n";
                List<int> trimmedRoute;

                // DFS
                int DekatJauh = Ask.Queries[i-1].Item1;
                int TempatJose = Ask.Queries[i-1].Item2;
                int TempatFerdiant = Ask.Queries[i-1].Item3;
                List<int> route = new List<int>();
                bool Jawaban;

                if (DekatJauh == 0)
                {
                    if ((TempatJose <= Peta.House_Count) && (TempatFerdiant <= Peta.House_Count))
                    {
                        DFS_Graph.DFS(0, 1, TempatFerdiant, route, Peta.Map);
                    }
                    // mencari jawaban
                    trimmedRoute = DFS_Graph.Trim(route);
                    Jawaban = trimmedRoute.Contains<int>(TempatJose);
                    richTextBoxAnswer.Text += i + ")";
                    if (Jawaban)
                    {
                        richTextBoxAnswer.Text += " YA\n";
                    }
                    else
                    {
                        richTextBoxAnswer.Text += " TIDAK\n";
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
                    // mencari jawaban
                    trimmedRoute = DFS_Graph.Trim(route);
                    Jawaban = trimmedRoute.Contains<int>(TempatJose);
                    richTextBoxAnswer.Text += i + ")";
                    if (Jawaban)
                    {
                        richTextBoxAnswer.Text += " YA\n";
                    }
                    else
                    {
                        richTextBoxAnswer.Text += " TIDAK\n";
                    }
                }
                else
                {
                    richTextBoxAnswer.Text += ("Input tidak valid.\n");
                    return;
                }

                // print rute DFS
                richTextBoxDFS.Text += i+")";
                if (route.Count() != 0)
                {
                    foreach (int member in route)
                    {
                        richTextBoxDFS.Text += " -> " + member.ToString();
                    }
                    richTextBoxDFS.Text += "\n\n";
                }
                else
                {
                    richTextBoxDFS.Text += " Tidak ada penelusuran DFS.\n\n";
                }


                // print rute jawaban yang benar jika ada
                richTextBoxPath.Text += i+")";
                if (Jawaban)
                {
                    foreach (int member in trimmedRoute)
                    {
                        richTextBoxPath.Text += " -> " + member.ToString();
                    }
                    richTextBoxPath.Text += "\n\n";
                }
                else
                {
                    richTextBoxPath.Text += " Tidak ada jalur solusi\n\n";
                }

            }
        }
    }
}

