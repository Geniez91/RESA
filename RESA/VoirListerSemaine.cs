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
    public partial class VoirListerSemaine : Form
    {
        Connexion connexion1 = new Connexion();
        public VoirListerSemaine()
        {
            InitializeComponent();
        }

        private void btvalider_Click(object sender, EventArgs e)
        {
            lbReservation.Visible = true;
            btinfo.Visible = true;
            DateTime date = dtpDate.Value;
            string date1 = date.ToString("yyyy-MM-dd");
            string code = connexion1.CodeHeberg(tbNom.Text);
            //Reservation Date///
            if (cb1.Checked)
            {
                foreach (Reservation Reservation1 in connexion1.AfficherListeReservation(date1))
                {
                    lbReservation.Items.Add(Reservation1);
                }
            }

            ///Reservation Hebergement///
            else
            {
                if (cb2.Checked)
                {
                    foreach (Reservation Reservation1 in connexion1.AfficherListeResaHeberg(code))
                    {
                        lbReservation.Items.Add(Reservation1);
                    }
                }
                else
                {
                  
                        foreach (Reservation Reservation1 in connexion1.AfficherListeResaHebergDate(code,date1))
                        {
                            lbReservation.Items.Add(Reservation1);
                        }
                  
                }
            }
        }

        private void btinfo_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label12.Visible = true;
            label13.Visible = true;
            label10.Visible = true;
            label11.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            label14.Visible = true;
            label15.Visible = true;
            label16.Visible = true;
            label17.Visible = true;
            label18.Visible = true;
            label19.Visible = true;
            btmodifier.Visible = true;
            Reservation Reservation1 = (Reservation)lbReservation.SelectedItem;
            if (lbReservation.SelectedItem != null)
            {
                label3.Text = Reservation1.GetCompte();
                label5.Text = Reservation1.GetNohebergement();
                string etat = connexion1.EtatReserv(Reservation1.GetEtat());
                label7.Text = etat;
                label13.Text = Reservation1.GetMontantArret().ToString();
                label11.Text = Reservation1.GetDateArret().ToString();
                label9.Text = Reservation1.GetDateResa().ToString();
                label15.Text = Reservation1.GetNboccupant().ToString();
                label17.Text = Reservation1.GetMontant().ToString();
                label19.Text = Reservation1.GetDebSemaine().ToShortDateString();

            }
        }

        private void btmodifier_Click(object sender, EventArgs e)
        {
            gbmodifier.Visible = true;
            label21.Visible = true;
            cbetape.Visible = true;
            btvalidermodif.Visible = true;

            Reservation r1 = (Reservation)lbReservation.SelectedItem;
            string etat = connexion1.EtatReserv(r1.GetEtat());
            if (DateTime.Now<=r1.GetDebSemaine())
            {
                
                foreach(string etat1 in connexion1.AfficherListeEtat())
                {
                    cbetape.Items.Add(etat1);
                }
                cbetape.Text = etat;
            }
            else
            {
                MessageBox.Show("Vous ne pouvez pas modifier une reservation qui est deja terminer");
            }
            

        }

        private void btvalidermodif_Click(object sender, EventArgs e)
        {
            Reservation r1 = (Reservation)lbReservation.SelectedItem;
            string etat = cbetape.SelectedItem.ToString();
            string code = connexion1.CodeEtatReserv(etat);
            
            if (connexion1.ModifierEtape(code,r1.GetNoResa())==true)
            {
                r1.SetEtat(code);
                MessageBox.Show("Modification de la Reservation Effectué");
                MessageBox.Show("Veuillez notez le Numéro de reservation suivant: " + r1.GetNoResa());
                MessageBox.Show("Veuillez notez le Etape de reservation suivant: " +etat );
              
            }
            else
            {
                MessageBox.Show("Reservation non Effectué");
            }
        }
    }
}
