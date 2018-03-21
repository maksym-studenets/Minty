namespace Minty
{
    partial class GraphImageForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.graphVisualizationPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.graphVisualizationPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // graphVisualizationPictureBox
            // 
            this.graphVisualizationPictureBox.Location = new System.Drawing.Point(12, 12);
            this.graphVisualizationPictureBox.Name = "graphVisualizationPictureBox";
            this.graphVisualizationPictureBox.Size = new System.Drawing.Size(789, 554);
            this.graphVisualizationPictureBox.TabIndex = 0;
            this.graphVisualizationPictureBox.TabStop = false;
            // 
            // GraphImageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 661);
            this.Controls.Add(this.graphVisualizationPictureBox);
            this.Name = "GraphImageForm";
            this.Text = "Візуалізація мережі";
            this.Load += new System.EventHandler(this.GraphImageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.graphVisualizationPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox graphVisualizationPictureBox;
    }
}