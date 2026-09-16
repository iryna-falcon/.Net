using Lab_1.Arrays;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lab_1
{
    public partial class TwoDimensionalArrays : Form
    {
        public TwoDimensionalArrays()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            var f = Application.OpenForms[0];
            f.Show();
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                var matrix = new TwoDimensionalArray();

                dgvMatrix.Rows.Clear();
                dgvMatrix.Columns.Clear();

                for (int j = 0; j < matrix.YLength; j++)
                {
                    var col = new DataGridViewTextBoxColumn();
                    col.Width = 35;
                    col.HeaderText = j.ToString();
                    dgvMatrix.Columns.Add(col);
                }
                dgvMatrix.RowCount = matrix.XLength;

                for (int i = 0; i < matrix.XLength; i++)
                {
                    dgvMatrix.Rows[i].HeaderCell.Value = i.ToString();
                    for (int j = 0; j < matrix.YLength; j++)
                    {
                        dgvMatrix.Rows[i].Cells[j].Value = matrix[i, j].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
