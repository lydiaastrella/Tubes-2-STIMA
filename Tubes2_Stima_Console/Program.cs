using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tubes2_Stima_Console.Models;
using Tubes2_Stima_Console.Handlers;

namespace Tubes2_Stima_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            MapReader Peta = new MapReader("input.txt");

            Peta.Parse();

            ContohAksesSimpul(Peta.Map);

            // memberi level pada semua rumah
            List<int> path = new List<int>();
            TentukanLevel(1, 0, path, Peta.Map);

            // DFS
            int DekatJauh = 1;
            int TempatJose = 1;
            int TempatFerdiant = 5;
            List<int> route = new List<int>();
            bool Jawaban;

            if (DekatJauh == 0)
            {
                if ((TempatJose <= Peta.House_Count) && (TempatFerdiant <= Peta.House_Count))
                {
                    DFS(0, 1, TempatFerdiant, route, Peta.Map);
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
                            DFS(startLevel, TempatFerdiant, TempatJose, route, Peta.Map);
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Input tidak valid.");
            }

            // print route for debug
            foreach (int member in route)
            {
                Console.Write(" -> " + member);
            }
            Console.WriteLine();


            foreach (var x in Enumerable.Range(1, Peta.House_Count))
            {
                ContohAksesSimpulTerhubung(x, Peta.Map);
            }

            Console.ReadKey();
        }
        
        static void ContohAksesSimpul(GraphKingdomMap graph)
        {
            Console.WriteLine("Daftar simpul");
            foreach (var vert in graph.Vertices)
            {
                Console.WriteLine(vert.NomorRumah);
            }
        }

        static void ContohAksesSimpulTerhubung(int NomorRumah_dicari, GraphKingdomMap graph)
        {
            foreach (var vert in graph.Vertices)
            {
                // mencari ID yang match
                if (vert.NomorRumah == NomorRumah_dicari)
                {
                    // mendapat OutEdges
                    graph.TryGetOutEdges(vert, out IEnumerable<DataEdge> OutEdges);

                    Console.WriteLine("Semua simpul yang terhubung dengan simpul " + NomorRumah_dicari);

                    // mendapatkan dan mencetak simpul terhubung
                    foreach (var edge in OutEdges)
                    {
                        var OutVert = edge.Target;
                        Console.WriteLine(OutVert.NomorRumah);
                    }
                }
            }
        }

        /* Menentukan level (kedalaman) tiap rumah dengan DFS.
         * Dimulai dari NomorRumah = 1 dan level = 0.
         */
        static void TentukanLevel (int NomorRumah_dicari, int level, List<int> path, GraphKingdomMap graph)
        {
            foreach (var vert in graph.Vertices)
            {
                if (vert.NomorRumah == NomorRumah_dicari)
                {
                    if (!path.Contains<int>(vert.NomorRumah))
                    {
                        path.Add(vert.NomorRumah);
                    }

                    // menentukan level
                    vert.Level = level;
                    
                    // cari tetangga rumah
                    graph.TryGetOutEdges(vert, out IEnumerable<DataEdge> OutEdges);
                    int i = 0;
                    bool DeadEnd = true;
                    while ((i < OutEdges.Count()) && (DeadEnd))
                    {
                        if (!path.Contains(OutEdges.ElementAt<DataEdge>(i).Target.NomorRumah))
                        {
                            DeadEnd = false;
                            TentukanLevel(OutEdges.ElementAt<DataEdge>(i).Target.NomorRumah, level + 1, path, graph);
                        } else
                        {
                            i++;
                        }
                    }
                    if (level > 0)
                    {
                        foreach (var edge in OutEdges)
                        {
                            if (edge.Target.Level < level)
                            {
                                level = level - 1;
                                TentukanLevel(edge.Target.NomorRumah, level, path, graph);
                            }
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }

        /* Melakukan DFS dari start hingga destination ditemukan. */
        static void DFS (int startLevel, int start, int destination, List<int> route, GraphKingdomMap graph)
        {
            foreach (var vert in graph.Vertices)
            {
                if (vert.NomorRumah == start)
                {
                    route.Add(vert.NomorRumah);
                    if (vert.NomorRumah == destination)
                    {
                        break;
                    }
                    
                    // cari tetangga rumah
                    graph.TryGetOutEdges(vert, out IEnumerable<DataEdge> OutEdges);
                    int i = 0;
                    bool DeadEnd = true;
                    while ((i < OutEdges.Count()) && (DeadEnd))
                    {
                        if ((!route.Contains(OutEdges.ElementAt<DataEdge>(i).Target.NomorRumah)) && (OutEdges.ElementAt<DataEdge>(i).Target.Level > startLevel))
                        {
                            DeadEnd = false;
                        } else
                        {
                            i++;
                        }
                    }
                    if (!DeadEnd) 
                    {
                        DFS(startLevel, OutEdges.ElementAt<DataEdge>(i).Target.NomorRumah, destination, route, graph);
                    }
                    else
                    {
                        if (vert.Level > startLevel)
                        {
                            foreach (var edge in OutEdges)
                            {
                                if (edge.Target.Level < vert.Level)
                                {
                                    DFS(startLevel, edge.Target.NomorRumah, destination, route, graph);
                                }
                            }
                        }
                        else
                        {
                            route.RemoveAt(route.Count() - 1);
                            break;
                        }
                    }
                }
            }

        }

        //static void Trim
    }
}
