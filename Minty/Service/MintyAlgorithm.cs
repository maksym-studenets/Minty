using System;
using System.Collections.Generic;
using System.Linq;

using Minty.Model;

namespace Minty.Service
{
    /// <summary>
    /// Class MintyAlgorithm is the core class of the application. It includes
    /// implementation of the Minty's algorithm for finding the shortest path in the graph.
    /// </summary>
    class MintyAlgorithm
    {
        private List<Vertex> vertices;
        private List<Edge> edges;
        private HashSet<Vertex> settledVertices;
        private HashSet<Vertex> unsettledVertices;
        private Dictionary<Vertex, Vertex> predecessors;
        private Dictionary<Vertex, Int32> distances;

        /// <summary>
        /// Constructor that instantiates a new object of MintyAlgorithm class.
        /// Takes an instance of Graph as a parameter. Graph reference is required
        /// to get a list of vertices and edges in the graph. These will be further
        /// used for processing
        /// </summary>
        /// <param name="graph">An instance of Graph object that will be processed
        /// using Minty's algorithm to find the shortest path</param>
        public MintyAlgorithm(Graph graph) {
            this.vertices = new List<Vertex>(graph.Vertices);
            this.edges = new List<Edge>(graph.Edges);

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="source"></param>
        public void execute(Vertex source) {
            settledVertices = new HashSet<Vertex>();
            unsettledVertices = new HashSet<Vertex>();
            predecessors = new Dictionary<Vertex, Vertex>();
            distances = new Dictionary<Vertex, int>();

            distances.Add(source, 0);
            unsettledVertices.Add(source);

            while (unsettledVertices.Count > 0) {
                Vertex node = calculateMinimum(unsettledVertices);
                settledVertices.Add(node);
                unsettledVertices.Remove(node);
                findMinimalDistances(node);
            }
        }

        public List<Vertex> computePath(Vertex target)
        {
            List<Vertex> pathReverse = new List<Vertex>();
            Vertex step = target;

            if (predecessors.TryGetValue(step, out Vertex predecessor)) {
                pathReverse.Add(step);

                while (predecessors.TryGetValue(step, out predecessor)) {
                    step = predecessors[step];
                    pathReverse.Add(step);
                }
            }

            pathReverse.Reverse();
            return pathReverse;
        }

        private void findMinimalDistances(Vertex node) {
            List<Vertex> adjacentVertices = findNeighbours(node);
            foreach (Vertex target in adjacentVertices) {
                if (calculateShortestDistance(target) > calculateShortestDistance(node) +
                    calculateDistance(node, target)) {
                    if (!distances.ContainsKey(target))
                    {
                        distances.Add(target, calculateShortestDistance(node) +
                            calculateDistance(node, target));
                        predecessors.Add(target, node);
                        unsettledVertices.Add(target);
                    }
                }
            }
        }

        private int calculateDistance(Vertex source, Vertex target) {
            foreach(Edge edge in edges) {
                if(edge.Source.Equals(source) &&
                    edge.Destination.Equals(target)) {
                    return edge.Weight;
                }
            }

            throw new Exception("The situation couldn't have occurred");
        }

        private List<Vertex> findNeighbours(Vertex vertex) {
            List<Vertex> neighbours = new List<Vertex>();
            foreach(Edge edge in edges) {
                if (edge.Source.Equals(vertex) &&  !isSettled(edge.Destination)) {
                    neighbours.Add(edge.Destination);
                }
            }
            return neighbours;
        }

        private Vertex calculateMinimum(HashSet<Vertex> vertices) {
            Vertex minimum = null;
            foreach (Vertex vertex in vertices) {
                if (minimum == null) {
                    minimum = vertex;
                } else {
                    if (calculateShortestDistance(vertex) < calculateShortestDistance(minimum)) {
                        minimum = vertex;
                    }
                }
            }
            return minimum;
        }

        private bool isSettled(Vertex vertex) {
            return settledVertices.Contains(vertex);
        }

        private int calculateShortestDistance(Vertex destination) {

            if (distances.TryGetValue(destination, out int distance)) {
                return distance;
            } else {
                return Int32.MaxValue;
            }
        }
    }
}
