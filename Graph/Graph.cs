using System.Collections.Generic;

namespace Graph
{
    class Graph
    {
        List<Vertex> V = new List<Vertex>();
        List<Edge> E = new List<Edge>();
        public int VCount => V.Count;
        public int ECount => E.Count;
        public void AddV(Vertex vertex)
        {
            V.Add(vertex);
        }
        public void AddE(Vertex from, Vertex to)
        {
            var edge = new Edge(from, to);
            E.Add(edge);
        }
        public int[,] CreateMatrix()
        {
            var matrix = new int[V.Count, V.Count];
            foreach (var edge in E)
            {
                var row = edge.From.Number - 1;
                var column = edge.To.Number - 1;
                matrix[row, column] = edge.Weight;
            }
            return matrix;
        }

        public List<Vertex> GetVetexLists(Vertex vertex)
        {
            var result = new List<Vertex>();

            foreach (var edge in E)
            {
                if (edge.From == vertex)
                {
                    result.Add(edge.To);
                }
            }

            return result;
        }
        public bool Wave(Vertex start, Vertex finish)
        {
            var list = new List<Vertex>
            {
                start
            };

            for (int i = 0; i < list.Count; i++)
            {
                var vertex = list[i];
                foreach (var v in GetVetexLists(vertex))
                {
                    if (!list.Contains(v))
                    {
                        list.Add(v);
                    }
                }
            }

            return list.Contains(finish);
        }
    }
}
