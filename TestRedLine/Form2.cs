using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestRedLine
{
    public partial class Form2 : Form
    {
        int taille;
        public Form2(Form1 form)
        {
            InitializeComponent();
            form.Visible=false;
            taille = int.Parse(form.nbJoueur.SelectedItem.ToString());
            //Dictionary<string, GroupBox> d = new Dictionary<string, GroupBox>();
            //d.Add("Joueur"+i, );
            Generation_GroupBox();

        }
        public GroupBox CloneGb(int i)
        {
            ComboBox cbClone = CloneComboBox(i);
            TextBox tbClone = CloneTextBox(i);
            GroupBox gbClone = new GroupBox();
            gbClone.Controls.Add(cbClone);
            gbClone.Controls.Add(tbClone);
            gbClone.Dock = System.Windows.Forms.DockStyle.Fill;
            gbClone.Name = "gbJoueur" + (i+1);
            gbClone.Size = new System.Drawing.Size(498, 128);
            gbClone.Text = "groupBox" + (i+1);
            gbClone.Enter += new System.EventHandler(this.groupBox1_Enter);
            return gbClone;
        }
        public ComboBox CloneComboBox(int i)
        {
            ComboBox cbClone = new ComboBox();
            cbClone.FormattingEnabled = true;
            cbClone.Location= new System.Drawing.Point(9, 51);
            cbClone.Items.AddRange(new object[] {
                System.Drawing.Color.LightBlue,
                System.Drawing.Color.LightPink,
                System.Drawing.Color.LightSalmon,
                System.Drawing.Color.LightGreen,
                System.Drawing.Color.LightCoral,
                System.Drawing.Color.LightCyan,
                System.Drawing.Color.LightGray,
                System.Drawing.Color.LightGoldenrodYellow});
            cbClone.Name = "cbCouleurJoueur"+(i+1);
            cbClone.Size = new System.Drawing.Size(132, 23);
            cbClone.SelectedIndexChanged += new System.EventHandler(this.cbCouleurJoueur1_SelectedIndexChanged);
            return cbClone;
        }
        public TextBox CloneTextBox(int i)
        {
            TextBox tbClone = new TextBox();
            tbClone.Location = new System.Drawing.Point(9, 22);
            tbClone.Name = "tbPseudoJoueur"+(i+1);
            tbClone.PlaceholderText = "Pseudo";
            tbClone.Size = new System.Drawing.Size(132, 23);
            return tbClone;
        }
        private void Generation_GroupBox()
        {

            for(int i = 1; i<taille;i++)
            {
                GroupBox gbClone = CloneGb(i);
                if (i>2)
                {
                    tableLayoutPanel1.Controls.Add(gbClone, 1 , i-3);
                }
                else
                {
                    tableLayoutPanel1.Controls.Add(gbClone, 0 , i);
                }
            }

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

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bValiderJoueurs_Click(object sender, EventArgs e)
        {

        }

        private void cbCouleurJoueur1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cbJoueurs = sender as ComboBox;
            //System.Windows.Forms.GroupBox gpJoueurs = cbJoueurs.Parent as System.Windows.Forms.GroupBox;
            GroupBox gpJoueurs = cbJoueurs.Parent as GroupBox;
            gpJoueurs.BackColor = (Color)cbJoueurs.SelectedItem;
        }
    }
}
