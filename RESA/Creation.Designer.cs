namespace RESA
{
    partial class Creation
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.gbCaractéristique = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cbtype = new System.Windows.Forms.ComboBox();
            this.tbSecteur = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rtbdesc = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbAnneRemise = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.hsbSurface = new System.Windows.Forms.HScrollBar();
            this.label4 = new System.Windows.Forms.Label();
            this.cborientation = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btvalider = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btinserer = new System.Windows.Forms.Button();
            this.tbImage = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tbmontant = new System.Windows.Forms.TextBox();
            this.nupd = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.rbInternetoui = new System.Windows.Forms.RadioButton();
            this.rbInternet = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.cbEtat = new System.Windows.Forms.ComboBox();
            this.gbCaractéristique.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupd)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(563, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre Max de Personne";
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(66, 30);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(197, 26);
            this.tbNom.TabIndex = 2;
            this.tbNom.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // gbCaractéristique
            // 
            this.gbCaractéristique.BackColor = System.Drawing.SystemColors.ControlLight;
            this.gbCaractéristique.Controls.Add(this.label5);
            this.gbCaractéristique.Controls.Add(this.rtbdesc);
            this.gbCaractéristique.Controls.Add(this.cbEtat);
            this.gbCaractéristique.Controls.Add(this.tbAnneRemise);
            this.gbCaractéristique.Controls.Add(this.label8);
            this.gbCaractéristique.Controls.Add(this.rbInternet);
            this.gbCaractéristique.Controls.Add(this.label9);
            this.gbCaractéristique.Controls.Add(this.hsbSurface);
            this.gbCaractéristique.Controls.Add(this.nupd);
            this.gbCaractéristique.Controls.Add(this.label14);
            this.gbCaractéristique.Controls.Add(this.label2);
            this.gbCaractéristique.Controls.Add(this.rbInternetoui);
            this.gbCaractéristique.Controls.Add(this.cborientation);
            this.gbCaractéristique.Controls.Add(this.label15);
            this.gbCaractéristique.Controls.Add(this.label3);
            this.gbCaractéristique.Controls.Add(this.label7);
            this.gbCaractéristique.Controls.Add(this.tbImage);
            this.gbCaractéristique.Controls.Add(this.tbmontant);
            this.gbCaractéristique.Controls.Add(this.btinserer);
            this.gbCaractéristique.Controls.Add(this.label4);
            this.gbCaractéristique.Controls.Add(this.cbtype);
            this.gbCaractéristique.Controls.Add(this.label12);
            this.gbCaractéristique.Controls.Add(this.label10);
            this.gbCaractéristique.Controls.Add(this.tbSecteur);
            this.gbCaractéristique.Controls.Add(this.label6);
            this.gbCaractéristique.Controls.Add(this.label1);
            this.gbCaractéristique.Controls.Add(this.tbNom);
            this.gbCaractéristique.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.gbCaractéristique.Location = new System.Drawing.Point(12, 12);
            this.gbCaractéristique.Name = "gbCaractéristique";
            this.gbCaractéristique.Size = new System.Drawing.Size(872, 322);
            this.gbCaractéristique.TabIndex = 4;
            this.gbCaractéristique.TabStop = false;
            this.gbCaractéristique.Text = "Caractéristique";
            this.gbCaractéristique.Enter += new System.EventHandler(this.gbCaractéristique_Enter);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label15.Location = new System.Drawing.Point(374, 83);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(139, 17);
            this.label15.TabIndex = 11;
            this.label15.Text = "Type d\'hebergement";
            // 
            // cbtype
            // 
            this.cbtype.FormattingEnabled = true;
            this.cbtype.Location = new System.Drawing.Point(377, 111);
            this.cbtype.Name = "cbtype";
            this.cbtype.Size = new System.Drawing.Size(121, 28);
            this.cbtype.TabIndex = 10;
            // 
            // tbSecteur
            // 
            this.tbSecteur.Location = new System.Drawing.Point(66, 74);
            this.tbSecteur.Name = "tbSecteur";
            this.tbSecteur.Size = new System.Drawing.Size(197, 26);
            this.tbSecteur.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label6.Location = new System.Drawing.Point(6, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Secteur";
            // 
            // rtbdesc
            // 
            this.rtbdesc.Location = new System.Drawing.Point(566, 162);
            this.rtbdesc.Name = "rtbdesc";
            this.rtbdesc.Size = new System.Drawing.Size(241, 82);
            this.rtbdesc.TabIndex = 7;
            this.rtbdesc.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label5.Location = new System.Drawing.Point(563, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Description:";
            // 
            // tbAnneRemise
            // 
            this.tbAnneRemise.Location = new System.Drawing.Point(566, 111);
            this.tbAnneRemise.Name = "tbAnneRemise";
            this.tbAnneRemise.Size = new System.Drawing.Size(157, 26);
            this.tbAnneRemise.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label9.Location = new System.Drawing.Point(563, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(149, 17);
            this.label9.TabIndex = 7;
            this.label9.Text = "Annee Remise en Etat";
            // 
            // hsbSurface
            // 
            this.hsbSurface.Location = new System.Drawing.Point(66, 171);
            this.hsbSurface.Name = "hsbSurface";
            this.hsbSurface.Size = new System.Drawing.Size(195, 33);
            this.hsbSurface.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label4.Location = new System.Drawing.Point(4, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Surface";
            // 
            // cborientation
            // 
            this.cborientation.AutoCompleteCustomSource.AddRange(new string[] {
            "Est",
            "Ouest"});
            this.cborientation.FormattingEnabled = true;
            this.cborientation.Items.AddRange(new object[] {
            "Nord",
            "Ouest",
            "Est",
            "Sud"});
            this.cborientation.Location = new System.Drawing.Point(377, 171);
            this.cborientation.Name = "cborientation";
            this.cborientation.Size = new System.Drawing.Size(121, 28);
            this.cborientation.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label7.Location = new System.Drawing.Point(374, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "Orientation";
            // 
            // btvalider
            // 
            this.btvalider.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btvalider.Location = new System.Drawing.Point(375, 323);
            this.btvalider.Name = "btvalider";
            this.btvalider.Size = new System.Drawing.Size(113, 41);
            this.btvalider.TabIndex = 6;
            this.btvalider.Text = "Valider";
            this.btvalider.UseVisualStyleBackColor = true;
            this.btvalider.Click += new System.EventHandler(this.btvalider_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label10.Location = new System.Drawing.Point(0, 242);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 17);
            this.label10.TabIndex = 9;
            this.label10.Text = "Image :";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // btinserer
            // 
            this.btinserer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btinserer.Location = new System.Drawing.Point(166, 237);
            this.btinserer.Name = "btinserer";
            this.btinserer.Size = new System.Drawing.Size(101, 27);
            this.btinserer.TabIndex = 10;
            this.btinserer.Text = "Inserer";
            this.btinserer.UseVisualStyleBackColor = true;
            this.btinserer.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbImage
            // 
            this.tbImage.Enabled = false;
            this.tbImage.Location = new System.Drawing.Point(60, 237);
            this.tbImage.Name = "tbImage";
            this.tbImage.Size = new System.Drawing.Size(100, 26);
            this.tbImage.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label12.Location = new System.Drawing.Point(4, 130);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 17);
            this.label12.TabIndex = 15;
            this.label12.Text = "Montant";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(267, 131);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(18, 20);
            this.label14.TabIndex = 20;
            this.label14.Text = "€";
            // 
            // tbmontant
            // 
            this.tbmontant.Location = new System.Drawing.Point(69, 129);
            this.tbmontant.Name = "tbmontant";
            this.tbmontant.Size = new System.Drawing.Size(192, 26);
            this.tbmontant.TabIndex = 19;
            // 
            // nupd
            // 
            this.nupd.Location = new System.Drawing.Point(566, 52);
            this.nupd.Name = "nupd";
            this.nupd.Size = new System.Drawing.Size(120, 26);
            this.nupd.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.Location = new System.Drawing.Point(374, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Internet";
            // 
            // rbInternetoui
            // 
            this.rbInternetoui.AutoSize = true;
            this.rbInternetoui.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.rbInternetoui.Location = new System.Drawing.Point(377, 237);
            this.rbInternetoui.Name = "rbInternetoui";
            this.rbInternetoui.Size = new System.Drawing.Size(48, 21);
            this.rbInternetoui.TabIndex = 1;
            this.rbInternetoui.TabStop = true;
            this.rbInternetoui.Text = "Oui";
            this.rbInternetoui.UseVisualStyleBackColor = true;
            // 
            // rbInternet
            // 
            this.rbInternet.AutoSize = true;
            this.rbInternet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.rbInternet.Location = new System.Drawing.Point(377, 264);
            this.rbInternet.Name = "rbInternet";
            this.rbInternet.Size = new System.Drawing.Size(52, 21);
            this.rbInternet.TabIndex = 2;
            this.rbInternet.TabStop = true;
            this.rbInternet.Text = "Non";
            this.rbInternet.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label8.Location = new System.Drawing.Point(374, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "Etat :";
            // 
            // cbEtat
            // 
            this.cbEtat.FormattingEnabled = true;
            this.cbEtat.Items.AddRange(new object[] {
            "Neuf",
            "Excellent",
            "Très Bon",
            "Bon",
            "Convenable"});
            this.cbEtat.Location = new System.Drawing.Point(377, 50);
            this.cbEtat.Name = "cbEtat";
            this.cbEtat.Size = new System.Drawing.Size(124, 28);
            this.cbEtat.TabIndex = 7;
            this.cbEtat.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // Creation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 376);
            this.Controls.Add(this.btvalider);
            this.Controls.Add(this.gbCaractéristique);
            this.Name = "Creation";
            this.Text = "Creation";
            this.Load += new System.EventHandler(this.Creation_Load);
            this.gbCaractéristique.ResumeLayout(false);
            this.gbCaractéristique.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.GroupBox gbCaractéristique;
        private System.Windows.Forms.TextBox tbSecteur;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox rtbdesc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.HScrollBar hsbSurface;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cborientation;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btvalider;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbAnneRemise;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btinserer;
        private System.Windows.Forms.TextBox tbImage;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbmontant;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cbtype;
        private System.Windows.Forms.ComboBox cbEtat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rbInternet;
        private System.Windows.Forms.NumericUpDown nupd;
        private System.Windows.Forms.RadioButton rbInternetoui;
        private System.Windows.Forms.Label label3;
    }
}