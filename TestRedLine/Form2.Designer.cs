namespace TestRedLine
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbJoueur1 = new System.Windows.Forms.GroupBox();
            this.bCouleurJoueur1 = new System.Windows.Forms.Button();
            this.tbPseudoJoueur1 = new System.Windows.Forms.TextBox();
            this.cdJoueur1 = new System.Windows.Forms.ColorDialog();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gbJoueur1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbJoueur1
            // 
            this.gbJoueur1.Controls.Add(this.bCouleurJoueur1);
            this.gbJoueur1.Controls.Add(this.tbPseudoJoueur1);
            this.gbJoueur1.Location = new System.Drawing.Point(3, 3);
            this.gbJoueur1.Name = "gbJoueur1";
            this.gbJoueur1.Size = new System.Drawing.Size(197, 130);
            this.gbJoueur1.TabIndex = 0;
            this.gbJoueur1.TabStop = false;
            this.gbJoueur1.Text = "groupBox1";
            this.gbJoueur1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // bCouleurJoueur1
            // 
            this.bCouleurJoueur1.Location = new System.Drawing.Point(6, 51);
            this.bCouleurJoueur1.Name = "bCouleurJoueur1";
            this.bCouleurJoueur1.Size = new System.Drawing.Size(100, 23);
            this.bCouleurJoueur1.TabIndex = 1;
            this.bCouleurJoueur1.Text = "Couleur";
            this.bCouleurJoueur1.UseVisualStyleBackColor = true;
            this.bCouleurJoueur1.Click += new System.EventHandler(this.bCouleurJoueur1_Click);
            // 
            // tbPseudoJoueur1
            // 
            this.tbPseudoJoueur1.Location = new System.Drawing.Point(6, 22);
            this.tbPseudoJoueur1.Name = "tbPseudoJoueur1";
            this.tbPseudoJoueur1.PlaceholderText = "Pseudo";
            this.tbPseudoJoueur1.Size = new System.Drawing.Size(100, 23);
            this.tbPseudoJoueur1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1008, 537);
            this.tableLayoutPanel1.TabIndex = 1;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 537);
            this.Controls.Add(this.gbJoueur1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.gbJoueur1.ResumeLayout(false);
            this.gbJoueur1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox gbJoueur1;
        private TextBox tbPseudoJoueur1;
        private Button bCouleurJoueur1;
        private ColorDialog cdJoueur1;
        private TableLayoutPanel tableLayoutPanel1;
    }
}