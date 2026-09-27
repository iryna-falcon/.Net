namespace lab_2
{
    partial class UnitTestForm
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
            components = new System.ComponentModel.Container();
            notifyIcon1 = new NotifyIcon(components);
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            lblResultTask1 = new Label();
            btnCalcTask1 = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtTask1_C = new TextBox();
            txtTask1_B = new TextBox();
            txtTask1_A = new TextBox();
            tabPage2 = new TabPage();
            lblResultTask2 = new Label();
            btnCalcTask2 = new Button();
            label6 = new Label();
            label5 = new Label();
            txtTask2_B = new TextBox();
            txtTask2_A = new TextBox();
            tabPage3 = new TabPage();
            lblResultTask3 = new Label();
            btnCalcTask3 = new Button();
            label8 = new Label();
            txtTask3_A = new TextBox();
            btnClose = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(2, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(797, 402);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(lblResultTask1);
            tabPage1.Controls.Add(btnCalcTask1);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(txtTask1_C);
            tabPage1.Controls.Add(txtTask1_B);
            tabPage1.Controls.Add(txtTask1_A);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(789, 374);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Завдання 1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblResultTask1
            // 
            lblResultTask1.AutoSize = true;
            lblResultTask1.Location = new Point(20, 123);
            lblResultTask1.Name = "lblResultTask1";
            lblResultTask1.Size = new Size(60, 15);
            lblResultTask1.TabIndex = 7;
            lblResultTask1.Text = "Результат";
            // 
            // btnCalcTask1
            // 
            btnCalcTask1.Location = new Point(574, 37);
            btnCalcTask1.Name = "btnCalcTask1";
            btnCalcTask1.Size = new Size(85, 23);
            btnCalcTask1.TabIndex = 6;
            btnCalcTask1.Text = "Розрахувати";
            btnCalcTask1.UseVisualStyleBackColor = true;
            btnCalcTask1.Click += btnCalcTask1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(380, 40);
            label3.Name = "label3";
            label3.Size = new Size(24, 15);
            label3.TabIndex = 5;
            label3.Text = "c =";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(194, 40);
            label2.Name = "label2";
            label2.Size = new Size(25, 15);
            label2.TabIndex = 4;
            label2.Text = "b =";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 40);
            label1.Name = "label1";
            label1.Size = new Size(24, 15);
            label1.TabIndex = 3;
            label1.Text = "a =";
            // 
            // txtTask1_C
            // 
            txtTask1_C.Location = new Point(410, 37);
            txtTask1_C.Name = "txtTask1_C";
            txtTask1_C.Size = new Size(100, 23);
            txtTask1_C.TabIndex = 2;
            // 
            // txtTask1_B
            // 
            txtTask1_B.Location = new Point(225, 37);
            txtTask1_B.Name = "txtTask1_B";
            txtTask1_B.Size = new Size(100, 23);
            txtTask1_B.TabIndex = 1;
            // 
            // txtTask1_A
            // 
            txtTask1_A.Location = new Point(50, 37);
            txtTask1_A.Name = "txtTask1_A";
            txtTask1_A.Size = new Size(100, 23);
            txtTask1_A.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(lblResultTask2);
            tabPage2.Controls.Add(btnCalcTask2);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(txtTask2_B);
            tabPage2.Controls.Add(txtTask2_A);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(789, 374);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Завдання 2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblResultTask2
            // 
            lblResultTask2.AutoSize = true;
            lblResultTask2.Location = new Point(19, 114);
            lblResultTask2.Name = "lblResultTask2";
            lblResultTask2.Size = new Size(60, 15);
            lblResultTask2.TabIndex = 5;
            lblResultTask2.Text = "Результат";
            // 
            // btnCalcTask2
            // 
            btnCalcTask2.Location = new Point(382, 39);
            btnCalcTask2.Name = "btnCalcTask2";
            btnCalcTask2.Size = new Size(84, 23);
            btnCalcTask2.TabIndex = 4;
            btnCalcTask2.Text = "Розрахувати";
            btnCalcTask2.UseVisualStyleBackColor = true;
            btnCalcTask2.Click += btnCalcTask2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(196, 42);
            label6.Name = "label6";
            label6.Size = new Size(25, 15);
            label6.TabIndex = 3;
            label6.Text = "b =";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 42);
            label5.Name = "label5";
            label5.Size = new Size(24, 15);
            label5.TabIndex = 2;
            label5.Text = "a =";
            // 
            // txtTask2_B
            // 
            txtTask2_B.Location = new Point(227, 39);
            txtTask2_B.Name = "txtTask2_B";
            txtTask2_B.Size = new Size(100, 23);
            txtTask2_B.TabIndex = 1;
            // 
            // txtTask2_A
            // 
            txtTask2_A.Location = new Point(49, 39);
            txtTask2_A.Name = "txtTask2_A";
            txtTask2_A.Size = new Size(100, 23);
            txtTask2_A.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(lblResultTask3);
            tabPage3.Controls.Add(btnCalcTask3);
            tabPage3.Controls.Add(label8);
            tabPage3.Controls.Add(txtTask3_A);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(789, 374);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Завдання 3";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // lblResultTask3
            // 
            lblResultTask3.AutoSize = true;
            lblResultTask3.Location = new Point(19, 107);
            lblResultTask3.Name = "lblResultTask3";
            lblResultTask3.Size = new Size(60, 15);
            lblResultTask3.TabIndex = 3;
            lblResultTask3.Text = "Результат";
            // 
            // btnCalcTask3
            // 
            btnCalcTask3.Location = new Point(206, 43);
            btnCalcTask3.Name = "btnCalcTask3";
            btnCalcTask3.Size = new Size(83, 23);
            btnCalcTask3.TabIndex = 2;
            btnCalcTask3.Text = "Розрахувати";
            btnCalcTask3.UseVisualStyleBackColor = true;
            btnCalcTask3.Click += btnCalcTask3_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(19, 46);
            label8.Name = "label8";
            label8.Size = new Size(24, 15);
            label8.TabIndex = 1;
            label8.Text = "a =";
            // 
            // txtTask3_A
            // 
            txtTask3_A.Location = new Point(49, 43);
            txtTask3_A.Name = "txtTask3_A";
            txtTask3_A.Size = new Size(100, 23);
            txtTask3_A.TabIndex = 0;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(713, 410);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 1;
            btnClose.Text = "Закрити";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // UnitTestForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClose);
            Controls.Add(tabControl1);
            Name = "UnitTestForm";
            Text = "UnitTestForm";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private NotifyIcon notifyIcon1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtTask1_C;
        private TextBox txtTask1_B;
        private TextBox txtTask1_A;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Label lblResultTask1;
        private Button btnCalcTask1;
        private Label lblResultTask2;
        private Button btnCalcTask2;
        private Label label6;
        private Label label5;
        private TextBox txtTask2_B;
        private TextBox txtTask2_A;
        private TextBox txtTask3_A;
        private Label lblResultTask3;
        private Button btnCalcTask3;
        private Label label8;
        private Button btnClose;
    }
}