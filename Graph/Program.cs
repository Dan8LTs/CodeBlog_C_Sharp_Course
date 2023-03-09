using System;

namespace Graph
{
    class Program
    {
        static void Main(string[] args)
        {
            var graph = new Graph();
            Vertex v1 = new Vertex(1);
            Vertex v2 = new Vertex(2);
            Vertex v3 = new Vertex(3);
            Vertex v4 = new Vertex(4);

            graph.AddV(v1);
            graph.AddV(v2);
            graph.AddV(v3);
            graph.AddV(v4);

            graph.AddE(v1, v2);
            graph.AddE(v1, v3);
            graph.AddE(v3, v4);
            CreateMatrix(graph);
            Console.WriteLine();

            GetVertex(graph, v1);
            GetVertex(graph, v2);
            GetVertex(graph, v3);
            GetVertex(graph, v4);
            Console.WriteLine();

            Console.WriteLine(graph.Wave(v1, v4));
            Console.WriteLine(graph.Wave(v2, v4));
            Console.ReadLine();
        }

        private static void GetVertex(Graph graph, Vertex vertex)
        {
            Console.Write(vertex.Number + ": ");
            foreach (var v in graph.GetVetexLists(vertex))
            {
                Console.Write(v.Number + "; ");
            }
            Console.WriteLine();
        }

        private static void CreateMatrix(Graph graph)
        {
            for (int i = 0; i < graph.VCount; i++)
            {
                Console.Write($"    {i + 1}  ");
            }
            Console.WriteLine();
            int[,] matrix = graph.CreateMatrix();
            for (int i = 0; i < graph.VCount; i++)
            {
                Console.Write(i + 1);
                for (int j = 0; j < graph.VCount; j++)
                {
                    Console.Write(" | " + matrix[i, j] + " | ");
                }
                Console.WriteLine();
            }
        }
    }
}
