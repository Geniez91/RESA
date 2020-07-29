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
    public partial class VoirListeUtilisateur : Form
    {
        public VoirListeUtilisateur()
        {
            InitializeComponent();
            Connexion c1 = new Connexion();
       
            for (int i = 0; i < c1.AfficherListeCompte().Count-1; i++)
            {
                dataGridView1.Rows.Add();
            }
           
            for (int i=0;i<c1.AfficherListeCompte().Count;i=i+1)
            {
                dataGridView1[0, i].Value = c1.AfficherListeCompte()[i].GetId();
                dataGridView1[1, i].Value = c1.AfficherListeCompte()[i].GetNom();
                dataGridView1[2, i].Value = c1.AfficherListeCompte()[i].GetMDP();

                
            }
            



        }


    }
}

