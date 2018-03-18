using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minty.GraphUtils
{
    /// <summary>
    /// Class Graph represents a graph in the application and contains the Mint'y
    /// shortest path algorithm implementation.
    /// The graph used in this application is a directed weighted graph, that means
    /// that the direction of each edge is important and not associative and each
    /// edge has a weight that indicates a length (or cost) of the path between two
    /// vertices.
    /// The graph is represented in the form of an adjacency matrix. All elements that
    /// have a value of -1 indicate that no edges between two given vertices with ids
    /// that correspond to the number of a row and a column exists. All other values
    /// indicate a weight (cost) of an edge.
    /// This class is serializable and therefore can be written in a binary format
    /// to a text file.
    /// </summary>
    [Serializable]
    [Obsolete("Classes provided in this namespace are deprecated. Use Minty.Model instead")]
    class Graph
    {
        private const double tolerance = 0.00001;
        private int vertexCount;
        private double[,] edgeWeights;

        public double Tolerance { get => tolerance; }
        public int VertexCount { get => vertexCount; set => vertexCount = value; }
        public double[,] EdgeWeights { get => edgeWeights; }


        public Graph(int vertexCount)
        {
            this.vertexCount = vertexCount;
            edgeWeights = new double[vertexCount, vertexCount];

            for (int i = 0; i < vertexCount; i++)
            {
                for (int j = 0; j < vertexCount; j++)
                {
                    edgeWeights[i, j] = -1;
                }
            }
        }

        public double this[int i, int j, IndexatorOption option = IndexatorOption.COST]
        {
            get
            {
                switch(option)
                {
                    case IndexatorOption.COST:
                        return edgeWeights[i, j];
                    case IndexatorOption.HAS_PATH:
                        return (edgeWeights[i, j] < 0) ? 0 : 1;
                    default:
                        return edgeWeights[i, j];
                }
            }

            set
            {
                edgeWeights[i, j] = value;
            }
        }

        public void Load(string fileName)
        {

        }

        public void Save(string fileName)
        {

        }

        /// <summary>
        /// Method MintyAnalyze() is the core method of the application.
        /// It contains the implementation of Minty's algorithm for finding
        /// the shortest path in a graph.
        /// </summary>
        /// <param name="startVertex">A vertex of the graph that will be used
        /// as a source of all paths</param>
        /// <returns></returns>
        public MintyVertex[] MintyAnalyze(int startVertex)
        {
            MintyVertex[] result = new MintyVertex[vertexCount];
            result[startVertex] = new MintyVertex(0, -1, null);
            Dictionary<int, double> vertexInProcess = new Dictionary<int, double>();
            vertexInProcess.Add(startVertex, 0);

            while (vertexInProcess.Count > 0)
            {
                double minDistance = Double.MaxValue;
                int candidate = -1;
                int previousMinVertex = -1;

                List<int> otherPaths = new List<int>();

                foreach (var vertex in vertexInProcess)
                {
                    for (int i = 0; i < vertexCount; i++)
                    {
                        if (edgeWeights[vertex.Key, i] < 0)
                        {
                            continue;
                        }

                        double distance = vertex.Value + edgeWeights[vertex.Key, i];
                        if (distance < minDistance)
                        {
                            minDistance = distance;
                            candidate = i;
                            previousMinVertex = vertex.Key;
                            otherPaths.Clear();
                        } else if (Math.Abs(distance - minDistance) < tolerance &&
                            candidate == i)
                        {
                            otherPaths.Add(vertex.Key);
                        }
                    }
                }

                if (candidate != -1)
                {
                    result[candidate] = new MintyVertex(minDistance, previousMinVertex);
                    if (otherPaths.Count != 0)
                    {
                        result[candidate].OtherPreviousIndicies = otherPaths;
                    }
                    if (!vertexInProcess.ContainsKey(candidate))
                    {
                        vertexInProcess.Add(candidate, minDistance);
                    } else
                    {
                        break;
                    }
                }
            }

            List<int> verticesToUnprocess = new List<int>();
            foreach(var vertex in vertexInProcess)
            {
                int i = 0;
                for(; i < vertexCount; i++)
                {
                    if (edgeWeights[vertex.Key, i] < 0)
                    {
                        continue;
                    }
                    if (result[i] == null)
                    {
                        break;
                    }
                }

                if (i == vertexCount)
                {
                    verticesToUnprocess.Add(vertex.Key);
                }
            }

            foreach (var vertex in verticesToUnprocess)
            {
                verticesToUnprocess.Remove(vertex);
            }

            return result;
        }
    }
}
