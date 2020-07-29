namespace RESA
{
    partial class ConnexionUtilisateur
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btconnexion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rtblogin = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rtbMdp = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btconnexion
            // 
            this.btconnexion.Location = new System.Drawing.Point(75, 188);
            this.btconnexion.Name = "btconnexion";
            this.btconnexion.Size = new System.Drawing.Size(89, 24);
            this.btconnexion.TabIndex = 0;
            this.btconnexion.Text = "Se Connecter";
            this.btconnexion.UseVisualStyleBackColor = true;
            this.btconnexion.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Login";
            // 
            // rtblogin
            // 
            this.rtblogin.Location = new System.Drawing.Point(25, 50);
            this.rtblogin.Name = "rtblogin";
            this.rtblogin.Size = new System.Drawing.Size(209, 24);
            this.rtblogin.TabIndex = 2;
            this.rtblogin.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mot de passe";
            // 
            // rtbMdp
            // 
            this.rtbMdp.Location = new System.Drawing.Point(25, 139);
            this.rtbMdp.Name = "rtbMdp";
            this.rtbMdp.Size = new System.Drawing.Size(209, 27);
            this.rtbMdp.TabIndex = 4;
            this.rtbMdp.Text = "";
            // 
            // ConnexionUtilisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 239);
            this.Controls.Add(this.rtbMdp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rtblogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btconnexion);
            this.Name = "ConnexionUtilisateur";
            this.Text = "Connexion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btconnexion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtblogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtbMdp;
    }
}

