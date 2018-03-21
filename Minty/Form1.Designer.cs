namespace Minty
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.vertexCountTextBox = new System.Windows.Forms.TextBox();
            this.createNetworkManualButton = new System.Windows.Forms.Button();
            this.manualNetworkGroupBox = new System.Windows.Forms.GroupBox();
            this.readNetworkFromFileGroupBox = new System.Windows.Forms.GroupBox();
            this.readNetworkFromFileButton = new System.Windows.Forms.Button();
            this.loadNetworkFileNameTextBox = new System.Windows.Forms.TextBox();
            this.graphMatrixGridView = new System.Windows.Forms.DataGridView();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.shortestPathResultTextBox = new System.Windows.Forms.TextBox();
            this.destinationVertexComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.saveGraphToFileButton = new System.Windows.Forms.Button();
            this.startVertexComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.calculateMintyShortestPathButton = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.resetFormButton = new System.Windows.Forms.Button();
            this.visualizeGraphButton = new System.Windows.Forms.Button();
            this.manualNetworkGroupBox.SuspendLayout();
            this.readNetworkFromFileGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graphMatrixGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Кількість вершин";
            // 
            // vertexCountTextBox
            // 
            this.vertexCountTextBox.Location = new System.Drawing.Point(107, 26);
            this.vertexCountTextBox.Name = "vertexCountTextBox";
            this.vertexCountTextBox.Size = new System.Drawing.Size(102, 20);
            this.vertexCountTextBox.TabIndex = 1;
            // 
            // createNetworkManualButton
            // 
            this.createNetworkManualButton.Location = new System.Drawing.Point(60, 52);
            this.createNetworkManualButton.Name = "createNetworkManualButton";
            this.createNetworkManualButton.Size = new System.Drawing.Size(150, 23);
            this.createNetworkManualButton.TabIndex = 2;
            this.createNetworkManualButton.Text = "Створити мережу";
            this.createNetworkManualButton.UseVisualStyleBackColor = true;
            this.createNetworkManualButton.Click += new System.EventHandler(this.createNetworkManualButton_Click);
            // 
            // manualNetworkGroupBox
            // 
            this.manualNetworkGroupBox.Controls.Add(this.vertexCountTextBox);
            this.manualNetworkGroupBox.Controls.Add(this.createNetworkManualButton);
            this.manualNetworkGroupBox.Controls.Add(this.label1);
            this.manualNetworkGroupBox.Location = new System.Drawing.Point(12, 12);
            this.manualNetworkGroupBox.Name = "manualNetworkGroupBox";
            this.manualNetworkGroupBox.Size = new System.Drawing.Size(240, 90);
            this.manualNetworkGroupBox.TabIndex = 3;
            this.manualNetworkGroupBox.TabStop = false;
            this.manualNetworkGroupBox.Text = "Створити мережу вручну";
            // 
            // readNetworkFromFileGroupBox
            // 
            this.readNetworkFromFileGroupBox.Controls.Add(this.readNetworkFromFileButton);
            this.readNetworkFromFileGroupBox.Controls.Add(this.loadNetworkFileNameTextBox);
            this.readNetworkFromFileGroupBox.Location = new System.Drawing.Point(261, 12);
            this.readNetworkFromFileGroupBox.Name = "readNetworkFromFileGroupBox";
            this.readNetworkFromFileGroupBox.Size = new System.Drawing.Size(240, 90);
            this.readNetworkFromFileGroupBox.TabIndex = 4;
            this.readNetworkFromFileGroupBox.TabStop = false;
            this.readNetworkFromFileGroupBox.Text = "Завантажити з файлу";
            // 
            // readNetworkFromFileButton
            // 
            this.readNetworkFromFileButton.Location = new System.Drawing.Point(38, 23);
            this.readNetworkFromFileButton.Name = "readNetworkFromFileButton";
            this.readNetworkFromFileButton.Size = new System.Drawing.Size(150, 23);
            this.readNetworkFromFileButton.TabIndex = 1;
            this.readNetworkFromFileButton.Text = "Завантажити";
            this.readNetworkFromFileButton.UseVisualStyleBackColor = true;
            this.readNetworkFromFileButton.Click += new System.EventHandler(this.readNetworkFromFileButton_Click);
            // 
            // loadNetworkFileNameTextBox
            // 
            this.loadNetworkFileNameTextBox.Location = new System.Drawing.Point(7, 52);
            this.loadNetworkFileNameTextBox.Name = "loadNetworkFileNameTextBox";
            this.loadNetworkFileNameTextBox.Size = new System.Drawing.Size(227, 20);
            this.loadNetworkFileNameTextBox.TabIndex = 0;
            // 
            // graphMatrixGridView
            // 
            this.graphMatrixGridView.AllowUserToAddRows = false;
            this.graphMatrixGridView.AllowUserToDeleteRows = false;
            this.graphMatrixGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.graphMatrixGridView.Location = new System.Drawing.Point(8, 45);
            this.graphMatrixGridView.Name = "graphMatrixGridView";
            this.graphMatrixGridView.Size = new System.Drawing.Size(604, 299);
            this.graphMatrixGridView.TabIndex = 5;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.visualizeGraphButton);
            this.groupBox1.Controls.Add(this.resetFormButton);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.shortestPathResultTextBox);
            this.groupBox1.Controls.Add(this.destinationVertexComboBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.saveGraphToFileButton);
            this.groupBox1.Controls.Add(this.startVertexComboBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.calculateMintyShortestPathButton);
            this.groupBox1.Controls.Add(this.graphMatrixGridView);
            this.groupBox1.Location = new System.Drawing.Point(13, 117);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(618, 413);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(294, 383);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Результат";
            // 
            // shortestPathResultTextBox
            // 
            this.shortestPathResultTextBox.Location = new System.Drawing.Point(359, 380);
            this.shortestPathResultTextBox.Name = "shortestPathResultTextBox";
            this.shortestPathResultTextBox.Size = new System.Drawing.Size(253, 20);
            this.shortestPathResultTextBox.TabIndex = 12;
            // 
            // destinationVertexComboBox
            // 
            this.destinationVertexComboBox.FormattingEnabled = true;
            this.destinationVertexComboBox.Location = new System.Drawing.Point(66, 379);
            this.destinationVertexComboBox.Name = "destinationVertexComboBox";
            this.destinationVertexComboBox.Size = new System.Drawing.Size(121, 21);
            this.destinationVertexComboBox.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 382);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Стік";
            // 
            // saveGraphToFileButton
            // 
            this.saveGraphToFileButton.Location = new System.Drawing.Point(512, 16);
            this.saveGraphToFileButton.Name = "saveGraphToFileButton";
            this.saveGraphToFileButton.Size = new System.Drawing.Size(100, 23);
            this.saveGraphToFileButton.TabIndex = 9;
            this.saveGraphToFileButton.Text = "Зберегти у файл";
            this.saveGraphToFileButton.UseVisualStyleBackColor = true;
            this.saveGraphToFileButton.Click += new System.EventHandler(this.saveGraphToFileButton_Click);
            // 
            // startVertexComboBox
            // 
            this.startVertexComboBox.FormattingEnabled = true;
            this.startVertexComboBox.Location = new System.Drawing.Point(66, 352);
            this.startVertexComboBox.Name = "startVertexComboBox";
            this.startVertexComboBox.Size = new System.Drawing.Size(121, 21);
            this.startVertexComboBox.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 355);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Джерело";
            // 
            // calculateMintyShortestPathButton
            // 
            this.calculateMintyShortestPathButton.Location = new System.Drawing.Point(255, 350);
            this.calculateMintyShortestPathButton.Name = "calculateMintyShortestPathButton";
            this.calculateMintyShortestPathButton.Size = new System.Drawing.Size(207, 23);
            this.calculateMintyShortestPathButton.TabIndex = 6;
            this.calculateMintyShortestPathButton.Text = "Побудувати найкоротший шлях";
            this.calculateMintyShortestPathButton.UseVisualStyleBackColor = true;
            this.calculateMintyShortestPathButton.Click += new System.EventHandler(this.calculateMintyShortestPathButton_Click);
            // 
            // resetFormButton
            // 
            this.resetFormButton.Location = new System.Drawing.Point(537, 350);
            this.resetFormButton.Name = "resetFormButton";
            this.resetFormButton.Size = new System.Drawing.Size(75, 23);
            this.resetFormButton.TabIndex = 14;
            this.resetFormButton.Text = "Очистити";
            this.resetFormButton.UseVisualStyleBackColor = true;
            this.resetFormButton.Click += new System.EventHandler(this.resetFormButton_Click);
            // 
            // visualizeGraphButton
            // 
            this.visualizeGraphButton.Location = new System.Drawing.Point(9, 16);
            this.visualizeGraphButton.Name = "visualizeGraphButton";
            this.visualizeGraphButton.Size = new System.Drawing.Size(125, 23);
            this.visualizeGraphButton.TabIndex = 15;
            this.visualizeGraphButton.Text = "Візуалізувати мережу";
            this.visualizeGraphButton.UseVisualStyleBackColor = true;
            this.visualizeGraphButton.Click += new System.EventHandler(this.visualizeGraphButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 549);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.readNetworkFromFileGroupBox);
            this.Controls.Add(this.manualNetworkGroupBox);
            this.Name = "Form1";
            this.Text = "Метод Мінті";
            this.manualNetworkGroupBox.ResumeLayout(false);
            this.manualNetworkGroupBox.PerformLayout();
            this.readNetworkFromFileGroupBox.ResumeLayout(false);
            this.readNetworkFromFileGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graphMatrixGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox vertexCountTextBox;
        private System.Windows.Forms.Button createNetworkManualButton;
        private System.Windows.Forms.GroupBox manualNetworkGroupBox;
        private System.Windows.Forms.GroupBox readNetworkFromFileGroupBox;
        private System.Windows.Forms.Button readNetworkFromFileButton;
        private System.Windows.Forms.TextBox loadNetworkFileNameTextBox;
        private System.Windows.Forms.DataGridView graphMatrixGridView;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button calculateMintyShortestPathButton;
        private System.Windows.Forms.ComboBox startVertexComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button saveGraphToFileButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox shortestPathResultTextBox;
        private System.Windows.Forms.ComboBox destinationVertexComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button resetFormButton;
        private System.Windows.Forms.Button visualizeGraphButton;
    }
}

