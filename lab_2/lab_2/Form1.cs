namespace lab_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void unitTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UnitTestForm f = new UnitTestForm();
            f.Show();
            this.Hide();
        }
    }
}
