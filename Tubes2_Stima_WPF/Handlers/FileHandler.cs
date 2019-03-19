﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tubes2_Stima_WPF.Models;
using Tubes2_Stima_WPF.Algorithms;

namespace Tubes2_Stima_WPF.Handlers
{
    class FileHandler
    {
        public string File_Path { get; set; }


        public FileHandler(string path)
        {
            this.File_Path = path;
        }
    }

    class ReadFileHandler : FileHandler
    {
        public string[] ResultString { set; get; }

        public ReadFileHandler(string path) : base(path)
        {
        }

        // read input file
        public void ReadFromFile()
        {
            ResultString = File.ReadAllLines(this.File_Path);
        }
    }

    class MapReader : ReadFileHandler
    {
        public int House_Count { set; get; }
        public GraphKingdomMap Map { set; get; }

        public MapReader(string path) : base(path)
        {
        }

        public void Parse()
        {
            this.ReadFromFile();

            this.House_Count = int.Parse(this.ResultString[0]);

            this.Map = new GraphKingdomMap();

            // generate all vertex
            for (int i = 1; i <= this.House_Count; i++)
            {
                DataVertex newVertex = new DataVertex(i);
                this.Map.AddVertex(newVertex);
            }

            // get a list of all vertex for easy access
            var vlist = this.Map.Vertices.ToList();

            // insert edges from input
            for (int i = 1; i < this.House_Count; i++)
            {
                // split input into two strings
                string[] temp = ResultString[i].Split();

                // parse from string to int to get vertex id
                int source = int.Parse(temp[0]) - 1;
                int destination = int.Parse(temp[1]) - 1;

                // insert bidirectional edges
                var newEdge = new DataEdge(vlist[source], vlist[destination]);
                this.Map.AddVerticesAndEdge(newEdge);
                newEdge = new DataEdge(vlist[destination], vlist[source]);
                this.Map.AddVerticesAndEdge(newEdge);
            }
        }
    }

    class QueryHandler : ReadFileHandler
    {
        public int Query_Count { get; set; }

        // Mode, Target, Start
        public List<Tuple<int, int, int>> Queries { get; set; }

        public QueryHandler(string path) : base(path)
        {
            Queries = new List<Tuple<int, int, int>>();
        }

        public void Parse()
        {
            this.ReadFromFile();

            this.Query_Count = int.Parse(this.ResultString[0]);

            for (int i=1; i <= this.Query_Count; i++)
            {
                string[] temp = this.ResultString[i].Split();

                int Mode = int.Parse(temp[0]);

                int Target = int.Parse(temp[1]);

                int Start = int.Parse(temp[2]);

                Queries.Add(new Tuple<int, int, int>(Mode, Target, Start));
            }
        }
    }
}
