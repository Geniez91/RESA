using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESA
{
   public class Reservation
    {
        private int Montant;
        private int nboccupant;
        private string etat;
        private string compte;
        private string NoHeb;
        private int montantarret;
        private string Noresa;
        private DateTime dateresa;
        private DateTime datearret;
        private DateTime debsemaine;

        public Reservation(int Montant,int nboccupant,string etat,string compte,string NoHeb,int montantarret,string Noresa,DateTime dateresa, DateTime datearret,DateTime debsemaine)
        {
            this.Montant = Montant;
            this.nboccupant = nboccupant;
            this.etat = etat;
            this.compte = compte;
            this.NoHeb = NoHeb;
            this.montantarret = montantarret;
            this.Noresa = Noresa;
            this.dateresa = dateresa;
            this.datearret = datearret;
            this.debsemaine = debsemaine;
        }

   
        public override string ToString()
        {
            return Noresa;
        }
        public string GetCompte()
        {
            return compte;
        }
        public int GetMontant()
        {
            return Montant;
        }
        public string GetEtat()
        {
            return etat;
        }
        public int GetNboccupant()
        {
            return nboccupant;
        }
        public string GetNohebergement()
        {
            return NoHeb;
        }
        public int GetMontantArret()
        {
            return montantarret;
        }
        public string GetNoResa()
        {
            return Noresa;
        }
        public DateTime GetDateArret()
        {
            return datearret;
        }
        public DateTime GetDateResa()
        {
            return dateresa;
        }
        public DateTime GetDebSemaine()
        {
            return debsemaine;
        }
        public void SetEtat(string code)
        {
            this.etat = code;
        }
    }
}
