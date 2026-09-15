using Task_1.Functions;

namespace lab_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            var tabul = new FunctionTabulation();
            double xn, xk, h, a;

            try
            {
                xn = Convert.ToDouble(this.txtXn.Text);
                xk = Convert.ToDouble(this.txtXk.Text);
                h = Convert.ToDouble(this.txtH.Text);
                a = Convert.ToDouble(this.txtA.Text);

                dgvResults.Rows.Clear();
                chartResults.Series[0].Points.Clear();

                tabul.Tabulation(xn, xk, h, a);

                for (int i = 0; i < tabul.n; i++)
                {
                    string strX = Math.Round(tabul.xy[i, 0], 2).ToString();
                    string strY = Math.Round(tabul.xy[i, 1], 3).ToString();

                    dgvResults.Rows.Add(strX, strY);

                    chartResults.Series[0].Points.AddXY(tabul.xy[i, 0], tabul.xy[i, 1]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data entry error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
