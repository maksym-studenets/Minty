using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace Minty.Model
{
    [Serializable]
    class Graph
    {
        private List<Vertex> vertices = new List<Vertex>();
        private List<Edge> edges = new List<Edge>();

        public List<Vertex> Vertices  { get => vertices; set => vertices = value; }
        public List<Edge> Edges { get => edges; set => edges = value; }

        public Graph() { }

        public Graph(List<Vertex> vertices, List<Edge> edges) {
            this.vertices = vertices;
            this.edges = edges;
        }
    }
}
