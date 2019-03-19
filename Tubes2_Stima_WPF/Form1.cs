using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tubes2_Stima_WPF.Models;
using Tubes2_Stima_WPF.Handlers;
using Tubes2_Stima_WPF.Algorithms;

namespace Tubes2_Stima_WPF
{
    public partial class FormDirectInput : Form
    {
        public FormDirectInput()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            //memastikan richTextBox kosong
            richTextBoxAnswer.Text = "";
            richTextBoxDFS.Text = "";
            richTextBoxPath.Text = "";

            //string dari input pada textbox
            String input = textBoxInput.Text;
            string[] temp = input.Split();

            MapReader Peta = new MapReader("Map.txt");

            Peta.Parse();

            // memberi level pada semua rumah
            List<int> path = new List<int>();
            DFS_Graph.TentukanLevel(1, 0, path, Peta.Map);

            // DFS
            int DekatJauh = int.Parse(temp[0]);
            int TempatJose = int.Parse(temp[1]);
            int TempatFerdiant = int.Parse(temp[2]);
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
                richTextBoxPath.Text = ("Input tidak valid.");
                return;
            }

            // mencari jawaban
            List<int> trimmedRoute = DFS_Graph.Trim(route);
            Jawaban = trimmedRoute.Contains<int>(TempatJose);
            if (Jawaban){
                richTextBoxAnswer.Text = "YA";
            }
            else
            {
                richTextBoxAnswer.Text = "TIDAK";
            }
            
            // print rute jawaban yang benar jika ada
            foreach (int member in route)
            {
                richTextBoxPath.Text += " -> " + member.ToString();
            }

            // print rute DFS
            if (Jawaban)
            {
                foreach (int member in trimmedRoute)
                {
                    richTextBoxDFS.Text += " -> " + member.ToString();
                }

            }
        }
    }
}
