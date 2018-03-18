using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minty.Model
{
    class Graph
    {
        private List<Vertex> vertices;
        private List<Edge> edges;

        public List<Vertex> Vertices  { get => vertices; }
        public List<Edge> Edges { get => edges; }

        public Graph(List<Vertex> vertices, List<Edge> edges)
        {
            this.vertices = vertices;
            this.edges = edges;
        }
    }
}
