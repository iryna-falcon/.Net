namespace Lab_1
{
    partial class OneDimensionalArray
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
            dgvArray = new DataGridView();
            dgv1D = new DataGridViewTextBoxColumn();
            label1 = new Label();
            txtN = new TextBox();
            btnCalc = new Button();
            label2 = new Label();
            lblSumEven = new Label();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvArray).BeginInit();
            SuspendLayout();
            // 
            // dgvArray
            // 
            dgvArray.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvArray.Columns.AddRange(new DataGridViewColumn[] { dgv1D });
            dgvArray.Location = new Point(12, 33);
            dgvArray.Name = "dgvArray";
            dgvArray.Size = new Size(240, 386);
            dgvArray.TabIndex = 0;
            // 
            // dgv1D
            // 
            dgv1D.HeaderText = "A";
            dgv1D.Name = "dgv1D";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(379, 53);
            label1.Name = "label1";
            label1.Size = new Size(27, 15);
            label1.TabIndex = 1;
            label1.Text = "N =";
            // 
            // txtN
            // 
            txtN.Location = new Point(412, 50);
            txtN.Name = "txtN";
            txtN.Size = new Size(73, 23);
            txtN.TabIndex = 2;
            txtN.Text = "20";
            // 
            // btnCalc
            // 
            btnCalc.Location = new Point(602, 50);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(75, 23);
            btnCalc.TabIndex = 3;
            btnCalc.Text = "Calculate";
            btnCalc.UseVisualStyleBackColor = true;
            btnCalc.Click += btnCalc_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(379, 116);
            label2.Name = "label2";
            label2.Size = new Size(167, 21);
            label2.TabIndex = 4;
            label2.Text = "Sum of even elements:";
            // 
            // lblSumEven
            // 
            lblSumEven.AutoSize = true;
            lblSumEven.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblSumEven.Location = new Point(552, 116);
            lblSumEven.Name = "lblSumEven";
            lblSumEven.Size = new Size(19, 21);
            lblSumEven.TabIndex = 7;
            lblSumEven.Text = "0";
            // 
            // btnClose
            // 
            btnClose.Location = new Point(695, 396);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 10;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // OneDimensionalArray
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClose);
            Controls.Add(lblSumEven);
            Controls.Add(label2);
            Controls.Add(btnCalc);
            Controls.Add(txtN);
            Controls.Add(label1);
            Controls.Add(dgvArray);
            Name = "OneDimensionalArray";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)dgvArray).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvArray;
        private DataGridViewTextBoxColumn dgv1D;
        private Label label1;
        private TextBox txtN;
        private Button btnCalc;
        private Label label2;
        private Label lblSumEven;
        private Button btnClose;
    }
}