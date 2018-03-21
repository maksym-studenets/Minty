using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minty
{
    public partial class GraphImageForm : Form
    {
        public GraphImageForm()
        {
            InitializeComponent();
        }

        private void GraphImageForm_Load(object sender, EventArgs e)
        {
            // graphVisualizationPictureBox.ImageLocation = "data\template.dt.jpg";
            string imagePath = @"..\..\data\template.dt.jpg";
            Console.WriteLine(imagePath);

            Image image = Image.FromFile(imagePath);

            graphVisualizationPictureBox.Height = image.Height;
            graphVisualizationPictureBox.Width = image.Width;

            graphVisualizationPictureBox.Image = image;

            //graphVisualizationPictureBox.Load(imagePath);
        }
    }
}
