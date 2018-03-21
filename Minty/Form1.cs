using Minty.Model;
using Minty.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Minty.Util;
using Newtonsoft.Json;

namespace Minty
{

    /// <summary>
    /// This class defines the main GUI form of the application and provides
    /// handlers for events that occur when a user interacts with UI controls.
    /// In terms of the MVC pattern, this class acts as a controller.
    /// </summary>
    public partial class Form1 : Form
    {

        private int vertexCount = 0;
        private Graph graph;

        public Form1() {
            InitializeComponent();
        }

        private void createNetworkManualButton_Click(object sender, EventArgs e) {
            bool parseResult = int.TryParse(vertexCountTextBox.Text, out vertexCount);

            initializeUiLayout(vertexCount);

            if ((vertexCount <= 0 || vertexCount > 500) || !parseResult) {
                MessageBox.Show("Будь ласка, введіть ціле число від 1 до 500",
                    "Поганий параметр");
                vertexCountTextBox.Clear();
            }
        }

        private void readNetworkFromFileButton_Click(object sender, EventArgs e) {
            try {
                openFileDialog.Filter = "Minti Network (json)|*.json";
                if (openFileDialog.ShowDialog() == DialogResult.OK) {
                    graph = FileSystemManager.readGraphFromFile(openFileDialog.FileName);
                    loadNetworkFileNameTextBox.Text = openFileDialog.FileName;
                    printAdjacencyMatrix();
                }
            } catch (Exception ex) {
                MessageBox.Show("Не вдалося прочитати файл", "Помилка");
                Console.WriteLine(ex.Source);
                Console.WriteLine(ex.Message);
            }
        }

        private void initializeUiLayout(int vertexCount) {
            graphMatrixGridView.Rows.Clear();
            graphMatrixGridView.Columns.Clear();
            graphMatrixGridView.Refresh();

            for (int i = 0; i < vertexCount; i++) {
                graphMatrixGridView.Columns.Add(i.ToString(), (i + 1).ToString());
                graphMatrixGridView.Columns[i].Width = 40;
                graphMatrixGridView.Columns[i].SortMode = 
                    DataGridViewColumnSortMode.NotSortable;
                graphMatrixGridView.Rows.Add();
                graphMatrixGridView.Rows[i].HeaderCell.Value = (i + 1).ToString();

                startVertexComboBox.Items.Add(i + 1);
                destinationVertexComboBox.Items.Add(i + 1);
            }

            startVertexComboBox.SelectedIndex = 0;
            destinationVertexComboBox.SelectedIndex = destinationVertexComboBox.Items.Count - 1;
        }

        private void initializeUiLayout(Graph graph) {
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
                destinationVertexComboBox.Items.Add(i + 1);
            }

            startVertexComboBox.SelectedIndex = 0;
            destinationVertexComboBox.SelectedIndex = destinationVertexComboBox.Items.Count - 1;
        }


        private Graph readGraphFromUiMatrix() {
            Graph graph = new Graph();
            vertexCount = graphMatrixGridView.Rows.Count;
            List<Vertex> vertices = new List<Vertex>();
            List<Edge> edges = new List<Edge>();

            for (int i = 0; i < vertexCount; i++) {
                vertices.Add(new Vertex(i + 1));
            }
            graph.Vertices = vertices;

            for (int i = 0; i < graphMatrixGridView.RowCount; i++) {
                for (int j = 0; j < graphMatrixGridView.ColumnCount; j++) {
                    try {
                        if (graphMatrixGridView[j, i].Value != null) {
                            Edge edge = new Edge(vertices[i], vertices[j],
                                int.Parse(graphMatrixGridView[j, i].Value.ToString()));
                            edges.Add(edge);
                        }
                    } catch(Exception ex) {
                        MessageBox.Show("Помилка при зчитуванні даних", "Помилка");
                        Console.WriteLine(ex.Source);
                        Console.WriteLine(ex.Message);
                        Console.WriteLine(ex.StackTrace);
                    }
                }
            }
            graph.Edges = edges;
            return graph;
        }

        private void printAdjacencyMatrix() {
            List<Edge> edges = graph.Edges;

            for (int i = 0; i < graph.Vertices.Count; i++) {
                graphMatrixGridView.Columns.Add(i.ToString(), (i + 1).ToString());
                graphMatrixGridView.Columns[i].Width = 40;
                graphMatrixGridView.Columns[i].SortMode =
                    DataGridViewColumnSortMode.NotSortable;
                graphMatrixGridView.Rows.Add();
                graphMatrixGridView.Rows[i].HeaderCell.Value = (i + 1).ToString();
                startVertexComboBox.Items.Add(i + 1);
                destinationVertexComboBox.Items.Add(i + 1);
            }

            foreach (Edge edge in edges) {
                graphMatrixGridView[edge.Destination.Id - 1, edge.Source.Id - 1].Value =
                    edge.Weight;
            }

            startVertexComboBox.SelectedIndex = 0;
            destinationVertexComboBox.SelectedIndex = destinationVertexComboBox.Items.Count - 1;
        }

        private void calculateMintyShortestPathButton_Click(object sender, EventArgs e) {
            try {
                graph = readGraphFromUiMatrix();
                // vertexCount = graph.Vertices.Count;
                int sourceVertexIndex = startVertexComboBox.SelectedIndex;
                int destinationVertexIndex = destinationVertexComboBox.SelectedIndex;

                MintyAlgorithm mintyAlgorithm = new MintyAlgorithm(graph);
                mintyAlgorithm.execute(graph.Vertices[sourceVertexIndex]);
                List<Vertex> shortestPath = mintyAlgorithm.computePath(graph
                    .Vertices[destinationVertexIndex]);

                StringBuilder resultStringBuilder = new StringBuilder();
                foreach (Vertex vertex in shortestPath) {
                    resultStringBuilder.Append(vertex.Id + "->");
                }

                string result = resultStringBuilder.ToString().TrimEnd('-', '>');
                shortestPathResultTextBox.Text = result;
            } catch(Exception ex) {
                MessageBox.Show("Неможливо побудувати шлях", "Помилка");
            }
        }

        private void saveGraphToFileButton_Click(object sender, EventArgs e)
        {
            if (graph == null) {
                readGraphFromUiMatrix();
            }

            saveFileDialog.Filter = "Minty Network in JSON format (*.json)|*.json";
            saveFileDialog.DefaultExt = ".json";
            if (saveFileDialog.ShowDialog() == DialogResult.OK) {
                FileSystemManager.saveGraphToFile(graph, saveFileDialog.FileName);
            }
        }

        private void resetFormButton_Click(object sender, EventArgs e)
        {
            vertexCountTextBox.Text = "";
            loadNetworkFileNameTextBox.Text = "";
            startVertexComboBox.Items.Clear();
            destinationVertexComboBox.Items.Clear();
            startVertexComboBox.ResetText();
            destinationVertexComboBox.ResetText();
            graphMatrixGridView.Rows.Clear();
            graphMatrixGridView.Columns.Clear();
            shortestPathResultTextBox.Text = "";

            graph = null;
        }

        private void visualizeGraphButton_Click(object sender, EventArgs e)
        {
            GraphVisualizer graphVisualizer = new GraphVisualizer();
            string dotFile = graphVisualizer.generateDotFileForGraph(graph);
            FileSystemManager.saveGraphDotTemplateToFile(dotFile);
            graphVisualizer.generateGraphBitmap();
            GraphImageForm graphImageForm = new GraphImageForm();
            graphImageForm.Show(this);
        }
    }
}
