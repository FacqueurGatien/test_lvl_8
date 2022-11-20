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
        //TODO Creation d'une GroupBox de base (sans nom de variable du coup elle sera assigné au tableLayoutPanel automatiquement)
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
        //TODO Creation d'une ComboBox de base (sans nom de variable du coup elle sera assigné a la groupBox créer automatiquement)
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

        //TODO Creation d'une textBox de base (sans nom de variable du coup elle sera assigné a la groupBox créer automatiquement)
        public TextBox CloneTextBox(int i)
        {
            TextBox tbClone = new TextBox();
            tbClone.Location = new System.Drawing.Point(9, 22);
            tbClone.Name = "tbPseudoJoueur"+(i+1);
            tbClone.PlaceholderText = "Pseudo";
            tbClone.Size = new System.Drawing.Size(132, 23);
            tbClone.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            return tbClone;
        }
        //TODO Generation automatique en fonction du nombre de joueur selmectionné
        private void Generation_GroupBox()
        {

            for(int i = 0; i<taille;i++)
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

        //TODO Pour faire la verification sur chaque textbox des qu'il est modifier
        /// <summary>
        /// Changer l'etat du bouton valider (Enable true or false) des que les textBox sont edité
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TextBox tbJoueur = sender as TextBox;
            GroupBox gbPlateau = (GroupBox)tbJoueur.Parent;
            TableLayoutPanel Plateau = (TableLayoutPanel)gbPlateau.Parent;
            bool resulttest = true;
            foreach (object gb in Plateau.Controls)
            {
                if (gb is GroupBox)
                {
                    GroupBox gbtest = (GroupBox)gb;
                    foreach (object tb in gbtest.Controls)
                    {
                        if (tb is TextBox)
                        {
                            TextBox tbtest = (TextBox)tb;
                            if (tbtest.Text == "")
                            {
                                resulttest = false;
                            }
                        }
                    }
                }
            }
            if (resulttest)
            {
                bValiderJoueurs.Enabled = true;
            }
            else
            {
                bValiderJoueurs.Enabled = false;
            }
        }

        //TODO Affiche un changement de couleur juste pour test 
        private void bValiderJoueurs_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.BackColor = Color.Beige;
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
