using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESA
{
    public class Compte
    {
        private string id;
        private string mdp;
        private string nom;
        private string prenom;
        private DateTime DATEINSCRIP;
        private DateTime DATEFERME;
        private string TYPECOMPTE;
        private string ADRMAILCPTE;
        private string NOTELCPTE;
        private string NOPORTCPTE;
        public Compte(string id,string mdp,string nom, string prenom, DateTime DATEINSCRIP,string TYPECOMPTE,string ADRMAILCPTE, string NOTELCPTE, string NOPORTCPTE)
        {
            this.id = id;
            this.mdp = mdp;
            this.nom = nom;
            this.prenom = prenom;
            this.DATEINSCRIP = DATEINSCRIP;
            this.TYPECOMPTE = TYPECOMPTE;
            this.ADRMAILCPTE = ADRMAILCPTE;
            this.NOTELCPTE = NOTELCPTE;
            this.NOTELCPTE = NOPORTCPTE;

        }
        public Compte(string id,string mdp,string nom,string typecompte)
        {
            this.id = id;
            this.mdp = mdp;
            this.nom = nom;
            this.TYPECOMPTE = typecompte;
        }
       
        public string GetId()
        {
            return id;
        }
        public string GetMDP()
        {
            return mdp;
        }
        public string GetNom()
        {
            return nom;
        }
        public string Getprenom()
        {
            return prenom;
        }
        public DateTime GetDATEINSCRIP()
        {
            return DATEINSCRIP;
        }
        public DateTime GetDateFerme()
        {
            return DATEFERME;
        }

        public string GetTypeCompte()
        {
            return TYPECOMPTE;
        }
        public string GetMail()
        {
            return ADRMAILCPTE;
        }
        public string GetNotel()
        {
            return NOTELCPTE;
        }
        public string GetNoPortable()
        {
            return NOPORTCPTE;
        }
    }
}
