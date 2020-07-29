namespace RESA
{
    partial class VoirHebergement
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
            this.lbhebergement = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbsecteur = new System.Windows.Forms.TextBox();
            this.btvalider = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbtype = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btinfo = new System.Windows.Forms.Button();
            this.pbphoto = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btmodifier = new System.Windows.Forms.Button();
            this.gbmodifier = new System.Windows.Forms.GroupBox();
            this.label26 = new System.Windows.Forms.Label();
            this.rtbcommentairemodif = new System.Windows.Forms.RichTextBox();
            this.btvalidermodif = new System.Windows.Forms.Button();
            this.tborientationmodif = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.tbinternetmodif = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.tbsurfacemodif = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.tbnbmaxmodif = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.tbanneemodif = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tbtypemodif = new System.Windows.Forms.TextBox();
            this.tbsecteurmodif = new System.Windows.Forms.TextBox();
            this.tbmontantmodif = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.rtbdescription = new System.Windows.Forms.RichTextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbphoto)).BeginInit();
            this.gbmodifier.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbhebergement
            // 
            this.lbhebergement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lbhebergement.FormattingEnabled = true;
            this.lbhebergement.ItemHeight = 17;
            this.lbhebergement.Location = new System.Drawing.Point(543, 13);
            this.lbhebergement.Name = "lbhebergement";
            this.lbhebergement.Size = new System.Drawing.Size(130, 531);
            this.lbhebergement.TabIndex = 0;
            this.lbhebergement.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbsecteur);
            this.groupBox1.Controls.Add(this.btvalider);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbtype);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.groupBox1.Location = new System.Drawing.Point(26, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(436, 122);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Critières";
            // 
            // tbsecteur
            // 
            this.tbsecteur.Location = new System.Drawing.Point(76, 33);
            this.tbsecteur.Name = "tbsecteur";
            this.tbsecteur.Size = new System.Drawing.Size(100, 23);
            this.tbsecteur.TabIndex = 23;
            // 
            // btvalider
            // 
            this.btvalider.Location = new System.Drawing.Point(141, 93);
            this.btvalider.Name = "btvalider";
            this.btvalider.Size = new System.Drawing.Size(75, 23);
            this.btvalider.TabIndex = 22;
            this.btvalider.Text = "Valider";
            this.btvalider.UseVisualStyleBackColor = true;
            this.btvalider.Click += new System.EventHandler(this.btvalider_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Secteur";
            // 
            // cbtype
            // 
            this.cbtype.FormattingEnabled = true;
            this.cbtype.Items.AddRange(new object[] {
            "châlet",
            "bungalow",
            "appartement",
            "autres",
            "mobil home"});
            this.cbtype.Location = new System.Drawing.Point(252, 41);
            this.cbtype.Name = "cbtype";
            this.cbtype.Size = new System.Drawing.Size(121, 25);
            this.cbtype.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(249, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Type d\'hebergement";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 0;
            // 
            // btinfo
            // 
            this.btinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btinfo.Location = new System.Drawing.Point(679, 12);
            this.btinfo.Name = "btinfo";
            this.btinfo.Size = new System.Drawing.Size(107, 57);
            this.btinfo.TabIndex = 2;
            this.btinfo.Text = "Info";
            this.btinfo.UseVisualStyleBackColor = true;
            this.btinfo.Visible = false;
            this.btinfo.Click += new System.EventHandler(this.btinfo_Click);
            // 
            // pbphoto
            // 
            this.pbphoto.Location = new System.Drawing.Point(804, 22);
            this.pbphoto.Name = "pbphoto";
            this.pbphoto.Size = new System.Drawing.Size(287, 139);
            this.pbphoto.TabIndex = 19;
            this.pbphoto.TabStop = false;
            this.pbphoto.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label4.Location = new System.Drawing.Point(804, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Montant";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label5.Location = new System.Drawing.Point(974, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "label5";
            this.label5.Visible = false;
            // 
            // btmodifier
            // 
            this.btmodifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btmodifier.Location = new System.Drawing.Point(679, 75);
            this.btmodifier.Name = "btmodifier";
            this.btmodifier.Size = new System.Drawing.Size(107, 70);
            this.btmodifier.TabIndex = 22;
            this.btmodifier.Text = "Modifier Hebergement";
            this.btmodifier.UseVisualStyleBackColor = true;
            this.btmodifier.Visible = false;
            this.btmodifier.Click += new System.EventHandler(this.button1_Click);
            // 
            // gbmodifier
            // 
            this.gbmodifier.Controls.Add(this.label26);
            this.gbmodifier.Controls.Add(this.rtbcommentairemodif);
            this.gbmodifier.Controls.Add(this.btvalidermodif);
            this.gbmodifier.Controls.Add(this.tborientationmodif);
            this.gbmodifier.Controls.Add(this.label22);
            this.gbmodifier.Controls.Add(this.tbinternetmodif);
            this.gbmodifier.Controls.Add(this.label20);
            this.gbmodifier.Controls.Add(this.tbsurfacemodif);
            this.gbmodifier.Controls.Add(this.label18);
            this.gbmodifier.Controls.Add(this.tbnbmaxmodif);
            this.gbmodifier.Controls.Add(this.label17);
            this.gbmodifier.Controls.Add(this.tbanneemodif);
            this.gbmodifier.Controls.Add(this.label16);
            this.gbmodifier.Controls.Add(this.tbtypemodif);
            this.gbmodifier.Controls.Add(this.tbsecteurmodif);
            this.gbmodifier.Controls.Add(this.tbmontantmodif);
            this.gbmodifier.Controls.Add(this.label15);
            this.gbmodifier.Controls.Add(this.label14);
            this.gbmodifier.Controls.Add(this.label6);
            this.gbmodifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.gbmodifier.Location = new System.Drawing.Point(26, 153);
            this.gbmodifier.Name = "gbmodifier";
            this.gbmodifier.Size = new System.Drawing.Size(459, 456);
            this.gbmodifier.TabIndex = 23;
            this.gbmodifier.TabStop = false;
            this.gbmodifier.Text = "Modifier";
            this.gbmodifier.Visible = false;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(6, 307);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(87, 17);
            this.label26.TabIndex = 44;
            this.label26.Text = "Description :";
            this.label26.Visible = false;
            // 
            // rtbcommentairemodif
            // 
            this.rtbcommentairemodif.Location = new System.Drawing.Point(91, 304);
            this.rtbcommentairemodif.Name = "rtbcommentairemodif";
            this.rtbcommentairemodif.Size = new System.Drawing.Size(368, 112);
            this.rtbcommentairemodif.TabIndex = 43;
            this.rtbcommentairemodif.Text = "";
            this.rtbcommentairemodif.Visible = false;
            // 
            // btvalidermodif
            // 
            this.btvalidermodif.Location = new System.Drawing.Point(178, 427);
            this.btvalidermodif.Name = "btvalidermodif";
            this.btvalidermodif.Size = new System.Drawing.Size(75, 23);
            this.btvalidermodif.TabIndex = 42;
            this.btvalidermodif.Text = "Valider";
            this.btvalidermodif.UseVisualStyleBackColor = true;
            this.btvalidermodif.Visible = false;
            this.btvalidermodif.Click += new System.EventHandler(this.btvalidermodif_Click);
            // 
            // tborientationmodif
            // 
            this.tborientationmodif.Location = new System.Drawing.Point(189, 269);
            this.tborientationmodif.Name = "tborientationmodif";
            this.tborientationmodif.Size = new System.Drawing.Size(100, 23);
            this.tborientationmodif.TabIndex = 41;
            this.tborientationmodif.Visible = false;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label22.Location = new System.Drawing.Point(8, 263);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(78, 17);
            this.label22.TabIndex = 40;
            this.label22.Text = "Orientation";
            this.label22.Visible = false;
            // 
            // tbinternetmodif
            // 
            this.tbinternetmodif.Location = new System.Drawing.Point(189, 236);
            this.tbinternetmodif.Name = "tbinternetmodif";
            this.tbinternetmodif.Size = new System.Drawing.Size(100, 23);
            this.tbinternetmodif.TabIndex = 37;
            this.tbinternetmodif.Visible = false;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label20.Location = new System.Drawing.Point(8, 236);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(56, 17);
            this.label20.TabIndex = 36;
            this.label20.Text = "Internet";
            this.label20.Visible = false;
            // 
            // tbsurfacemodif
            // 
            this.tbsurfacemodif.Location = new System.Drawing.Point(189, 203);
            this.tbsurfacemodif.Name = "tbsurfacemodif";
            this.tbsurfacemodif.Size = new System.Drawing.Size(100, 23);
            this.tbsurfacemodif.TabIndex = 35;
            this.tbsurfacemodif.Visible = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label18.Location = new System.Drawing.Point(6, 203);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(57, 17);
            this.label18.TabIndex = 34;
            this.label18.Text = "Surface";
            this.label18.Visible = false;
            // 
            // tbnbmaxmodif
            // 
            this.tbnbmaxmodif.Location = new System.Drawing.Point(189, 170);
            this.tbnbmaxmodif.Name = "tbnbmaxmodif";
            this.tbnbmaxmodif.Size = new System.Drawing.Size(100, 23);
            this.tbnbmaxmodif.TabIndex = 33;
            this.tbnbmaxmodif.Visible = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label17.Location = new System.Drawing.Point(6, 170);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(172, 17);
            this.label17.TabIndex = 32;
            this.label17.Text = "Nombre Max de Personne";
            this.label17.Visible = false;
            // 
            // tbanneemodif
            // 
            this.tbanneemodif.Location = new System.Drawing.Point(189, 134);
            this.tbanneemodif.Name = "tbanneemodif";
            this.tbanneemodif.Size = new System.Drawing.Size(100, 23);
            this.tbanneemodif.TabIndex = 31;
            this.tbanneemodif.Visible = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label16.Location = new System.Drawing.Point(6, 137);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(149, 17);
            this.label16.TabIndex = 30;
            this.label16.Text = "Annee Remise en Etat";
            this.label16.Visible = false;
            // 
            // tbtypemodif
            // 
            this.tbtypemodif.Location = new System.Drawing.Point(189, 104);
            this.tbtypemodif.Name = "tbtypemodif";
            this.tbtypemodif.Size = new System.Drawing.Size(100, 23);
            this.tbtypemodif.TabIndex = 29;
            this.tbtypemodif.Visible = false;
            // 
            // tbsecteurmodif
            // 
            this.tbsecteurmodif.Location = new System.Drawing.Point(189, 69);
            this.tbsecteurmodif.Name = "tbsecteurmodif";
            this.tbsecteurmodif.Size = new System.Drawing.Size(100, 23);
            this.tbsecteurmodif.TabIndex = 28;
            this.tbsecteurmodif.Visible = false;
            // 
            // tbmontantmodif
            // 
            this.tbmontantmodif.Location = new System.Drawing.Point(189, 34);
            this.tbmontantmodif.Name = "tbmontantmodif";
            this.tbmontantmodif.Size = new System.Drawing.Size(100, 23);
            this.tbmontantmodif.TabIndex = 27;
            this.tbmontantmodif.Visible = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label15.Location = new System.Drawing.Point(6, 104);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(139, 17);
            this.label15.TabIndex = 26;
            this.label15.Text = "Type d\'hebergement";
            this.label15.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label14.Location = new System.Drawing.Point(7, 69);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 17);
            this.label14.TabIndex = 25;
            this.label14.Text = "Secteur";
            this.label14.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "Montant";
            this.label6.Visible = false;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label19.Location = new System.Drawing.Point(804, 220);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(57, 17);
            this.label19.TabIndex = 24;
            this.label19.Text = "Secteur";
            this.label19.Visible = false;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label21.Location = new System.Drawing.Point(801, 254);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(139, 17);
            this.label21.TabIndex = 25;
            this.label21.Text = "Type d\'hebergement";
            this.label21.Visible = false;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label23.Location = new System.Drawing.Point(801, 289);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(149, 17);
            this.label23.TabIndex = 26;
            this.label23.Text = "Annee Remise en Etat";
            this.label23.Visible = false;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label25.Location = new System.Drawing.Point(801, 320);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(172, 17);
            this.label25.TabIndex = 28;
            this.label25.Text = "Nombre Max de Personne";
            this.label25.Visible = false;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label27.Location = new System.Drawing.Point(1082, 192);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(57, 17);
            this.label27.TabIndex = 30;
            this.label27.Text = "Surface";
            this.label27.Visible = false;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label31.Location = new System.Drawing.Point(1083, 220);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(56, 17);
            this.label31.TabIndex = 34;
            this.label31.Text = "Internet";
            this.label31.Visible = false;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label34.Location = new System.Drawing.Point(1082, 251);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(78, 17);
            this.label34.TabIndex = 39;
            this.label34.Text = "Orientation";
            this.label34.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label7.Location = new System.Drawing.Point(974, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 17);
            this.label7.TabIndex = 40;
            this.label7.Text = "label7";
            this.label7.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label8.Location = new System.Drawing.Point(1172, 196);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 17);
            this.label8.TabIndex = 41;
            this.label8.Text = "label8";
            this.label8.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label9.Location = new System.Drawing.Point(1175, 223);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 17);
            this.label9.TabIndex = 42;
            this.label9.Text = "label9";
            this.label9.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1175, 254);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 43;
            this.label10.Text = "label10";
            this.label10.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label11.Location = new System.Drawing.Point(977, 253);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 17);
            this.label11.TabIndex = 44;
            this.label11.Text = "label11";
            this.label11.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label12.Location = new System.Drawing.Point(977, 289);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 17);
            this.label12.TabIndex = 45;
            this.label12.Text = "label12";
            this.label12.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label13.Location = new System.Drawing.Point(979, 324);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 17);
            this.label13.TabIndex = 46;
            this.label13.Text = "label13";
            this.label13.Visible = false;
            // 
            // rtbdescription
            // 
            this.rtbdescription.Location = new System.Drawing.Point(807, 390);
            this.rtbdescription.Name = "rtbdescription";
            this.rtbdescription.Size = new System.Drawing.Size(375, 110);
            this.rtbdescription.TabIndex = 47;
            this.rtbdescription.Text = "";
            this.rtbdescription.Visible = false;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label24.Location = new System.Drawing.Point(804, 361);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(79, 17);
            this.label24.TabIndex = 48;
            this.label24.Text = "Description";
            this.label24.Visible = false;
            // 
            // VoirHebergement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 610);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.rtbdescription);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.gbmodifier);
            this.Controls.Add(this.btmodifier);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pbphoto);
            this.Controls.Add(this.btinfo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbhebergement);
            this.Name = "VoirHebergement";
            this.Text = "VoirHebergement";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbphoto)).EndInit();
            this.gbmodifier.ResumeLayout(false);
            this.gbmodifier.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbhebergement;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbsecteur;
        private System.Windows.Forms.Button btvalider;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbtype;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btinfo;
        private System.Windows.Forms.PictureBox pbphoto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btmodifier;
        private System.Windows.Forms.GroupBox gbmodifier;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Button btvalidermodif;
        private System.Windows.Forms.TextBox tborientationmodif;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox tbinternetmodif;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox tbsurfacemodif;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tbnbmaxmodif;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tbanneemodif;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbtypemodif;
        private System.Windows.Forms.TextBox tbsecteurmodif;
        private System.Windows.Forms.TextBox tbmontantmodif;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RichTextBox rtbdescription;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.RichTextBox rtbcommentairemodif;
    }
}