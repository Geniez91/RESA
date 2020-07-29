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
    public partial class ConnexionUtilisateur : Form
    {
        Connexion Connexion1 = new Connexion();
        Accueil Accueil1 = new Accueil();

        public ConnexionUtilisateur(Accueil acceuil)
        {
            InitializeComponent();

            Accueil1 = acceuil;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Connexion1.SeConnecter();
            if(Connexion1.ConnexionUtilisateur(rtblogin.Text,rtbMdp.Text)==true)
            {
                MessageBox.Show("Vous etes Connecté");
                
                Compte Compte1 = (Compte) Connexion1.Utilisateur(rtblogin.Text,rtbMdp.Text);          

                Accueil1.ModifierApresConnexion(Compte1);
                
               this.Close();

            }
            else
            {
                MessageBox.Show("Mot de passe ou Login Incorrect");
            }

         

        }
    }
}
