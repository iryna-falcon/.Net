using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Lab_1.Arrays;

namespace Lab_1
{
    public partial class OneDimensionalArray : Form
    {
        public OneDimensionalArray()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            var f = Application.OpenForms[0];
            f.Show();
            this.Close();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            dgvArray.Rows.Clear();
            try
            {
                int n = Convert.ToInt32(txtN.Text);
                var array = new Arrays.OneDimensionalArray(n);
                for (int i = 0; i < array.Length; i++)
                {
                    dgvArray.Rows.Add(array[i].ToString());
                }
                var sum = array.Sum;
                lblSumEven.Text = sum.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
