namespace RESA
{
    partial class Accueil
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
            this.btConsulter = new System.Windows.Forms.Button();
            this.btConnexion = new System.Windows.Forms.Button();
            this.gbAdmin = new System.Windows.Forms.GroupBox();
            this.btlisteUtilisateur = new System.Windows.Forms.Button();
            this.btListeSemaine = new System.Windows.Forms.Button();
            this.btvoirheberg = new System.Windows.Forms.Button();
            this.btCreer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btConsulter
            // 
            this.btConsulter.Location = new System.Drawing.Point(12, 152);
            this.btConsulter.Name = "btConsulter";
            this.btConsulter.Size = new System.Drawing.Size(102, 78);
            this.btConsulter.TabIndex = 0;
            this.btConsulter.Text = "Consulter Hebergement";
            this.btConsulter.UseVisualStyleBackColor = true;
            this.btConsulter.Click += new System.EventHandler(this.btConsulter_Click);
            // 
            // btConnexion
            // 
            this.btConnexion.Location = new System.Drawing.Point(12, 55);
            this.btConnexion.Name = "btConnexion";
            this.btConnexion.Size = new System.Drawing.Size(102, 68);
            this.btConnexion.TabIndex = 1;
            this.btConnexion.Text = "Connexion";
            this.btConnexion.UseVisualStyleBackColor = true;
            this.btConnexion.Click += new System.EventHandler(this.btConnexion_Click);
            // 
            // gbAdmin
            // 
            this.gbAdmin.Controls.Add(this.btlisteUtilisateur);
            this.gbAdmin.Controls.Add(this.btListeSemaine);
            this.gbAdmin.Controls.Add(this.btvoirheberg);
            this.gbAdmin.Controls.Add(this.btCreer);
            this.gbAdmin.Location = new System.Drawing.Point(35, 12);
            this.gbAdmin.Name = "gbAdmin";
            this.gbAdmin.Size = new System.Drawing.Size(147, 391);
            this.gbAdmin.TabIndex = 2;
            this.gbAdmin.TabStop = false;
            this.gbAdmin.Text = "Mode Admin";
            this.gbAdmin.Visible = false;
            this.gbAdmin.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btlisteUtilisateur
            // 
            this.btlisteUtilisateur.Location = new System.Drawing.Point(24, 301);
            this.btlisteUtilisateur.Name = "btlisteUtilisateur";
            this.btlisteUtilisateur.Size = new System.Drawing.Size(91, 62);
            this.btlisteUtilisateur.TabIndex = 3;
            this.btlisteUtilisateur.Text = "Voir Liste Utilisateur";
            this.btlisteUtilisateur.UseVisualStyleBackColor = true;
            this.btlisteUtilisateur.Visible = false;
            this.btlisteUtilisateur.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btListeSemaine
            // 
            this.btListeSemaine.Location = new System.Drawing.Point(24, 199);
            this.btListeSemaine.Name = "btListeSemaine";
            this.btListeSemaine.Size = new System.Drawing.Size(91, 65);
            this.btListeSemaine.TabIndex = 2;
            this.btListeSemaine.Text = "Voir Liste Reservation Semaine";
            this.btListeSemaine.UseVisualStyleBackColor = true;
            this.btListeSemaine.Visible = false;
            this.btListeSemaine.Click += new System.EventHandler(this.btListeSemaine_Click);
            // 
            // btvoirheberg
            // 
            this.btvoirheberg.Location = new System.Drawing.Point(24, 102);
            this.btvoirheberg.Name = "btvoirheberg";
            this.btvoirheberg.Size = new System.Drawing.Size(91, 68);
            this.btvoirheberg.TabIndex = 1;
            this.btvoirheberg.Text = "Voir Hebergement";
            this.btvoirheberg.UseVisualStyleBackColor = true;
            this.btvoirheberg.Visible = false;
            this.btvoirheberg.Click += new System.EventHandler(this.button1_Click);
            // 
            // btCreer
            // 
            this.btCreer.Location = new System.Drawing.Point(24, 30);
            this.btCreer.Name = "btCreer";
            this.btCreer.Size = new System.Drawing.Size(91, 53);
            this.btCreer.TabIndex = 0;
            this.btCreer.Text = "Créer Hebergement";
            this.btCreer.UseVisualStyleBackColor = true;
            this.btCreer.Visible = false;
            this.btCreer.Click += new System.EventHandler(this.btCreer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label1.Location = new System.Drawing.Point(320, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Village Vacances Alpes";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.textBox1.Location = new System.Drawing.Point(188, 518);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(574, 40);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "Bienvenue sur l\'application VVA sur laquelle vous pourrez reserver des hebergemen" +
    "ts pour vos prochaines vacances.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RESA.Properties.Resources.Capture;
            this.pictureBox1.Location = new System.Drawing.Point(188, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(574, 470);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btConnexion);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btConsulter);
            this.groupBox1.Location = new System.Drawing.Point(786, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(120, 344);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fonctionallités";
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 570);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbAdmin);
            this.Name = "Accueil";
            this.Text = "Accueil";
            this.Load += new System.EventHandler(this.Accueil_Load);
            this.gbAdmin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btConsulter;
        private System.Windows.Forms.Button btConnexion;
        private System.Windows.Forms.GroupBox gbAdmin;
        private System.Windows.Forms.Button btCreer;
        private System.Windows.Forms.Button btvoirheberg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btListeSemaine;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btlisteUtilisateur;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}