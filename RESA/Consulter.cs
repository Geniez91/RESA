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
    public partial class Consulter : Form
    {
        Connexion Connexion1 = new Connexion();
        public Consulter()
        {
            InitializeComponent();
            label8.Text = hsbprix.Value.ToString();
            label11.Text = hsbnbplace.Value.ToString();
            label15.Text = hsbsurface.Value.ToString();

            btReserver.Visible = false;
        }
        public Consulter(Compte Compte1)
        {
            InitializeComponent();
            label8.Text = hsbprix.Value.ToString();
            label11.Text = hsbnbplace.Value.ToString();
            label15.Text = hsbsurface.Value.ToString();            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btvalider_Click(object sender, EventArgs e)
        {
            lbheberg.Visible = true;
            btinfo.Visible = true;
            if (lbheberg.Items != null)
            {
                lbheberg.Items.Clear();
            }
            int prixmaximun = 0;
            int nbsurface = 0;
            string secteur = "";
            int nbplace = 0;
            bool internet = true;
            string type = "";
            //type hebergement
            if (cbtype.Text == "appartement")
            {
                type = cbtype.Text;
            }
            if (cbtype.Text == "Autres")
            {
                type = cbtype.Text;
            }
            if (cbtype.Text == "bungalow")
            {
                type = cbtype.Text;
            }
            if (cbtype.Text == "mobil home")
            {
                type = cbtype.Text;
            }
            if (cbtype.Text == "châlet")
            {
                type = cbtype.Text;
            }

            string cod_type = Connexion1.SelectionCodeType(type);
            ///verification que l'utilisateur a bien saisie///
            ///Recherche avec tous les filtres
            if (hsbprix.Value != 0 && hsbsurface.Value != 0 && hsbnbplace.Value != 0 && tbsecteur.Text != "" && rbInternet.Checked)
            {
                prixmaximun = hsbprix.Value;
                nbsurface = hsbsurface.Value;
                nbplace = hsbnbplace.Value;
                secteur = tbsecteur.Text;
                internet = rbInternet.Checked;
                MessageBox.Show("Tous les filtres");
                int i = 0;
                foreach (Hebergement elements in Connexion1.RechercheTousLesFiltre(cod_type, nbplace, nbsurface, secteur, internet, prixmaximun))
                {
                    lbheberg.Items.Add(Connexion1.RechercheTousLesFiltre(cod_type, nbplace, nbsurface, secteur, internet, prixmaximun)[i]);
                }

            }
            ////Recherche avec filtre prix////
            if (hsbprix.Value != 0 && hsbsurface.Value == 0 && hsbnbplace.Value == 0 && tbsecteur.Text == "" && rbInternet.Checked == false)
            {
                prixmaximun = hsbprix.Value;
                int i = 0;
                MessageBox.Show("filtre prix");
                foreach (Hebergement elements in Connexion1.RechercheFiltrePrix(prixmaximun))
                {
                    lbheberg.Items.Add(Connexion1.RechercheFiltrePrix(prixmaximun)[i]);

                    //     label18.Text = Connexion1.RechercheFiltrePrix(prixmaximun)[i].GetMontant().ToString();
                    i = i + 1;

                }



            }
            ///Recherche avec filtre prix+surface
            if (hsbprix.Value != 0 && hsbsurface.Value != 0 && hsbnbplace.Value == 0 && tbsecteur.Text == "")
            {
                prixmaximun = hsbprix.Value;
                nbsurface = hsbsurface.Value;
                int i = 0;
                MessageBox.Show("filtre prix+surface");
                foreach (Hebergement elements in Connexion1.RechercheFiltrePrixetsurface(prixmaximun, nbsurface))
                {
                    lbheberg.Items.Add(Connexion1.RechercheFiltrePrixetsurface(prixmaximun, nbsurface)[i]);
                    i = i + 1;
                }
            }

            ////Recherche avec filtre prix+surface+nbplace
            if (hsbprix.Value != 0 && hsbsurface.Value != 0 && hsbnbplace.Value != 0 && tbsecteur.Text == "")
            {
                prixmaximun = hsbprix.Value;
                nbsurface = hsbsurface.Value;
                nbplace = hsbnbplace.Value;
                MessageBox.Show("filtre prix+surface+nbplace");
                int i = 0;
                foreach (Hebergement elements in Connexion1.RechercheFiltrePrixsurfacenbplace(prixmaximun, nbsurface, nbplace))
                {
                    lbheberg.Items.Add(Connexion1.RechercheFiltrePrixsurfacenbplace(prixmaximun, nbsurface, nbplace)[i]);
                    i = i + 1;
                }
            }
            ///Recherche filtre prix+surface+nbplace+secteur////
            if (hsbprix.Value != 0 && hsbsurface.Value != 0 && hsbnbplace.Value != 0 && tbsecteur.Text != "" && rbInternet.Checked == false)
            {
                prixmaximun = hsbprix.Value;
                nbsurface = hsbsurface.Value;
                nbplace = hsbnbplace.Value;
                secteur = tbsecteur.Text;
                MessageBox.Show("filtre prix+surface+nbplace+secteur");
                int i = 0;
                foreach (Hebergement elements in Connexion1.RechercheFiltrePrixsurfacenbplacesecteur(prixmaximun, nbsurface, nbplace, secteur))
                {
                    lbheberg.Items.Add(Connexion1.RechercheFiltrePrixsurfacenbplacesecteur(prixmaximun, nbsurface, nbplace, secteur)[i]);
                    i = i + 1;
                }


            }
            ///recherche filtre surface
            if (hsbprix.Value == 0 && hsbsurface.Value != 0 && hsbnbplace.Value == 0 && tbsecteur.Text == "" && rbInternet.Checked == false)
            {
                nbsurface = hsbsurface.Value;
                int i = 0;
                MessageBox.Show(" filtre surface");
                foreach (Hebergement elements in Connexion1.RechercheFiltresurface(nbsurface))
                {
                    lbheberg.Items.Add(Connexion1.RechercheFiltresurface(nbsurface)[i]);
                    i = i + 1;
                }
            }
            ///recherche filtre surface+nbplace
            if (hsbprix.Value == 0 && hsbsurface.Value != 0 && hsbnbplace.Value != 0 && tbsecteur.Text == "" && rbInternet.Checked == false)
            {
                nbsurface = hsbsurface.Value;
                nbplace = hsbnbplace.Value;
                int i = 0;
                MessageBox.Show("surface+nbplace");
                foreach (Hebergement elements in Connexion1.RechercheFiltresurfacenbplace(nbsurface, nbplace))
                {
                    lbheberg.Items.Add(Connexion1.RechercheFiltresurfacenbplace(nbsurface, nbplace)[i]);
                    i = i + 1;
                }

            }
            //recherche filtre surface+nbplace+secteur//

            if (hsbprix.Value == 0 && hsbsurface.Value != 0 && hsbnbplace.Value != 0 && tbsecteur.Text != "" && rbInternet.Checked == false)
            {
                nbsurface = hsbsurface.Value;
                nbplace = hsbnbplace.Value;
                secteur = tbsecteur.Text;
                int i = 0;
                MessageBox.Show("surface+nbplace+secteur");
                foreach (Hebergement elements in Connexion1.RechercheFiltresurfacenbplacesecteur(nbsurface, nbplace, secteur))
                {
                    lbheberg.Items.Add(Connexion1.RechercheFiltresurfacenbplacesecteur(nbsurface, nbplace, secteur)[i]);
                    i = i + 1;
                }
            }
            //recherche filtre surface+nbplace+secteur+internet//
            if (hsbprix.Value == 0 && hsbsurface.Value != 0 && hsbnbplace.Value != 0 && tbsecteur.Text != "" && rbInternet.Checked)
            {
                nbsurface = hsbsurface.Value;
                nbplace = hsbnbplace.Value;
                secteur = tbsecteur.Text;
                internet = rbInternet.Checked;
                MessageBox.Show("filtre surface+nbplace+secteur+internet");
                int i = 0;
                foreach (Hebergement elements in Connexion1.RechercheFiltresurfacenbplacesecteurinternet(nbsurface, nbplace, secteur, internet))
                {
                    lbheberg.Items.Add(Connexion1.RechercheFiltresurfacenbplacesecteurinternet(nbsurface, nbplace, secteur, internet)[i]);
                    i = i + 1;
                }
            }
            //recherche filtre nbplace//
            if (hsbprix.Value == 0 && hsbsurface.Value == 0 && hsbnbplace.Value != 0 && tbsecteur.Text == "" && rbInternet.Checked == false)
            {
                nbplace = hsbnbplace.Value;
                int i = 0;
                MessageBox.Show("Filtre nbplace");
                foreach (Hebergement elements in Connexion1.RechercheFiltrenbplace(nbplace))
                {
                    lbheberg.Items.Add(Connexion1.RechercheFiltrenbplace(nbplace)[i]);
                    i = i + 1;
                }
            }
            //recherche filtre nbplace+secteur//
            if (hsbprix.Value == 0 && hsbsurface.Value == 0 && hsbnbplace.Value != 0 && tbsecteur.Text != "" && rbInternet.Checked == false)
            {
                nbplace = hsbnbplace.Value;
                secteur = tbsecteur.Text;
                int i = 0;
                MessageBox.Show("Filtre nbplace+secteur");
                foreach (Hebergement elements in Connexion1.RechercheFiltrenbplacesecteur(nbplace, secteur))
                {
                    lbheberg.Items.Add(Connexion1.RechercheFiltrenbplacesecteur(nbplace, secteur)[i]);
                    i = i + 1;
                }
            }
            //recherche filtre nbplace+secteur+internet//
            if (hsbprix.Value == 0 && hsbsurface.Value == 0 && hsbnbplace.Value != 0 && tbsecteur.Text != "" && rbInternet.Checked == true)
            {
                nbplace = hsbnbplace.Value;
                secteur = tbsecteur.Text;
                internet = rbInternet.Checked;
                MessageBox.Show("Filtre nbplace+secteur+internet");
                int i = 0;
                foreach (Hebergement elements in Connexion1.RechercheFiltrenbplacesecteurinternet(nbplace, secteur, internet))
                {
                    lbheberg.Items.Add(Connexion1.RechercheFiltrenbplacesecteurinternet(nbplace, secteur, internet)[i]);
                    i = i + 1;
                }
            }
            //recherche flitre prix+nbplace//
            if (hsbprix.Value != 0 && hsbsurface.Value == 0 && hsbnbplace.Value != 0 && tbsecteur.Text == "" && rbInternet.Checked == false)
            {
                nbplace = hsbnbplace.Value;
                prixmaximun = hsbprix.Value;
                MessageBox.Show("Filtre nbplace+prix");
                int i = 0;
                foreach (Hebergement elements in Connexion1.RechercheFiltrenbplaceprix(prixmaximun, nbplace))
                {
                    lbheberg.Items.Add(Connexion1.RechercheFiltrenbplaceprix(prixmaximun, nbplace)[i]);
                    i = i + 1;
                }
            }
            //recherche flitre secteur//
            if (hsbprix.Value == 0 && hsbsurface.Value == 0 && hsbnbplace.Value == 0 && tbsecteur.Text != "" && rbInternet.Checked == false)
            {
                secteur = tbsecteur.Text;
                MessageBox.Show("Filtre secteur");
                int i = 0;
                foreach (Hebergement elements in Connexion1.RechercheFiltresecteur(secteur))
                {
                    lbheberg.Items.Add(Connexion1.RechercheFiltresecteur(secteur)[i]);
                    i = i + 1;
                }
            }
            //recherche flitre secteur+prix//
            if (hsbprix.Value != 0 && hsbsurface.Value == 0 && hsbnbplace.Value == 0 && tbsecteur.Text != "" && rbInternet.Checked == false)
            {
                secteur = tbsecteur.Text;
                prixmaximun = hsbprix.Value;
                MessageBox.Show("Filtre secteur+prix");
                int i = 0;
                foreach (Hebergement elements in Connexion1.RechercheFiltresecteurprix(secteur, prixmaximun))
                {
                    lbheberg.Items.Add(Connexion1.RechercheFiltresecteurprix(secteur, prixmaximun)[i]);
                    i = i + 1;
                }
            }
            //recherche flitre secteur+surface//
            if (hsbprix.Value == 0 && hsbsurface.Value != 0 && hsbnbplace.Value == 0 && tbsecteur.Text != "" && rbInternet.Checked == false)
            {
                secteur = tbsecteur.Text;
                nbsurface = hsbsurface.Value;
                MessageBox.Show("Filtre secteur+surface");
                int i = 0;
                foreach (Hebergement elements in Connexion1.RechercheFiltresecteursurface(secteur, nbsurface))
                {
                    lbheberg.Items.Add(Connexion1.RechercheFiltresecteursurface(secteur, nbsurface)[i]);
                    i = i + 1;
                }
            }
            //recherche flitre secteur+internet//
            if (hsbprix.Value == 0 && hsbsurface.Value == 0 && hsbnbplace.Value == 0 && tbsecteur.Text != "" && rbInternet.Checked == true)
            {
                secteur = tbsecteur.Text;
                internet = rbInternet.Checked;
                MessageBox.Show("Filtre secteur+internet");
                int i = 0;
                foreach (Hebergement elements in Connexion1.RechercheFiltresecteurinternet(secteur, internet))
                {
                    lbheberg.Items.Add(Connexion1.RechercheFiltresecteurinternet(secteur, internet)[i]);
                    i = i + 1;
                }
            }
            //recherche flitre internet//
            if (hsbprix.Value == 0 && hsbsurface.Value == 0 && hsbnbplace.Value == 0 && tbsecteur.Text == "" && rbInternet.Checked == true)
            {
                internet = rbInternet.Checked;
                MessageBox.Show("Filtre internet");
                int i = 0;
                foreach (Hebergement elements in Connexion1.RechercheFiltreinternet(internet))
                {
                    lbheberg.Items.Add(Connexion1.RechercheFiltreinternet(internet)[i]);
                    i = i + 1;
                }
            }
            //recherche flitre internet+surface//
            if (hsbprix.Value == 0 && hsbsurface.Value != 0 && hsbnbplace.Value == 0 && tbsecteur.Text == "" && rbInternet.Checked == true)
            {
                internet = rbInternet.Checked;
                nbsurface = hsbsurface.Value;
                MessageBox.Show("Filtre internet+surface");
                int i = 0;
                foreach (Hebergement elements in Connexion1.RechercheFiltreinternetsurface(internet, nbsurface))
                {
                    lbheberg.Items.Add(Connexion1.RechercheFiltreinternetsurface(internet, nbsurface)[i]);
                    i = i + 1;
                }
            }
            //recherche flitre internet+nbplace//
            if (hsbprix.Value == 0 && hsbsurface.Value == 0 && hsbnbplace.Value != 0 && tbsecteur.Text == "" && rbInternet.Checked == true)
            {
                internet = rbInternet.Checked;
                nbplace = hsbnbplace.Value;
                MessageBox.Show("Filtre internet+nbplace");
                int i = 0;
                foreach (Hebergement elements in Connexion1.RechercheFiltreinternetnbplace(internet, nbplace))
                {
                    lbheberg.Items.Add(Connexion1.RechercheFiltreinternetnbplace(internet, nbplace)[i]);
                    i = i + 1;
                }
            }
            //recherche flitre internet+prixmaximun//
            if (hsbprix.Value != 0 && hsbsurface.Value == 0 && hsbnbplace.Value == 0 && tbsecteur.Text == "" && rbInternet.Checked == true)
            {
                internet = rbInternet.Checked;
                prixmaximun = hsbprix.Value;
                MessageBox.Show("Filtre internet+prix");
                int i = 0;
                foreach (Hebergement elements in Connexion1.RechercheFiltreinternetprix(internet, prixmaximun))
                {
                    lbheberg.Items.Add(Connexion1.RechercheFiltreinternetprix(internet, prixmaximun)[i]);
                    i = i + 1;
                }
            }
            //recherche flitre internet+prixmaximun+nbplace//
            if (hsbprix.Value != 0 && hsbsurface.Value == 0 && hsbnbplace.Value != 0 && tbsecteur.Text == "" && rbInternet.Checked == true)
            {
                internet = rbInternet.Checked;
                prixmaximun = hsbprix.Value;
                nbplace = hsbnbplace.Value;
                MessageBox.Show("Filtre internet+prix+nbplace");
                int i = 0;
                foreach (Hebergement elements in Connexion1.RechercheFiltreinternetprixnbplace(internet, prixmaximun, nbplace))
                {
                    lbheberg.Items.Add(Connexion1.RechercheFiltreinternetprixnbplace(internet, prixmaximun, nbplace)[i]);
                    i = i + 1;
                }
            }
            //recherche flitre prixmaximun+nbplace+secteur//
            if (hsbprix.Value != 0 && hsbsurface.Value == 0 && hsbnbplace.Value != 0 && tbsecteur.Text != "" && rbInternet.Checked == false)
            {
                secteur = tbsecteur.Text;
                prixmaximun = hsbprix.Value;
                nbplace = hsbnbplace.Value;
                MessageBox.Show("Filtre prix+nbplace+secteur");
                int i = 0;
                foreach (Hebergement elements in Connexion1.RechercheFiltreprixnbplacesecteur(prixmaximun, nbplace, secteur))
                {
                    lbheberg.Items.Add(Connexion1.RechercheFiltreprixnbplacesecteur(prixmaximun, nbplace, secteur)[i]);
                    i = i + 1;
                }
            }
            //recherche flitre nbplace+internet+surface//
            if (hsbprix.Value == 0 && hsbsurface.Value != 0 && hsbnbplace.Value != 0 && tbsecteur.Text == "" && rbInternet.Checked == true)
            {
                internet = rbInternet.Checked;
                nbplace = hsbnbplace.Value;
                nbsurface = hsbsurface.Value;
                MessageBox.Show("Filtre nbplace+internet+surface");
                int i = 0;
                foreach (Hebergement elements in Connexion1.RechercheFiltrenbplaceinternetsurface(nbplace, internet, nbsurface))
                {
                    lbheberg.Items.Add(Connexion1.RechercheFiltrenbplaceinternetsurface(nbplace, internet, nbsurface)[i]);
                    i = i + 1;
                }
            }
            //recherche filtre internet+secteur+surface//
            if (hsbprix.Value == 0 && hsbsurface.Value != 0 && hsbnbplace.Value == 0 && tbsecteur.Text != "" && rbInternet.Checked == true)
            {
                internet = rbInternet.Checked;
                secteur = tbsecteur.Text;
                nbsurface = hsbsurface.Value;
                MessageBox.Show("Filtre internet+secteur+surface");
                int i = 0;
                foreach (Hebergement elements in Connexion1.RechercheFiltreinternetsecteursurface(internet, secteur, nbsurface))
                {
                    lbheberg.Items.Add(Connexion1.RechercheFiltreinternetsecteursurface(internet, secteur, nbsurface)[i]);
                    i = i + 1;
                }
            }
            //recherche filtre prix+secteur+surface//
            if (hsbprix.Value != 0 && hsbsurface.Value != 0 && hsbnbplace.Value == 0 && tbsecteur.Text != "" && rbInternet.Checked == false)
            {
                prixmaximun = hsbprix.Value;
                secteur = tbsecteur.Text;
                nbsurface = hsbsurface.Value;
                MessageBox.Show("Filtre prix+secteur+surface");
                int i = 0;
                foreach (Hebergement elements in Connexion1.RechercheFiltreprixsecteursurface(prixmaximun, secteur, nbsurface))
                {
                    lbheberg.Items.Add(Connexion1.RechercheFiltreinternetsecteursurface(internet, secteur, nbsurface)[i]);
                    i = i + 1;
                }
            }
            //Recherche filtre type_hebergement//
            if (hsbprix.Value == 0 && hsbsurface.Value == 0 && hsbnbplace.Value == 0 && tbsecteur.Text == "" && rbInternet.Checked == false && cbtype.Text != "")
            {
                MessageBox.Show("Filtre type");
                int i = 0;
                foreach (Hebergement elements in Connexion1.RechercheFiltretype(cod_type))
                {
                    lbheberg.Items.Add(Connexion1.RechercheFiltretype(cod_type)[i]);
                    i = i + 1;
                }
            }










            if (hsbsurface.Value != 0)
            {
                nbsurface = hsbsurface.Value;
            }
            if (hsbnbplace.Value != 0)
            {
                nbplace = hsbnbplace.Value;
            }
            if (tbsecteur.Text != "")
            {
                secteur = tbsecteur.Text;
            }
            if (rbInternet.Checked)
            {
                internet = rbInternet.Checked;
            }


            //Recherche sans filtre//
            /* int i = 0;
             foreach(string elements in Connexion1.RechercheSansFiltre())
             {
                 listBox1.Items.Add(Connexion1.RechercheSansFiltre()[i]);
                 i = i + 1;
             }
             Connexion1.RechercheTousLesFiltre(prixmaximun, nbplace, nbsurface, secteur, internet,prixmaximun);

     */




        }

        private void hsbprix_Scroll(object sender, ScrollEventArgs e)
        {
            label8.Text = hsbprix.Value.ToString();
        }

        private void hsbnbplace_Scroll(object sender, ScrollEventArgs e)
        {
            label11.Text = hsbnbplace.Value.ToString();
        }

        private void hsbsurface_Scroll(object sender, ScrollEventArgs e)
        {
            label15.Text = hsbsurface.Value.ToString();
        }

        private void hsbsurface_Scroll_1(object sender, ScrollEventArgs e)
        {
            label15.Text = hsbsurface.Value.ToString();
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void btreserver_Click(object sender, EventArgs e)
        {
            Hebergement hebergement = (Hebergement)lbheberg.SelectedItem;

            if (lbheberg.SelectedItem != null)
            {
                label29.Text = hebergement.GetMontant().ToString() + "€ Par Personne";

            }
            label12.Text = hsbnbplaces.Value.ToString();
            groupBox2.Visible = true;
            label3.Visible = true;
            dtpdatedebut.Visible = true;
            hsbnbplaces.Visible = true;
            btconsultersemainereserv.Visible = true;
            label4.Visible = true;
            hsbnbplaces.Visible = true;
            label12.Visible = true;
            label5.Visible = true;
            label29.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbheberg.Items.Clear();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            pbphoto.Visible = true;
            label17.Visible = true;
            label18.Visible = true;
            label19.Visible = true;
            label20.Visible = true;
            label21.Visible = true;
            label22.Visible = true;
            label23.Visible = true;
            label24.Visible = true;
            label25.Visible = true;
            label26.Visible = true;
            label31.Visible = true;
            label28.Visible = true;
            label27.Visible = true;
            label32.Visible = true;
            label34.Visible = true;
            label35.Visible = true;
            label30.Visible = true;

            Hebergement hebergement = (Hebergement)lbheberg.SelectedItem;

            if (lbheberg.SelectedItem != null)
            {
                label18.Text = hebergement.GetMontant().ToString();
                label20.Text = hebergement.GetSecteur();
                label22.Text = hebergement.GetTypeH();
                label24.Text = hebergement.GetAnnneRemise().ToString();
                label26.Text = hebergement.GetNBMAX().ToString();
                label28.Text = hebergement.GetSurface().ToString();
                label32.Text = hebergement.GetInternet().ToString();
                label35.Text = hebergement.GetOrientation();
                rtbdescription.Text = hebergement.GetDescription();
                pbphoto.ImageLocation = hebergement.GetPhoto();
                btReserver.Visible = true;
            }
        }


        private void btvaliderreserv_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
            clbsemaine.Visible = true;
            btvalidereserv.Visible = true;
            Hebergement hebergement1 = (Hebergement)lbheberg.SelectedItem;
            DateTime datedebut = dtpdatedebut.Value;
            

            /*//Verification que la date est bien du samedi en samedi//
            if (dtpdatedebut.Value.DayOfWeek == DayOfWeek.Saturday)
            {
                
                if (listBox1.SelectedItem != null)
                {
                    Semaine Semaine1 = new Semaine(datedebut);
                    reservation1.AjouterSemaine(Semaine1);
                    DateTime date = Semaine1.GetDateFin();
                    for (int i = 1; i <100; i = i + 1)
                    {
                        Semaine s = new Semaine(date);
                        date = s.GetDateFin();
                        reservation1.AjouterSemaine(s);
                    }
                }
            }
            else
            {
                MessageBox.Show("Les Reservations ne sont font que pour le samedi");
            }

            
           */
            List<DateTime> LHebergementNReverser = new List<DateTime>();
            LHebergementNReverser = Connexion1.HebergementReserver(hebergement1);
            //Pour metttre toutes les dates de reservation disponibles///
            foreach (DateTime date in LHebergementNReverser)
            {
                clbsemaine.Items.Add(date);
            }

        }

        private void btvalidereserv_Click(object sender, EventArgs e)
        {
            if (clbsemaine.CheckedItems.Count>0)
            {
               
                foreach (DateTime date in clbsemaine.CheckedItems)
                {
                    Hebergement hebergement1 = (Hebergement)lbheberg.SelectedItem;
                    int nboccupant = hsbnbplaces.Value;
                    string date1 = date.ToString("yyyy-MM-dd");
                    if (Connexion1.Reserver(date1,hebergement1,nboccupant)==true)
                            {
                        MessageBox.Show("Reservation Effectué");
                        MessageBox.Show(date1);
                        MessageBox.Show("Veuillez notez votre numéro de reservation bien soigneusement :  " + Connexion1.AfficherReservation(date1,hebergement1));
                    }
                    
                    Accueil accueil = new Accueil();
                    accueil.Show();
                   
                }
            }
        }

        private void hsbnbplaces_Scroll(object sender, ScrollEventArgs e)
        {
            label12.Text = hsbnbplaces.Value.ToString();
        }


        //foreach(DateTime d in LHebergementNReverser)
        //{
        //    checkedListBox1.Items.Add(d.ToShortDateString());
        //}





    }
}
    

