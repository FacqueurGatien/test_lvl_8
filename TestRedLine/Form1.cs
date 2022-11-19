namespace TestRedLine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void NbJoueur_SelectedIndexChanged(object sender, EventArgs e)
        {
            Lancer.Enabled = true;
            groupBox1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form2(this).ShowDialog();
        }
    }
}