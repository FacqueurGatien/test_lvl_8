using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestRedLine
{
    public partial class Form2 : Form
    {
        public Form2(Form1 form)
        {
            InitializeComponent();

            form.Visible=false;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void bCouleurJoueur1_Click(object sender, EventArgs e)
        {
            if (cdJoueur1.ShowDialog()==DialogResult.OK)
            {
                bCouleurJoueur1.BackColor = cdJoueur1.Color;
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
