using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace RESA
{
    public partial class Creation : Form
    {
        Connexion Connexion1 = new Connexion();
        public Creation()
        {
            InitializeComponent();
            

            List<string> test = new List<string>();
            test = Connexion1.SelectionType();
            
            for(int i=0;i<test.Count;i++)
            {
                cbtype.Items.Add(test[i]);
            }
            





        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void gbCaractéristique_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            tbImage.Text = openFileDialog1.FileName;
        }

        private void btvalider_Click(object sender, EventArgs e)
        {
            bool internet;
            if (rbInternetoui.Checked)
            {
                internet = true;
            }
            else
            {
                internet = false;
            }
            string code_type = Connexion1.SelectionCodeType(cbtype.SelectedItem.ToString()); ;
            Hebergement hebergement = new Hebergement(tbNom.Text, Convert.ToInt32(nupd.Value), hsbSurface.Value, internet, Convert.ToInt32(tbAnneRemise.Text), tbSecteur.Text, cborientation.Text, cbEtat.Text, rtbdesc.Text, tbImage.Text, Convert.ToInt32(tbmontant.Text),code_type);
            if (Connexion1.InsererHebergement(hebergement.GetNom(), hebergement.GetNBMAX(), Convert.ToInt16(hebergement.GetSurface()), hebergement.GetInternet(), hebergement.GetAnnneRemise(), hebergement.GetSecteur(), hebergement.GetOrientation(), hebergement.GetEtat(), hebergement.GetDescription(), hebergement.GetTypeH(), hebergement.GetMontant(), hebergement.GetPhoto()) == true)
            {
                MessageBox.Show("Hebergement Crée");
            }
          
            
            

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void Creation_Load(object sender, EventArgs e)
        {

        }
    }
}
