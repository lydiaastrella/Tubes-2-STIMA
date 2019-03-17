using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tubes2_Stima_WPF.Models;
using Tubes2_Stima_WPF.Handlers;

namespace Tubes2_Stima_WPF.Algorithms
{
    class DFS_Graph
    {
        /* Menentukan level (kedalaman) tiap rumah dengan DFS.
         * Dimulai dari NomorRumah = 1 dan level = 0.
         */
        public static void TentukanLevel(int NomorRumah_dicari, int level, List<int> path, GraphKingdomMap graph)
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

                    // cari tetangga yang belum dikunjungi
                    graph.TryGetOutEdges(vert, out IEnumerable<DataEdge> OutEdges);
                    int i = 0;
                    bool DeadEnd = true;
                    while ((i < OutEdges.Count()) && (DeadEnd))
                    {
                        if (!path.Contains(OutEdges.ElementAt<DataEdge>(i).Target.NomorRumah))
                        {
                            DeadEnd = false;
                            TentukanLevel(OutEdges.ElementAt<DataEdge>(i).Target.NomorRumah, level + 1, path, graph);
                        }
                        else
                        {
                            i++;
                        }
                    }
                    // jika tidak ada tentangga yang belum dikunjungi dan belum balik ke istana
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
                    // jika tidak ada tentangga yang belum dikunjungi dan sudah balik ke istana, berhenti
                    else
                    {
                        break;
                    }
                }
            }
        }

        /* Melakukan DFS dari start hingga destination ditemukan. */
        public static void DFS(int startLevel, int start, int destination, List<int> route, GraphKingdomMap graph)
        {
            foreach (var vert in graph.Vertices)
            {
                // mencari NomorRumah dari daftar rumah
                if (vert.NomorRumah == start)
                {
                    // menambahkan rumah ke rute
                    route.Add(vert.NomorRumah);

                    // jika rumah = destination, method berakhir
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
                        // mencari tujuan yang belum pernah dikunjungi dan bukan parent dari start
                        if ((!route.Contains(OutEdges.ElementAt<DataEdge>(i).Target.NomorRumah)) && (OutEdges.ElementAt<DataEdge>(i).Target.Level > startLevel))
                        {
                            DeadEnd = false;
                        }
                        else
                        {
                            i++;
                        }
                    }
                    // jika ditemukan tujuan, pindah ke tujuan
                    if (!DeadEnd)
                    {
                        DFS(startLevel, OutEdges.ElementAt<DataEdge>(i).Target.NomorRumah, destination, route, graph);
                    }
                    else
                    {
                        // jika tidak ditemukan tujuan dan belum kembali ke start
                        if (vert.Level > startLevel)
                        {
                            foreach (var edge in OutEdges)
                            {
                                // backtrack
                                if (edge.Target.Level < vert.Level)
                                {
                                    DFS(startLevel, edge.Target.NomorRumah, destination, route, graph);
                                }
                            }
                        }
                        // jika tidak ditemukan tujuan dan sudah kembali ke start, berhenti
                        else
                        {
                            route.RemoveAt(route.Count() - 1);
                            break;
                        }
                    }
                }
            }

        }

        /* Method untuk menghapus backtrack dari rute */
        public static List<int> Trim(List<int> route)
        {
            List<int> newList = new List<int>(route);
            int i = 0;
            while (i < newList.Count())
            {
                int j = newList.Count() - 1;
                bool backtracked = false;
                while ((!backtracked) && (j > i))
                {
                    if (newList.ElementAt<int>(j) == newList.ElementAt<int>(i))
                    {
                        backtracked = true;
                        newList.RemoveRange(i + 1, j - i);
                    }
                    else
                    {
                        j--;
                    }
                }
                i++;
            }
            return newList;
        }
    }
}
