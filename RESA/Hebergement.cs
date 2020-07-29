using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESA
{
   public class Hebergement
    {
        private int num;    
        private string nom;
        private bool disponibilité;
        private int nbMax;
        private double surface;
        private bool internet;
        private int anneeremise;
        private string secteur;
        private string orientation;
        private string etat;
        private string description;
        private string photo;
        private string type;
        private List<Reservation> ListeReservation = new List<Reservation>();
        private int montant;
       
        public Hebergement(string nom,int nbMax,double surface,bool internet,int anneeremise,string secteur,string orientation,string etat,string description,string photo,int montant,string type)
        {
            this.nom = nom;
            this.disponibilité = true;
            this.nbMax = nbMax;
            this.surface = surface;
            this.internet = internet;
            this.anneeremise = anneeremise;
            this.secteur = secteur;
            this.orientation = orientation;
            this.etat = etat;
            this.description = description;
            this.photo = photo;
            disponibilité = true;
            this.montant = montant;
            this.type = type;
        }
        public string GetNom()
        {
            return nom;
        }
        public bool GetDisponibilité()
        {
            return disponibilité;
        }
        public int GetNBMAX()
        {
            return nbMax;
        }
        public double GetSurface()
        {
            return surface;
        }
        public bool GetInternet()
        {
            return internet;
        }
        public int GetAnnneRemise()
        {
            return anneeremise;
        }
        public string GetSecteur()
        {
            return secteur;
        }
        public string GetOrientation()
        {
            return orientation;
        }
        public string GetEtat()
        {
            return etat;
        }
        public string GetDescription()
        {
            return description;
        }
        public string GetPhoto()
        {
            return photo;
        }
        public int GetMontant()
        {
            return montant;
        }
        public string GetTypeH()
        {
            return type;
        }
        public override string ToString()
        {
            return nom;
        }
        public void SetNum(int num)
        {
            this.num = num;
        }
        public int GetNum()
        {
            return num;
        }


    }
}
