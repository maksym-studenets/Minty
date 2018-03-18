using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Minty
{

    /// <summary>
    /// This class 
    /// </summary>
    public partial class Form1 : Form
    {

        private int vertexCount = 0;
        private GraphUtils.Graph graph;
        private GraphUtils.MintyVertex[] mintyResult;

        public Form1()
        {
            InitializeComponent();
        }

        private void createNetworkManualButton_Click(object sender, EventArgs e)
        {
            bool parseResult = int.TryParse(vertexCountTextBox.Text, out vertexCount);

            InitializeUiLayout(vertexCount);

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

        private void InitializeUiLayout(int vertexCount)
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

        private void InitializeUiLayout(GraphUtils.Graph graph)
        {
            vertexCount = graph.VertexCount;
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

        private void ReadGraphFromUiMatrix()
        {
            graph = new GraphUtils.Graph(vertexCount);
            for (int i = 0; i < graphMatrixGridView.RowCount; i++)
            {
                for (int j = 0; j < graphMatrixGridView.ColumnCount; j++) {
                    try
                    {
                        if (graphMatrixGridView[j, i].Value != null)
                        {
                            graph[i, j] = double.Parse(graphMatrixGridView[j, i]
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
                ReadGraphFromUiMatrix();
                mintyResult = graph.MintyAnalyze(1);

                for (int i = 0; i < mintyResult.Length; i++)
                {
                    List<int> resVertices = mintyResult[i].otherPreviousIndicies;
                    
                    foreach (int element in resVertices)
                    {
                        Console.WriteLine(element);
                    }

                    Console.WriteLine();
                }
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
