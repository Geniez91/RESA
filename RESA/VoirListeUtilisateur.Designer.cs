namespace RESA
{
    partial class VoirListeUtilisateur
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NoUtilisateur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Utilisateur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MotdePasse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateInscri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateFerme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeCompte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Notel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoPortable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NoUtilisateur,
            this.Utilisateur,
            this.MotdePasse,
            this.Prenom,
            this.DateInscri,
            this.DateFerme,
            this.TypeCompte,
            this.Mail,
            this.Notel,
            this.NoPortable});
            this.dataGridView1.Location = new System.Drawing.Point(22, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1045, 441);
            this.dataGridView1.TabIndex = 0;

            // 
            // NoUtilisateur
            // 
            this.NoUtilisateur.HeaderText = "NoUtilisateur";
            this.NoUtilisateur.Name = "NoUtilisateur";
            // 
            // Utilisateur
            // 
            this.Utilisateur.HeaderText = "Utilisateur";
            this.Utilisateur.Name = "Utilisateur";
            // 
            // MotdePasse
            // 
            this.MotdePasse.HeaderText = "Mot de Passe";
            this.MotdePasse.Name = "MotdePasse";
            // 
            // Prenom
            // 
            this.Prenom.HeaderText = "Prenom";
            this.Prenom.Name = "Prenom";
            // 
            // DateInscri
            // 
            this.DateInscri.HeaderText = "Date Inscription";
            this.DateInscri.Name = "DateInscri";
            // 
            // DateFerme
            // 
            this.DateFerme.HeaderText = "Date Fermeture";
            this.DateFerme.Name = "DateFerme";
            // 
            // TypeCompte
            // 
            this.TypeCompte.HeaderText = "Type Compte";
            this.TypeCompte.Name = "TypeCompte";
            // 
            // Mail
            // 
            this.Mail.HeaderText = "Mail";
            this.Mail.Name = "Mail";
            // 
            // Notel
            // 
            this.Notel.HeaderText = "Numéro de Téléphone";
            this.Notel.Name = "Notel";
            // 
            // NoPortable
            // 
            this.NoPortable.HeaderText = "Numéro de Portable";
            this.NoPortable.Name = "NoPortable";
            // 
            // VoirListeUtilisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 473);
            this.Controls.Add(this.dataGridView1);
            this.Name = "VoirListeUtilisateur";
            this.Text = "VoirListeUtilisateur";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoUtilisateur;
        private System.Windows.Forms.DataGridViewTextBoxColumn Utilisateur;
        private System.Windows.Forms.DataGridViewTextBoxColumn MotdePasse;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateInscri;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateFerme;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeCompte;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Notel;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoPortable;
    }
}