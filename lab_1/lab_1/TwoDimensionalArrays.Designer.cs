namespace Lab_1
{
    partial class TwoDimensionalArrays
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
            dgvMatrix = new DataGridView();
            label1 = new Label();
            btnCalculate = new Button();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvMatrix).BeginInit();
            SuspendLayout();
            // 
            // dgvMatrix
            // 
            dgvMatrix.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMatrix.Location = new Point(12, 44);
            dgvMatrix.Name = "dgvMatrix";
            dgvMatrix.Size = new Size(421, 394);
            dgvMatrix.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(39, 9);
            label1.Name = "label1";
            label1.Size = new Size(362, 21);
            label1.TabIndex = 1;
            label1.Text = "A 10x12 matrix based on the formula a[i][j] = i + 2j";
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(458, 415);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(123, 23);
            btnCalculate.TabIndex = 2;
            btnCalculate.Text = "Construct a matrix";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(696, 415);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 3;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // TwoDimensionalArrays
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClose);
            Controls.Add(btnCalculate);
            Controls.Add(label1);
            Controls.Add(dgvMatrix);
            Name = "TwoDimensionalArrays";
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)dgvMatrix).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvMatrix;
        private Label label1;
        private Button btnCalculate;
        private Button btnClose;
    }
}