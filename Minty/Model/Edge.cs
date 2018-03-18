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

        public int Id { get => id; }
        public Vertex Source { get => source; }
        public Vertex Destination { get => destination; }
        public int Weight { get => weight; }

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
    }
}
