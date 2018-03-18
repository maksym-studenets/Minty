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
            this.startVertexComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.calculateMintyShortestPathButton = new System.Windows.Forms.Button();
            this.saveGraphToFileButton = new System.Windows.Forms.Button();
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
            this.readNetworkFromFileButton.Location = new System.Drawing.Point(55, 52);
            this.readNetworkFromFileButton.Name = "readNetworkFromFileButton";
            this.readNetworkFromFileButton.Size = new System.Drawing.Size(150, 23);
            this.readNetworkFromFileButton.TabIndex = 1;
            this.readNetworkFromFileButton.Text = "Завантажити";
            this.readNetworkFromFileButton.UseVisualStyleBackColor = true;
            this.readNetworkFromFileButton.Click += new System.EventHandler(this.readNetworkFromFileButton_Click);
            // 
            // loadNetworkFileNameTextBox
            // 
            this.loadNetworkFileNameTextBox.Location = new System.Drawing.Point(7, 22);
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
            // startVertexComboBox
            // 
            this.startVertexComboBox.FormattingEnabled = true;
            this.startVertexComboBox.Location = new System.Drawing.Point(59, 352);
            this.startVertexComboBox.Name = "startVertexComboBox";
            this.startVertexComboBox.Size = new System.Drawing.Size(121, 21);
            this.startVertexComboBox.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 355);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Початок";
            // 
            // calculateMintyShortestPathButton
            // 
            this.calculateMintyShortestPathButton.Location = new System.Drawing.Point(492, 350);
            this.calculateMintyShortestPathButton.Name = "calculateMintyShortestPathButton";
            this.calculateMintyShortestPathButton.Size = new System.Drawing.Size(120, 23);
            this.calculateMintyShortestPathButton.TabIndex = 6;
            this.calculateMintyShortestPathButton.Text = "Calculate";
            this.calculateMintyShortestPathButton.UseVisualStyleBackColor = true;
            this.calculateMintyShortestPathButton.Click += new System.EventHandler(this.calculateMintyShortestPathButton_Click);
            // 
            // saveGraphToFileButton
            // 
            this.saveGraphToFileButton.Location = new System.Drawing.Point(512, 16);
            this.saveGraphToFileButton.Name = "saveGraphToFileButton";
            this.saveGraphToFileButton.Size = new System.Drawing.Size(100, 23);
            this.saveGraphToFileButton.TabIndex = 9;
            this.saveGraphToFileButton.Text = "Зберегти у файл";
            this.saveGraphToFileButton.UseVisualStyleBackColor = true;
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
    }
}

