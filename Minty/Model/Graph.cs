using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Minty.Model
{
    [Serializable]
    class Graph
    {
        private List<Vertex> vertices;
        private List<Edge> edges;

        public List<Vertex> Vertices  { get => vertices; set => vertices = value; }
        public List<Edge> Edges { get => edges; set => edges = value; }

        public Graph()
        {
            this.vertices = new List<Vertex>();
            this.edges = new List<Edge>();
        }

        public Graph(List<Vertex> vertices, List<Edge> edges)
        {
            this.vertices = vertices;
            this.edges = edges;
        }
    }
}
