using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RESA
{
    
    public partial class VoirHebergement : Form
    {
        Connexion Connexion1 = new Connexion();
        public VoirHebergement()
        {
            InitializeComponent();
        }

        private void btvalider_Click(object sender, EventArgs e)
        {
            lbhebergement.Visible = true;
            btinfo.Visible = true;
            if (lbhebergement.Items != null)
            {
                lbhebergement.Items.Clear();
            }
            string secteur;
            string type;
            string code_type;
            if(tbsecteur.Text!=""&& cbtype.Text!="")
            {
                secteur = tbsecteur.Text;
                type = cbtype.Text;
                code_type= Connexion1.SelectionCodeType(type);
                Connexion1.RechercheFiltretypesecteur(code_type, secteur);
                int i = 0;
                foreach (Hebergement elements in Connexion1.RechercheFiltretypesecteur(code_type,secteur))
                {
                    lbhebergement.Items.Add(Connexion1.RechercheFiltretypesecteur(code_type,secteur)[i]);
                }

            }
        }

        private void btinfo_Click(object sender, EventArgs e)
        {
            btmodifier.Visible = true;
            pbphoto.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label19.Visible = true;
            label7.Visible = true;
            label21.Visible = true;
            label11.Visible = true;
            label23.Visible = true;
            label12.Visible = true;
            label25.Visible = true;
            label13.Visible = true;
            label24.Visible = true;
            rtbdescription.Visible = true;
            label27.Visible = true;
            label8.Visible = true;
            label31.Visible = true;
            label9.Visible = true;
            label34.Visible = true;
            label10.Visible = true;
            Hebergement hebergement = (Hebergement)lbhebergement.SelectedItem;
            if (lbhebergement.SelectedItem != null)
            {
                label5.Text = hebergement.GetMontant().ToString();
                label7.Text = hebergement.GetSecteur();
                label11.Text = hebergement.GetTypeH();
                label12.Text = hebergement.GetAnnneRemise().ToString();
                label13.Text = hebergement.GetNBMAX().ToString();
                label8.Text = hebergement.GetSurface().ToString();
                label9.Text = hebergement.GetInternet().ToString();
                label10.Text = hebergement.GetOrientation();
                rtbdescription.Text = hebergement.GetDescription();
                pbphoto.ImageLocation = hebergement.GetPhoto();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gbmodifier.Visible = true;
            label6.Visible = true;
            tbmontantmodif.Visible = true;
            label14.Visible = true;
            tbsecteurmodif.Visible = true;
            label15.Visible = true;
            tbtypemodif.Visible = true;
            label16.Visible = true;
            tbanneemodif.Visible = true;
            label17.Visible = true;
            tbnbmaxmodif.Visible = true;
            label18.Visible = true;
            tbsurfacemodif.Visible = true;
            label20.Visible = true;
            tbinternetmodif.Visible = true;
            label22.Visible = true;
            tborientationmodif.Visible = true;
            label26.Visible = true;
            rtbcommentairemodif.Visible = true;
            btvalidermodif.Visible = true;

            Hebergement hebergement = (Hebergement)lbhebergement.SelectedItem;

            if (lbhebergement.SelectedItem != null)
            {
                tbmontantmodif.Text = label5.Text;
                tbsecteurmodif.Text = label7.Text;
                tbtypemodif.Text = label11.Text;
                tbanneemodif.Text = label12.Text;
                tbnbmaxmodif.Text = label13.Text;
                tbsurfacemodif.Text = label8.Text;
                tbinternetmodif.Text = label9.Text;
                tborientationmodif.Text = label10.Text;
                rtbcommentairemodif.Text = rtbdescription.Text;

        }
        }

        private void btvalidermodif_Click(object sender, EventArgs e)
        {
            Hebergement hebergement = (Hebergement)lbhebergement.SelectedItem;
            if (lbhebergement.SelectedItem != null)
            {
                string montant = tbmontantmodif.Text;
                string secteur = tbsecteurmodif.Text;
                string type = tbtypemodif.Text;
                string annee = tbanneemodif.Text;
                string nbmax = tbanneemodif.Text;
                string surface = tbsurfacemodif.Text;
                bool internet = Convert.ToBoolean(tbinternetmodif.Text);
                string orientation = tborientationmodif.Text;
                string commentaire = rtbcommentairemodif.Text;
                string nom = hebergement.GetNom();
                Connexion1.ModifierHebergement(nom, nbmax, surface, internet, annee, secteur, orientation, commentaire,type, montant);
                MessageBox.Show("Modification Effectué");
            }
        }
    }
}
