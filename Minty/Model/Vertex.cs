using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minty.Model
{
    /// <summary>
    /// Class Vertex represents a single node (or vertex) of the graph.
    /// Each vertex is defined by its label, or identifier which is a natural number
    /// </summary>
    class Vertex
    {
        private int id;

        public int Id { get => id; set => id = value;  }

        public Vertex() { }

        public Vertex(int id)
        {
            this.id = id;
        }

        override public string ToString()
        {
            return "Vertex " + id;
        }
    }
}
