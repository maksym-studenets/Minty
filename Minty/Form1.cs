using System;
using System.Collections.Generic;
using System.Windows.Forms;

using Minty.Model;

namespace Minty
{

    /// <summary>
    /// This class defines the main GUI form of the application and provides
    /// handlers for events that occur when a user interacts with UI controls.
    /// In terms of the MVC pattern, this class acts as a controller.
    /// </summary>
    [Obsolete("Minty.GraphUtils is deprecated. Use Minty.Model and Minty.Service instead")]
    public partial class Form1 : Form
    {

        private int vertexCount = 0;
        private Graph graph;
        private LinkedList<Vertex> path;

        #region DEPRECATED_MEMBERS
        private GraphUtils.MintyVertex[] mintyResult;
        private GraphUtils.Graph mGraph;
        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        private void createNetworkManualButton_Click(object sender, EventArgs e)
        {
            bool parseResult = int.TryParse(vertexCountTextBox.Text, out vertexCount);

            initializeUiLayout(vertexCount);

            if ((vertexCount <= 0 || vertexCount > 500) || !parseResult)
            {
                MessageBox.Show("Please enter a value in range between 0 and 500!",
                    "Invalid parameter");
                vertexCountTextBox.Clear();
            }
        }

        private void readNetworkFromFileButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filename = openFileDialog.FileName;
                    loadNetworkFileNameTextBox.Text = filename;
                }
            } catch (Exception ex)
            {
                MessageBox.Show("Failed to read the file!", "Error");
            }
        }

        private void initializeUiLayout(int vertexCount)
        {
            graphMatrixGridView.Rows.Clear();
            graphMatrixGridView.Columns.Clear();
            graphMatrixGridView.Refresh();

            for (int i = 0; i < vertexCount; i++)
            {
                graphMatrixGridView.Columns.Add(i.ToString(), (i + 1).ToString());
                graphMatrixGridView.Columns[i].Width = 40;
                graphMatrixGridView.Columns[i].SortMode = 
                    DataGridViewColumnSortMode.NotSortable;
                graphMatrixGridView.Rows.Add();
                graphMatrixGridView.Rows[i].HeaderCell.Value = (i + 1).ToString();
                startVertexComboBox.Items.Add(i + 1);
            }
        }

        private void initializeUiLayout(Graph graph)
        {
            vertexCount = graph.Vertices.Capacity;
            this.graph = graph;

            graphMatrixGridView.Rows.Clear();
            graphMatrixGridView.Columns.Clear();
            graphMatrixGridView.Refresh();

            for (int i = 0; i < vertexCount; i++)
            {
                graphMatrixGridView.Columns.Add(i.ToString(), (i + 1).ToString());
                graphMatrixGridView.Columns[i].Width = 40;
                graphMatrixGridView.Columns[i].SortMode =
                    DataGridViewColumnSortMode.NotSortable;
                graphMatrixGridView.Rows.Add();
                graphMatrixGridView.Rows[i].HeaderCell.Value = (i + 1).ToString();

                startVertexComboBox.Items.Add(i + 1);
            }
            startVertexComboBox.SelectedValue = startVertexComboBox.Items[0];
        }

        [Obsolete]
        private void InitializeUiLayout(GraphUtils.Graph graph)
        {
            vertexCount = graph.VertexCount;
            this.mGraph = graph;

            graphMatrixGridView.Rows.Clear();
            graphMatrixGridView.Columns.Clear();
            graphMatrixGridView.Refresh();

            for (int i = 0; i < vertexCount; i++)
            {
                graphMatrixGridView.Columns.Add(i.ToString(), (i + 1).ToString());
                graphMatrixGridView.Columns[i].Width = 40;
                graphMatrixGridView.Columns[i].SortMode =
                    DataGridViewColumnSortMode.NotSortable;
                graphMatrixGridView.Rows.Add();
                graphMatrixGridView.Rows[i].HeaderCell.Value = (i + 1).ToString();

                startVertexComboBox.Items.Add(i + 1);
            }
            startVertexComboBox.SelectedValue = startVertexComboBox.Items[0];
        }

        private void readGraphFromUiMatrix()
        {
            Graph graph = new Graph();
            List<Vertex> vertices = new List<Vertex>();
            List<Edge> edges = new List<Edge>();

            for (int i = 0; i < vertexCount; i++) {
                vertices.Add(new Vertex(i + 1));
            }
            graph.Vertices = vertices;

            for (int i = 0; i < graphMatrixGridView.RowCount; i++) {
                for (int j = 0; j < graphMatrixGridView.ColumnCount; j++) {
                   // try {
                        if (graphMatrixGridView[j, i].Value != null) {
                            Edge edge = new Edge(vertices[i], vertices[j],
                                int.Parse(graphMatrixGridView[j, i].Value.ToString()));
                            edges.Add(edge);
                        }
                    /*} catch(Exception ex) {
                        MessageBox.Show("Failed to read values", "Error");
                    }*/
                }
            }
            graph.Edges = edges;
        }


        [Obsolete]
        private void ReadGraphFromUiMatrix()
        {
            mGraph = new GraphUtils.Graph(vertexCount);
            for (int i = 0; i < graphMatrixGridView.RowCount; i++)
            {
                for (int j = 0; j < graphMatrixGridView.ColumnCount; j++) {
                    try
                    {
                        if (graphMatrixGridView[j, i].Value != null)
                        {
                            mGraph[i, j] = double.Parse(graphMatrixGridView[j, i]
                                .Value.ToString());
                        }
                    } catch (Exception ex)
                    {
                        MessageBox.Show("Failed to read values", "Error");
                    }
            }
            }
        }

        private void calculateMintyShortestPathButton_Click(object sender, EventArgs e)
        {
            try
            {
                //ReadGraphFromUiMatrix();
                readGraphFromUiMatrix();


                Console.WriteLine("=== TEST ===");
                foreach (Vertex vertex in graph.Vertices) {
                    Console.WriteLine(vertex.ToString());
                }
                foreach (Edge edge in graph.Edges) {
                    Console.WriteLine(edge.Source.ToString() + " - " + edge.Destination + ": " +
                        edge.Weight);
                }
                Console.WriteLine("=== END TEST ===");



                /*
                mintyResult = mGraph.MintyAnalyze(1);

                for (int i = 0; i < mintyResult.Length; i++)
                {
                    List<int> resVertices = mintyResult[i].otherPreviousIndicies;
                    
                    foreach (int element in resVertices)
                    {
                        Console.WriteLine(element);
                    }

                    Console.WriteLine();
                }
                */


                //Console.WriteLine(mintyResult.ToString());
            } catch(Exception ex)
            {
                MessageBox.Show("Failed to calculate shortest path", "Error");
                Console.WriteLine(ex.Source);
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}
