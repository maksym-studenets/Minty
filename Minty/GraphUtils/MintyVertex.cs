using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minty.GraphUtils
{
    [Obsolete]
    class MintyVertex
    {
        public int vertexCount;
        public double distance;
        public int previousVertexIndicies;
        public List<int> otherPreviousIndicies = null;

        public int VertexCount { get => vertexCount; set => vertexCount = value; }
        public double Distance { get => distance; set => distance = value; }
        public int PreviousVertexIndicies { get => previousVertexIndicies;
                                            set => previousVertexIndicies = value; }
        public List<int> OtherPreviousIndicies { get => otherPreviousIndicies;
                                                 set => otherPreviousIndicies = value; }



        public MintyVertex(double distance, int previousVertexIndicies,
                              List<int> otherPreviousIndicies = null)
        {
            this.distance = distance;
            this.previousVertexIndicies = previousVertexIndicies;
            this.otherPreviousIndicies = otherPreviousIndicies;
        }
    }
}
