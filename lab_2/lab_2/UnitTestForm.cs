using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace lab_2
{
    public partial class UnitTestForm : Form
    {
        public UnitTestForm()
        {
            InitializeComponent();
        }

        private void btnCalcTask1_Click(object sender, EventArgs e)
        {
            try
            {
                Task1 task = new Task1(
                    Convert.ToInt32(txtTask1_A.Text),
                    Convert.ToInt32(txtTask1_B.Text),
                    Convert.ToInt32(txtTask1_C.Text)
                );
                lblResultTask1.Text = task.CountGreaterThanThree().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка: " + ex.Message);
            }
        }

        private void btnCalcTask2_Click(object sender, EventArgs e)
        {
            try
            {
                Task2 task = new Task2(
                    Convert.ToInt32(txtTask2_A.Text),
                    Convert.ToInt32(txtTask2_B.Text)
                );
                lblResultTask2.Text = task.CalculateSum().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка: " + ex.Message);
            }
        }

        private void btnCalcTask3_Click(object sender, EventArgs e)
        {
            try
            {
                Tetrahedron tet = new Tetrahedron(
                    Convert.ToDouble(txtTask3_A.Text)
                );

                lblResultTask3.Text = $"Об'єм: {tet.CalculateVolume():F2}\n" +
                                      $"Висота: {tet.CalculateHeight():F2}\n" +
                                      $"Площа: {tet.CalculateSurfaceArea():F2}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка: " + ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms[0];
            form.Show();
            this.Close();
        }
    }
}
