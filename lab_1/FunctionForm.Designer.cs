namespace lab_1
{
    partial class FunctionForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FunctionForm));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnCalculate = new Button();
            dgvResults = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            chartResults = new System.Windows.Forms.DataVisualization.Charting.Chart();
            pictureBox1 = new PictureBox();
            txtXn = new TextBox();
            txtH = new TextBox();
            txtXk = new TextBox();
            txtA = new TextBox();
            menuStrip1 = new MenuStrip();
            workingWithArraysToolStripMenuItem = new ToolStripMenuItem();
            onedimensionalArraysToolStripMenuItem = new ToolStripMenuItem();
            twodimensionalArraysToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dgvResults).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartResults).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 29);
            label1.Name = "label1";
            label1.Size = new Size(21, 15);
            label1.TabIndex = 0;
            label1.Text = "Xn";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(150, 29);
            label2.Name = "label2";
            label2.Size = new Size(20, 15);
            label2.TabIndex = 1;
            label2.Text = "Xk";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(269, 29);
            label3.Name = "label3";
            label3.Size = new Size(14, 15);
            label3.TabIndex = 2;
            label3.Text = "h";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(371, 29);
            label4.Name = "label4";
            label4.Size = new Size(13, 15);
            label4.TabIndex = 3;
            label4.Text = "a";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(41, 122);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 4;
            label5.Text = "Results";
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(371, 96);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(75, 23);
            btnCalculate.TabIndex = 5;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // dgvResults
            // 
            dgvResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResults.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dgvResults.Location = new Point(41, 152);
            dgvResults.Name = "dgvResults";
            dgvResults.Size = new Size(242, 293);
            dgvResults.TabIndex = 6;
            // 
            // Column1
            // 
            Column1.HeaderText = "x";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "y";
            Column2.Name = "Column2";
            // 
            // chartResults
            // 
            chartArea1.Name = "ChartArea1";
            chartResults.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            chartResults.Legends.Add(legend1);
            chartResults.Location = new Point(320, 152);
            chartResults.Name = "chartResults";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartResults.Series.Add(series1);
            chartResults.Size = new Size(435, 293);
            chartResults.TabIndex = 7;
            chartResults.Text = "chart1";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(484, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(281, 134);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // txtXn
            // 
            txtXn.Location = new Point(41, 61);
            txtXn.Name = "txtXn";
            txtXn.Size = new Size(78, 23);
            txtXn.TabIndex = 9;
            // 
            // txtH
            // 
            txtH.Location = new Point(269, 61);
            txtH.Name = "txtH";
            txtH.Size = new Size(78, 23);
            txtH.TabIndex = 10;
            // 
            // txtXk
            // 
            txtXk.Location = new Point(150, 61);
            txtXk.Name = "txtXk";
            txtXk.Size = new Size(78, 23);
            txtXk.TabIndex = 11;
            // 
            // txtA
            // 
            txtA.Location = new Point(371, 61);
            txtA.Name = "txtA";
            txtA.Size = new Size(78, 23);
            txtA.TabIndex = 12;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { workingWithArraysToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 13;
            menuStrip1.Text = "menuStrip1";
            // 
            // workingWithArraysToolStripMenuItem
            // 
            workingWithArraysToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { onedimensionalArraysToolStripMenuItem, twodimensionalArraysToolStripMenuItem });
            workingWithArraysToolStripMenuItem.Name = "workingWithArraysToolStripMenuItem";
            workingWithArraysToolStripMenuItem.Size = new Size(124, 20);
            workingWithArraysToolStripMenuItem.Text = "Working with arrays";
            // 
            // onedimensionalArraysToolStripMenuItem
            // 
            onedimensionalArraysToolStripMenuItem.Name = "onedimensionalArraysToolStripMenuItem";
            onedimensionalArraysToolStripMenuItem.Size = new Size(200, 22);
            onedimensionalArraysToolStripMenuItem.Text = "One-dimensional arrays";
            onedimensionalArraysToolStripMenuItem.Click += onedimensionalArraysToolStripMenuItem_Click;
            // 
            // twodimensionalArraysToolStripMenuItem
            // 
            twodimensionalArraysToolStripMenuItem.Name = "twodimensionalArraysToolStripMenuItem";
            twodimensionalArraysToolStripMenuItem.Size = new Size(200, 22);
            twodimensionalArraysToolStripMenuItem.Text = "Two-dimensional arrays";
            twodimensionalArraysToolStripMenuItem.Click += twodimensionalArraysToolStripMenuItem_Click;
            // 
            // FunctionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtA);
            Controls.Add(txtXk);
            Controls.Add(txtH);
            Controls.Add(txtXn);
            Controls.Add(pictureBox1);
            Controls.Add(chartResults);
            Controls.Add(dgvResults);
            Controls.Add(btnCalculate);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FunctionForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvResults).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartResults).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnCalculate;
        private DataGridView dgvResults;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResults;
        private PictureBox pictureBox1;
        private TextBox txtXn;
        private TextBox txtH;
        private TextBox txtXk;
        private TextBox txtA;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem workingWithArraysToolStripMenuItem;
        private ToolStripMenuItem onedimensionalArraysToolStripMenuItem;
        private ToolStripMenuItem twodimensionalArraysToolStripMenuItem;
    }
}
