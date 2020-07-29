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
    public partial class Accueil : Form
    {
        private Compte compte;

        public Accueil()
        {
            InitializeComponent();
        }
    
        public void ModifierApresConnexion(Compte Compte1)
        {
            if(Compte1 != null)
            {
                compte = Compte1;
                btConnexion.Visible = false;
                label2.Visible = true;
                label2.Text = "Bonjour " + Compte1.GetNom();
                if(Compte1.GetTypeCompte()=="G" || Compte1.GetTypeCompte()=="A")
                {
                    btCreer.Visible = true;
                    btvoirheberg.Visible = true;
                    btListeSemaine.Visible = true;
                    gbAdmin.Visible = true;
                }
                if(Compte1.GetTypeCompte()=="A")
                {
                    btlisteUtilisateur.Visible = true;
                }
            }
        }

        private void btConnexion_Click(object sender, EventArgs e)
        {
            ConnexionUtilisateur Resa1  = new ConnexionUtilisateur(this);
            Resa1.Show();
            
        }

        private void btConsulter_Click(object sender, EventArgs e)
        {
            if (compte == null)
            {
                Consulter consulter1 = new Consulter();
                consulter1.Show();
            }
            else
            {
                Consulter consulter1 = new Consulter(compte);
                consulter1.Show();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btCreer_Click(object sender, EventArgs e)
        {
            Creation Creation1 = new Creation();
            Creation1.Show();
        }

        private void Accueil_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            VoirHebergement Voir1 = new VoirHebergement();
            Voir1.Show();
        }

        private void btListeSemaine_Click(object sender, EventArgs e)
        {
            VoirListerSemaine VoirSemaine = new VoirListerSemaine();
            VoirSemaine.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            VoirListeUtilisateur voirUtilisateur = new VoirListeUtilisateur();
            voirUtilisateur.Show();
        }
    }
}
