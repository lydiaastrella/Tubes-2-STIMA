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
    }
}
