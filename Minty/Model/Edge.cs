using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minty.Model
{
    class Edge
    {
        private int id;
        private Vertex source;
        private Vertex destination;
        private int weight;

        public int Id { get => id; set => id = value; }
        public Vertex Source { get => source; set => source = value; }
        public Vertex Destination { get => destination; set => destination = value; }
        public int Weight { get => weight; set => weight = value; }

        public Edge() { }

        public Edge(Vertex start, Vertex end, int weight)
        {
            source = start;
            destination = end;
            this.weight = weight;
        }

        public Edge(int id, Vertex start, Vertex end, int weight)
        {
            this.id = id;
            this.source = start;
            this.destination = end;
            this.weight = weight;
        }

        public override string ToString()
        {
            return "Edge: " + source.ToString() + " - " + destination.ToString() + 
                ". Weight: " + weight;
        }
    }
}
