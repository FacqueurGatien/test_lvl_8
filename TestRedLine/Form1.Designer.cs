namespace TestRedLine
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        public void InitializeComponent()
        {
            this.Main_Titre = new System.Windows.Forms.Label();
            this.Lancer = new System.Windows.Forms.Button();
            this.Setting = new System.Windows.Forms.Button();
            this.Quit = new System.Windows.Forms.Button();
            this.nbJoueur = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Main_Titre
            // 
            this.Main_Titre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Main_Titre.AutoSize = true;
            this.Main_Titre.Location = new System.Drawing.Point(414, 164);
            this.Main_Titre.Name = "Main_Titre";
            this.Main_Titre.Size = new System.Drawing.Size(139, 15);
            this.Main_Titre.TabIndex = 0;
            this.Main_Titre.Text = "Bienvenue sur niveau 9-1";
            this.Main_Titre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Main_Titre.Click += new System.EventHandler(this.label1_Click);
            // 
            // Lancer
            // 
            this.Lancer.Enabled = false;
            this.Lancer.Location = new System.Drawing.Point(0, 22);
            this.Lancer.Name = "Lancer";
            this.Lancer.Size = new System.Drawing.Size(75, 23);
            this.Lancer.TabIndex = 1;
            this.Lancer.Text = "Lancer";
            this.Lancer.UseVisualStyleBackColor = true;
            this.Lancer.Click += new System.EventHandler(this.button1_Click);
            // 
            // Setting
            // 
            this.Setting.Location = new System.Drawing.Point(442, 274);
            this.Setting.Name = "Setting";
            this.Setting.Size = new System.Drawing.Size(75, 23);
            this.Setting.TabIndex = 2;
            this.Setting.Text = "Setting";
            this.Setting.UseVisualStyleBackColor = true;
            // 
            // Quit
            // 
            this.Quit.Location = new System.Drawing.Point(760, 274);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(75, 23);
            this.Quit.TabIndex = 3;
            this.Quit.Text = "Quitter";
            this.Quit.UseVisualStyleBackColor = true;
            this.Quit.Click += new System.EventHandler(this.button3_Click);
            // 
            // nbJoueur
            // 
            this.nbJoueur.FormattingEnabled = true;
            this.nbJoueur.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.nbJoueur.Location = new System.Drawing.Point(73, 22);
            this.nbJoueur.Name = "nbJoueur";
            this.nbJoueur.Size = new System.Drawing.Size(121, 23);
            this.nbJoueur.TabIndex = 4;
            this.nbJoueur.SelectedIndexChanged += new System.EventHandler(this.NbJoueur_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Lancer);
            this.groupBox1.Controls.Add(this.nbJoueur);
            this.groupBox1.Location = new System.Drawing.Point(146, 251);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 116);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choisissez le nombre de joueurs";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 537);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Quit);
            this.Controls.Add(this.Setting);
            this.Controls.Add(this.Main_Titre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Main_Titre;
        private Button Lancer;
        private Button Setting;
        private Button Quit;
        internal ComboBox nbJoueur;
        private GroupBox groupBox1;
    }
}