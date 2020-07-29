using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Collections;

namespace RESA
{
    public class Connexion
    {
        private string connectionString;
        private MySqlConnection cnn;
        public Connexion()
        {

        }
        public void SeConnecter()
        {

            connectionString = "database = resajeremy; server = localhost; user  = root; pwd = ";
            cnn = new MySqlConnection(connectionString);
            try
            {
                cnn.Open();
            }
            catch (Exception ex)
            {

            }
        }
        public bool ConnexionUtilisateur(string utilisateur, string mdp)
        {
            SeConnecter();
            string query = "SELECT USER, MDP FROM compte WHERE NOMCPTE ='" + utilisateur + "' AND MDP ='" + mdp + "'";
            MySqlCommand cmd = new MySqlCommand(query, cnn);
            cmd.ExecuteNonQuery();
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool VerifierTypeCompte(string utilisateur, string mdp)
        {
            SeConnecter();
            string query = "SELECT TYPECOMPTE FROM compte WHERE USER ='" + utilisateur + "' AND MDP ='" + mdp + "'AND TYPECOMPTE ='1'";
            MySqlCommand cmd = new MySqlCommand(query, cnn);
            cmd.ExecuteNonQuery();
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool InsererHebergement(string nomheb, int nbplace, int surfaceheb, bool internet, int annee, string secteur, string orientation, string etat, string description, string type, int montant, string photo)
        {
            SeConnecter();
            string query = "INSERT INTO hebergement(NOMHEB,NBPLACEHEB,SURFACEHEB,INTERNET,ANNEEHEB,SECTEURHEB,ORIENTATIONHEB,ETATHEB,DESCRIHEB,CODETYPEHEB,TARIFSEMHEB,PHOTOHEB) VALUES('" + nomheb + "'," + nbplace + "," + surfaceheb + "," + internet + "," + annee + ",'" + secteur + "','" + orientation + "','" + etat + "','" + description + "'," + type + "," + montant + ",'" + photo + "')";
            MySqlCommand cmd = new MySqlCommand(query, cnn);
            cmd.ExecuteNonQuery();
            if(cmd.CommandText.Count()>0)
            {
                return true;
            }
            else
            {
                return false;
            }


        }
        public List<string> SelectionType()
        {
            List<string> type = new List<string>();
            SeConnecter();
            string query = "SELECT 	NOMTYPEHEB FROM type_heb ";
            MySqlCommand cmd = new MySqlCommand(query, cnn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string textReadType = reader["NOMTYPEHEB"].ToString();
                type.Add(textReadType);
            }

            return type;

        }
        public string SelectionCodeType(string type)
        {
            SeConnecter();
            string query = "SELECT CODETYPEHEB FROM type_heb WHERE NOMTYPEHEB='" + type + "'";
            MySqlCommand cmd = new MySqlCommand(query, cnn);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                string textReadCodetype = reader["CODETYPEHEB"].ToString();
                return textReadCodetype;
            }
            return null;

        }
        //Recherche d'hebergement sans filtre
        public List<string> RechercheSansFiltre()
        {
            SeConnecter();
            string query = "SELECT NOMHEB FROM hebergement";
            MySqlCommand cmd = new MySqlCommand(query, cnn);
            MySqlDataReader reader = cmd.ExecuteReader();
            List<string> test = new List<string>();
            while (reader.Read())
            {
                string textReadCodetype = reader["NOMHEB"].ToString();
                test.Add(textReadCodetype);
            }
            return test;
        }
        //Recherche d'hebergement avec tous les filtres choisies par l'utilisateur//
        public List<Hebergement> RechercheTousLesFiltre(string codetype, int nbplaces, int surface, string secteur, bool internet, int montant)
        {
            SeConnecter();
            string query = "SELECT * FROM hebergement WHERE CODETYPEHEB='" + codetype + "'AND NBPLACEHEB>=" + nbplaces + " AND SURFACEHEB>=" + surface + " AND SECTEURHEB='" + secteur + "' AND INTERNET=" + internet + " AND TARIFSEMHEB<=" + montant + "";
            MySqlCommand cmd = new MySqlCommand(query, cnn);
            MySqlDataReader reader = cmd.ExecuteReader();
            List<Hebergement> test = new List<Hebergement>();
            while (reader.Read())
            {

                string textReadNom = reader["NOMHEB"].ToString();
                string textReadCodetype = reader["CODETYPEHEB"].ToString();
                int textReadnbplace = reader.GetInt16("NBPLACEHEB");
                int textReadsurface = reader.GetInt16("NBPLACEHEB");
                string textReadsecteur = reader["SECTEURHEB"].ToString();
                bool textReadInternet = reader.GetBoolean("internet");
                int textReadMontant = reader.GetInt16("TARIFSEMHEB");
                int textReadanneremise = reader.GetInt16("ANNEEHEB");
                string textReadorientation = reader["ORIENTATIONHEB"].ToString();
                string textReadetat = reader["ETATHEB"].ToString();
                string textReaddescription = reader["DESCRIHEB"].ToString();
                string textReadphoto = reader["PHOTOHEB"].ToString();
                Hebergement hebergement1 = new Hebergement(textReadNom, textReadnbplace, textReadsurface, textReadInternet, textReadanneremise, textReadsecteur, textReadorientation, textReadetat, textReaddescription, textReadphoto, textReadMontant, textReadCodetype);
                hebergement1.SetNum(reader.GetInt32("NOHEB"));
                test.Add(hebergement1);
            }
            return test;
        }
        public List<Hebergement> RechercheFiltrePrix(int montant)
        {
            SeConnecter();
            string query = "SELECT * FROM hebergement WHERE TARIFSEMHEB<=" + montant + "";
            MySqlCommand cmd = new MySqlCommand(query, cnn);
            MySqlDataReader reader = cmd.ExecuteReader();
            List<Hebergement> test = new List<Hebergement>();
            while (reader.Read())
            {

                string textReadNom = reader["NOMHEB"].ToString();
                string textReadCodetype = reader["CODETYPEHEB"].ToString();
                int textReadnbplace = reader.GetInt16("NBPLACEHEB");
                int textReadsurface = reader.GetInt16("NBPLACEHEB");
                string textReadsecteur = reader["SECTEURHEB"].ToString();
                bool textReadInternet = reader.GetBoolean("internet");
                int textReadMontant = reader.GetInt16("TARIFSEMHEB");
                int textReadanneremise = reader.GetInt16("ANNEEHEB");
                string textReadorientation = reader["ORIENTATIONHEB"].ToString();
                string textReadetat = reader["ETATHEB"].ToString();
                string textReaddescription = reader["DESCRIHEB"].ToString();
                string textReadphoto = reader["PHOTOHEB"].ToString();
                Hebergement hebergement1 = new Hebergement(textReadNom, textReadnbplace, textReadsurface, textReadInternet, textReadanneremise, textReadsecteur, textReadorientation, textReadetat, textReaddescription, textReadphoto, textReadMontant, textReadCodetype);
                hebergement1.SetNum(reader.GetInt32("NOHEB"));
                test.Add(hebergement1);
            }
            return test;
        }
        public List<Hebergement> RechercheFiltrePrixetsurface(int montant, int surface)
        {
            SeConnecter();
            string query = "SELECT * FROM hebergement WHERE TARIFSEMHEB<=" + montant + " AND SURFACEHEB<=" + surface + "";
            MySqlCommand cmd = new MySqlCommand(query, cnn);
            MySqlDataReader reader = cmd.ExecuteReader();
            List<Hebergement> test = new List<Hebergement>();
            while (reader.Read())
            {

                string textReadNom = reader["NOMHEB"].ToString();
                string textReadCodetype = reader["CODETYPEHEB"].ToString();
                int textReadnbplace = reader.GetInt16("NBPLACEHEB");
                int textReadsurface = reader.GetInt16("NBPLACEHEB");
                string textReadsecteur = reader["SECTEURHEB"].ToString();
                bool textReadInternet = reader.GetBoolean("internet");
                int textReadMontant = reader.GetInt16("TARIFSEMHEB");
                int textReadanneremise = reader.GetInt16("ANNEEHEB");
                string textReadorientation = reader["ORIENTATIONHEB"].ToString();
                string textReadetat = reader["ETATHEB"].ToString();
                string textReaddescription = reader["DESCRIHEB"].ToString();
                string textReadphoto = reader["PHOTOHEB"].ToString();
                Hebergement hebergement1 = new Hebergement(textReadNom, textReadnbplace, textReadsurface, textReadInternet, textReadanneremise, textReadsecteur, textReadorientation, textReadetat, textReaddescription, textReadphoto, textReadMontant, textReadCodetype);
                hebergement1.SetNum(reader.GetInt32("NOHEB"));
                test.Add(hebergement1);
            }
            return test;
        }
        public List<Hebergement> RechercheFiltrePrixsurfacenbplace(int montant, int surface, int nbplace)
        {
            SeConnecter();
            string query = "SELECT * FROM hebergement WHERE TARIFSEMHEB<=" + montant + " AND SURFACEHEB<=" + surface + " AND NBPLACEHEB<=" + nbplace + "";
            MySqlCommand cmd = new MySqlCommand(query, cnn);
            MySqlDataReader reader = cmd.ExecuteReader();
            List<Hebergement> test = new List<Hebergement>();
            while (reader.Read())
            {
                string textReadNom = reader["NOMHEB"].ToString();
                string textReadCodetype = reader["CODETYPEHEB"].ToString();
                int textReadnbplace = reader.GetInt16("NBPLACEHEB");
                int textReadsurface = reader.GetInt16("NBPLACEHEB");
                string textReadsecteur = reader["SECTEURHEB"].ToString();
                bool textReadInternet = reader.GetBoolean("internet");
                int textReadMontant = reader.GetInt16("TARIFSEMHEB");
                int textReadanneremise = reader.GetInt16("ANNEEHEB");
                string textReadorientation = reader["ORIENTATIONHEB"].ToString();
                string textReadetat = reader["ETATHEB"].ToString();
                string textReaddescription = reader["DESCRIHEB"].ToString();
                string textReadphoto = reader["PHOTOHEB"].ToString();
                Hebergement hebergement1 = new Hebergement(textReadNom, textReadnbplace, textReadsurface, textReadInternet, textReadanneremise, textReadsecteur, textReadorientation, textReadetat, textReaddescription, textReadphoto, textReadMontant, textReadCodetype);
                hebergement1.SetNum(reader.GetInt32("NOHEB"));
                test.Add(hebergement1);
            }
            return test;
        }
        public List<Hebergement> RechercheFiltrePrixsurfacenbplacesecteur(int montant, int surface, int nbplace, string secteur)
        {
            SeConnecter();
            string query = "SELECT * FROM hebergement WHERE TARIFSEMHEB<=" + montant + " AND SURFACEHEB<=" + surface + " AND NBPLACEHEB<=" + nbplace + " AND SECTEURHEB='" + secteur + "'";
            MySqlCommand cmd = new MySqlCommand(query, cnn);
            MySqlDataReader reader = cmd.ExecuteReader();
            List<Hebergement> test = new List<Hebergement>();
            while (reader.Read())
            {
                string textReadNom = reader["NOMHEB"].ToString();
                string textReadCodetype = reader["CODETYPEHEB"].ToString();
                int textReadnbplace = reader.GetInt16("NBPLACEHEB");
                int textReadsurface = reader.GetInt16("NBPLACEHEB");
                string textReadsecteur = reader["SECTEURHEB"].ToString();
                bool textReadInternet = reader.GetBoolean("internet");
                int textReadMontant = reader.GetInt16("TARIFSEMHEB");
                int textReadanneremise = reader.GetInt16("ANNEEHEB");
                string textReadorientation = reader["ORIENTATIONHEB"].ToString();
                string textReadetat = reader["ETATHEB"].ToString();
                string textReaddescription = reader["DESCRIHEB"].ToString();
                string textReadphoto = reader["PHOTOHEB"].ToString();
                Hebergement hebergement1 = new Hebergement(textReadNom, textReadnbplace, textReadsurface, textReadInternet, textReadanneremise, textReadsecteur, textReadorientation, textReadetat, textReaddescription, textReadphoto, textReadMontant, textReadCodetype);
                hebergement1.SetNum(reader.GetInt32("NOHEB"));
                test.Add(hebergement1);
            }
            return test;
        }
        public List<Hebergement> RechercheFiltresurface(int surface)
        {
            SeConnecter();
            string query = "SELECT *FROM hebergement WHERE SURFACEHEB<=" + surface + "";
            MySqlCommand cmd = new MySqlCommand(query, cnn);
            MySqlDataReader reader = cmd.ExecuteReader();
            List<Hebergement> test = new List<Hebergement>();
            while (reader.Read())
            {
                string textReadNom = reader["NOMHEB"].ToString();
                string textReadCodetype = reader["CODETYPEHEB"].ToString();
                int textReadnbplace = reader.GetInt16("NBPLACEHEB");
                int textReadsurface = reader.GetInt16("NBPLACEHEB");
                string textReadsecteur = reader["SECTEURHEB"].ToString();
                bool textReadInternet = reader.GetBoolean("internet");
                int textReadMontant = reader.GetInt16("TARIFSEMHEB");
                int textReadanneremise = reader.GetInt16("ANNEEHEB");
                string textReadorientation = reader["ORIENTATIONHEB"].ToString();
                string textReadetat = reader["ETATHEB"].ToString();
                string textReaddescription = reader["DESCRIHEB"].ToString();
                string textReadphoto = reader["PHOTOHEB"].ToString();
                Hebergement hebergement1 = new Hebergement(textReadNom, textReadnbplace, textReadsurface, textReadInternet, textReadanneremise, textReadsecteur, textReadorientation, textReadetat, textReaddescription, textReadphoto, textReadMontant, textReadCodetype);
                hebergement1.SetNum(reader.GetInt32("NOHEB"));
                test.Add(hebergement1);
            }
            return test;
        }
        public List<Hebergement> RechercheFiltresurfacenbplace(int surface, int nbplace)
        {
            SeConnecter();
            string query = "SELECT * FROM hebergement WHERE SURFACEHEB<=" + surface + " AND NBPLACEHEB<=" + nbplace + "";
            MySqlCommand cmd = new MySqlCommand(query, cnn);
            MySqlDataReader reader = cmd.ExecuteReader();
            List<Hebergement> test = new List<Hebergement>();
            while (reader.Read())
            {
                string textReadNom = reader["NOMHEB"].ToString();
                string textReadCodetype = reader["CODETYPEHEB"].ToString();
                int textReadnbplace = reader.GetInt16("NBPLACEHEB");
                int textReadsurface = reader.GetInt16("NBPLACEHEB");
                string textReadsecteur = reader["SECTEURHEB"].ToString();
                bool textReadInternet = reader.GetBoolean("internet");
                int textReadMontant = reader.GetInt16("TARIFSEMHEB");
                int textReadanneremise = reader.GetInt16("ANNEEHEB");
                string textReadorientation = reader["ORIENTATIONHEB"].ToString();
                string textReadetat = reader["ETATHEB"].ToString();
                string textReaddescription = reader["DESCRIHEB"].ToString();
                string textReadphoto = reader["PHOTOHEB"].ToString();
                Hebergement hebergement1 = new Hebergement(textReadNom, textReadnbplace, textReadsurface, textReadInternet, textReadanneremise, textReadsecteur, textReadorientation, textReadetat, textReaddescription, textReadphoto, textReadMontant, textReadCodetype);
                hebergement1.SetNum(reader.GetInt32("NOHEB"));
                test.Add(hebergement1);
            }
            return test;
        }
        public List<Hebergement> RechercheFiltresurfacenbplacesecteur(int surface, int nbplace, string secteur)
        {
            SeConnecter();
            string query = "SELECT * FROM hebergement WHERE SURFACEHEB<=" + surface + " AND NBPLACEHEB<=" + nbplace + " AND SECTEURHEB='" + secteur + "'";
            MySqlCommand cmd = new MySqlCommand(query, cnn);
            MySqlDataReader reader = cmd.ExecuteReader();
            List<Hebergement> test = new List<Hebergement>();
            while (reader.Read())
            {
                string textReadNom = reader["NOMHEB"].ToString();
                string textReadCodetype = reader["CODETYPEHEB"].ToString();
                int textReadnbplace = reader.GetInt16("NBPLACEHEB");
                int textReadsurface = reader.GetInt16("NBPLACEHEB");
                string textReadsecteur = reader["SECTEURHEB"].ToString();
                bool textReadInternet = reader.GetBoolean("internet");
                int textReadMontant = reader.GetInt16("TARIFSEMHEB");
                int textReadanneremise = reader.GetInt16("ANNEEHEB");
                string textReadorientation = reader["ORIENTATIONHEB"].ToString();
                string textReadetat = reader["ETATHEB"].ToString();
                string textReaddescription = reader["DESCRIHEB"].ToString();
                string textReadphoto = reader["PHOTOHEB"].ToString();
                Hebergement hebergement1 = new Hebergement(textReadNom, textReadnbplace, textReadsurface, textReadInternet, textReadanneremise, textReadsecteur, textReadorientation, textReadetat, textReaddescription, textReadphoto, textReadMontant, textReadCodetype);
                hebergement1.SetNum(reader.GetInt32("NOHEB"));
                test.Add(hebergement1);
            }
            return test;
        }
        public List<Hebergement> RechercheFiltresurfacenbplacesecteurinternet(int surface, int nbplace, string secteur, bool internet)
        {
            SeConnecter();
            string query = "SELECT * FROM hebergement WHERE SURFACEHEB<=" + surface + " AND NBPLACEHEB<=" + nbplace + " AND SECTEURHEB='" + secteur + "' AND INTERNET=" + internet + "";
            MySqlCommand cmd = new MySqlCommand(query, cnn);
            MySqlDataReader reader = cmd.ExecuteReader();
            List<Hebergement> test = new List<Hebergement>();
            while (reader.Read())
            {
                string textReadNom = reader["NOMHEB"].ToString();
                string textReadCodetype = reader["CODETYPEHEB"].ToString();
                int textReadnbplace = reader.GetInt16("NBPLACEHEB");
                int textReadsurface = reader.GetInt16("NBPLACEHEB");
                string textReadsecteur = reader["SECTEURHEB"].ToString();
                bool textReadInternet = reader.GetBoolean("internet");
                int textReadMontant = reader.GetInt16("TARIFSEMHEB");
                int textReadanneremise = reader.GetInt16("ANNEEHEB");
                string textReadorientation = reader["ORIENTATIONHEB"].ToString();
                string textReadetat = reader["ETATHEB"].ToString();
                string textReaddescription = reader["DESCRIHEB"].ToString();
                string textReadphoto = reader["PHOTOHEB"].ToString();
                Hebergement hebergement1 = new Hebergement(textReadNom, textReadnbplace, textReadsurface, textReadInternet, textReadanneremise, textReadsecteur, textReadorientation, textReadetat, textReaddescription, textReadphoto, textReadMontant, textReadCodetype);
                hebergement1.SetNum(reader.GetInt32("NOHEB"));
                test.Add(hebergement1);
            }
            return test;
        }
        public List<Hebergement> RechercheFiltrenbplace(int nbplace)
        {
            SeConnecter();
            string query = "SELECT * FROM hebergement WHERE NBPLACEHEB>=" + nbplace + "";
            MySqlCommand cmd = new MySqlCommand(query, cnn);
            MySqlDataReader reader = cmd.ExecuteReader();
            List<Hebergement> test = new List<Hebergement>();
            while (reader.Read())
            {
                string textReadNom = reader["NOMHEB"].ToString();
                string textReadCodetype = reader["CODETYPEHEB"].ToString();
                int textReadnbplace = reader.GetInt16("NBPLACEHEB");
                int textReadsurface = reader.GetInt16("NBPLACEHEB");
                string textReadsecteur = reader["SECTEURHEB"].ToString();
                bool textReadInternet = reader.GetBoolean("internet");
                int textReadMontant = reader.GetInt16("TARIFSEMHEB");
                int textReadanneremise = reader.GetInt16("ANNEEHEB");
                string textReadorientation = reader["ORIENTATIONHEB"].ToString();
                string textReadetat = reader["ETATHEB"].ToString();
                string textReaddescription = reader["DESCRIHEB"].ToString();
                string textReadphoto = reader["PHOTOHEB"].ToString();
                Hebergement hebergement1 = new Hebergement(textReadNom, textReadnbplace, textReadsurface, textReadInternet, textReadanneremise, textReadsecteur, textReadorientation, textReadetat, textReaddescription, textReadphoto, textReadMontant, textReadCodetype);
                hebergement1.SetNum(reader.GetInt32("NOHEB"));
                test.Add(hebergement1);
            }
            return test;
        }
        public List<Hebergement> RechercheFiltrenbplacesecteur(int nbplace, string secteur)
        {
            SeConnecter();
            string query = "SELECT * FROM hebergement WHERE NBPLACEHEB>=" + nbplace + " AND SECTEURHEB='" + secteur + "'";
            MySqlCommand cmd = new MySqlCommand(query, cnn);
            MySqlDataReader reader = cmd.ExecuteReader();
            List<Hebergement> test = new List<Hebergement>();
            while (reader.Read())
            {
                string textReadNom = reader["NOMHEB"].ToString();
                string textReadCodetype = reader["CODETYPEHEB"].ToString();
                int textReadnbplace = reader.GetInt16("NBPLACEHEB");
                int textReadsurface = reader.GetInt16("NBPLACEHEB");
                string textReadsecteur = reader["SECTEURHEB"].ToString();
                bool textReadInternet = reader.GetBoolean("internet");
                int textReadMontant = reader.GetInt16("TARIFSEMHEB");
                int textReadanneremise = reader.GetInt16("ANNEEHEB");
                string textReadorientation = reader["ORIENTATIONHEB"].ToString();
                string textReadetat = reader["ETATHEB"].ToString();
                string textReaddescription = reader["DESCRIHEB"].ToString();
                string textReadphoto = reader["PHOTOHEB"].ToString();
                Hebergement hebergement1 = new Hebergement(textReadNom, textReadnbplace, textReadsurface, textReadInternet, textReadanneremise, textReadsecteur, textReadorientation, textReadetat, textReaddescription, textReadphoto, textReadMontant, textReadCodetype);
                hebergement1.SetNum(reader.GetInt32("NOHEB"));
                test.Add(hebergement1);
            }
            return test;
        }
        public List<Hebergement> RechercheFiltrenbplacesecteurinternet(int nbplace, string secteur, bool internet)
        {
            SeConnecter();
            string query = "SELECT * FROM hebergement WHERE NBPLACEHEB>=" + nbplace + " AND SECTEURHEB='" + secteur + "' AND INTERNET=" + internet + "";
            MySqlCommand cmd = new MySqlCommand(query, cnn);
            MySqlDataReader reader = cmd.ExecuteReader();
            List<Hebergement> test = new List<Hebergement>();
            while (reader.Read())
            {
                string textReadNom = reader["NOMHEB"].ToString();
                string textReadCodetype = reader["CODETYPEHEB"].ToString();
                int textReadnbplace = reader.GetInt16("NBPLACEHEB");
                int textReadsurface = reader.GetInt16("NBPLACEHEB");
                string textReadsecteur = reader["SECTEURHEB"].ToString();
                bool textReadInternet = reader.GetBoolean("internet");
                int textReadMontant = reader.GetInt16("TARIFSEMHEB");
                int textReadanneremise = reader.GetInt16("ANNEEHEB");
                string textReadorientation = reader["ORIENTATIONHEB"].ToString();
                string textReadetat = reader["ETATHEB"].ToString();
                string textReaddescription = reader["DESCRIHEB"].ToString();
                string textReadphoto = reader["PHOTOHEB"].ToString();
                Hebergement hebergement1 = new Hebergement(textReadNom, textReadnbplace, textReadsurface, textReadInternet, textReadanneremise, textReadsecteur, textReadorientation, textReadetat, textReaddescription, textReadphoto, textReadMontant, textReadCodetype);
                hebergement1.SetNum(reader.GetInt32("NOHEB"));
                test.Add(hebergement1);
            }
            return test;
        }
        public List<Hebergement> RechercheFiltrenbplaceprix(int prixmaximun, int nbplace)
        {
            SeConnecter();
            string query = "SELECT * FROM hebergement WHERE NBPLACEHEB>=" + nbplace + " AND TARIFSEMHEB<=" + prixmaximun + "";
            MySqlCommand cmd = new MySqlCommand(query, cnn);
            MySqlDataReader reader = cmd.ExecuteReader();
            List<Hebergement> test = new List<Hebergement>();
            while (reader.Read())
            {
                string textReadNom = reader["NOMHEB"].ToString();
                string textReadCodetype = reader["CODETYPEHEB"].ToString();
                int textReadnbplace = reader.GetInt16("NBPLACEHEB");
                int textReadsurface = reader.GetInt16("NBPLACEHEB");
                string textReadsecteur = reader["SECTEURHEB"].ToString();
                bool textReadInternet = reader.GetBoolean("internet");
                int textReadMontant = reader.GetInt16("TARIFSEMHEB");
                int textReadanneremise = reader.GetInt16("ANNEEHEB");
                string textReadorientation = reader["ORIENTATIONHEB"].ToString();
                string textReadetat = reader["ETATHEB"].ToString();
                string textReaddescription = reader["DESCRIHEB"].ToString();
                string textReadphoto = reader["PHOTOHEB"].ToString();
                Hebergement hebergement1 = new Hebergement(textReadNom, textReadnbplace, textReadsurface, textReadInternet, textReadanneremise, textReadsecteur, textReadorientation, textReadetat, textReaddescription, textReadphoto, textReadMontant, textReadCodetype);
                hebergement1.SetNum(reader.GetInt32("NOHEB"));
                test.Add(hebergement1);
            }
            return test;
        }
        public List<Hebergement> RechercheFiltresecteur(string secteur)
        {
            SeConnecter();
            string query = "SELECT * FROM hebergement WHERE SECTEURHEB='" + secteur + "'";
            MySqlCommand cmd = new MySqlCommand(query, cnn);
            MySqlDataReader reader = cmd.ExecuteReader();
            List<Hebergement> test = new List<Hebergement>();
            while (reader.Read())
            {
                string textReadNom = reader["NOMHEB"].ToString();
                string textReadCodetype = reader["CODETYPEHEB"].ToString();
                int textReadnbplace = reader.GetInt16("NBPLACEHEB");
                int textReadsurface = reader.GetInt16("NBPLACEHEB");
                string textReadsecteur = reader["SECTEURHEB"].ToString();
                bool textReadInternet = reader.GetBoolean("internet");
                int textReadMontant = reader.GetInt16("TARIFSEMHEB");
                int textReadanneremise = reader.GetInt16("ANNEEHEB");
                string textReadorientation = reader["ORIENTATIONHEB"].ToString();
                string textReadetat = reader["ETATHEB"].ToString();
                string textReaddescription = reader["DESCRIHEB"].ToString();
                string textReadphoto = reader["PHOTOHEB"].ToString();
                Hebergement hebergement1 = new Hebergement(textReadNom, textReadnbplace, textReadsurface, textReadInternet, textReadanneremise, textReadsecteur, textReadorientation, textReadetat, textReaddescription, textReadphoto, textReadMontant, textReadCodetype);
                hebergement1.SetNum(reader.GetInt32("NOHEB"));
                test.Add(hebergement1);
            }
            return test;
        }
        public List<Hebergement> RechercheFiltresecteurprix(string secteur, int prixmaximun)
        {
            SeConnecter();
            string query = "SELECT * FROM hebergement WHERE SECTEURHEB='" + secteur + "' AND TARIFSEMHEB<=" + prixmaximun + "";
            MySqlCommand cmd = new MySqlCommand(query, cnn);
            MySqlDataReader reader = cmd.ExecuteReader();
            List<Hebergement> test = new List<Hebergement>();
            while (reader.Read())
            {
                string textReadNom = reader["NOMHEB"].ToString();
                string textReadCodetype = reader["CODETYPEHEB"].ToString();
                int textReadnbplace = reader.GetInt16("NBPLACEHEB");
                int textReadsurface = reader.GetInt16("NBPLACEHEB");
                string textReadsecteur = reader["SECTEURHEB"].ToString();
                bool textReadInternet = reader.GetBoolean("internet");
                int textReadMontant = reader.GetInt16("TARIFSEMHEB");
                int textReadanneremise = reader.GetInt16("ANNEEHEB");
                string textReadorientation = reader["ORIENTATIONHEB"].ToString();
                string textReadetat = reader["ETATHEB"].ToString();
                string textReaddescription = reader["DESCRIHEB"].ToString();
                string textReadphoto = reader["PHOTOHEB"].ToString();
                Hebergement hebergement1 = new Hebergement(textReadNom, textReadnbplace, textReadsurface, textReadInternet, textReadanneremise, textReadsecteur, textReadorientation, textReadetat, textReaddescription, textReadphoto, textReadMontant, textReadCodetype);
                hebergement1.SetNum(reader.GetInt32("NOHEB"));
                test.Add(hebergement1);
            }
            return test;
        }
        public List<Hebergement> RechercheFiltresecteursurface(string secteur, int surface)
        {
            SeConnecter();
            string query = "SELECT * FROM hebergement WHERE SECTEURHEB='" + secteur + "' AND SURFACEHEB>=" + surface + "";
            MySqlCommand cmd = new MySqlCommand(query, cnn);
            MySqlDataReader reader = cmd.ExecuteReader();
            List<Hebergement> test = new List<Hebergement>();
            while (reader.Read())
            {
                string textReadNom = reader["NOMHEB"].ToString();
                string textReadCodetype = reader["CODETYPEHEB"].ToString();
                int textReadnbplace = reader.GetInt16("NBPLACEHEB");
                int textReadsurface = reader.GetInt16("NBPLACEHEB");
                string textReadsecteur = reader["SECTEURHEB"].ToString();
                bool textReadInternet = reader.GetBoolean("internet");
                int textReadMontant = reader.GetInt16("TARIFSEMHEB");
                int textReadanneremise = reader.GetInt16("ANNEEHEB");
                string textReadorientation = reader["ORIENTATIONHEB"].ToString();
                string textReadetat = reader["ETATHEB"].ToString();
                string textReaddescription = reader["DESCRIHEB"].ToString();
                string textReadphoto = reader["PHOTOHEB"].ToString();
                Hebergement hebergement1 = new Hebergement(textReadNom, textReadnbplace, textReadsurface, textReadInternet, textReadanneremise, textReadsecteur, textReadorientation, textReadetat, textReaddescription, textReadphoto, textReadMontant, textReadCodetype);
                hebergement1.SetNum(reader.GetInt32("NOHEB"));
                test.Add(hebergement1);
            }
            return test;
        }
        public List<Hebergement> RechercheFiltresecteurinternet(string secteur, bool internet)
        {
            SeConnecter();
            string query = "SELECT * FROM hebergement WHERE SECTEURHEB='" + secteur + "' AND INTERNET=" + internet + "";
            MySqlCommand cmd = new MySqlCommand(query, cnn);
            MySqlDataReader reader = cmd.ExecuteReader();
            List<Hebergement> test = new List<Hebergement>();
            while (reader.Read())
            {
                string textReadNom = reader["NOMHEB"].ToString();
                string textReadCodetype = reader["CODETYPEHEB"].ToString();
                int textReadnbplace = reader.GetInt16("NBPLACEHEB");
                int textReadsurface = reader.GetInt16("NBPLACEHEB");
                string textReadsecteur = reader["SECTEURHEB"].ToString();
                bool textReadInternet = reader.GetBoolean("internet");
                int textReadMontant = reader.GetInt16("TARIFSEMHEB");
                int textReadanneremise = reader.GetInt16("ANNEEHEB");
                string textReadorientation = reader["ORIENTATIONHEB"].ToString();
                string textReadetat = reader["ETATHEB"].ToString();
                string textReaddescription = reader["DESCRIHEB"].ToString();
                string textReadphoto = reader["PHOTOHEB"].ToString();
                Hebergement hebergement1 = new Hebergement(textReadNom, textReadnbplace, textReadsurface, textReadInternet, textReadanneremise, textReadsecteur, textReadorientation, textReadetat, textReaddescription, textReadphoto, textReadMontant, textReadCodetype);
                hebergement1.SetNum(reader.GetInt32("NOHEB"));
                test.Add(hebergement1);
            }
            return test;
        }
        public List<Hebergement> RechercheFiltreinternet(bool internet)
        {
            SeConnecter();
            string query = "SELECT * FROM hebergement WHERE INTERNET=" + internet + "";
            MySqlCommand cmd = new MySqlCommand(query, cnn);
            MySqlDataReader reader = cmd.ExecuteReader();
            List<Hebergement> test = new List<Hebergement>();
            while (reader.Read())
            {
                string textReadNom = reader["NOMHEB"].ToString();
                string textReadCodetype = reader["CODETYPEHEB"].ToString();
                int textReadnbplace = reader.GetInt16("NBPLACEHEB");
                int textReadsurface = reader.GetInt16("NBPLACEHEB");
                string textReadsecteur = reader["SECTEURHEB"].ToString();
                bool textReadInternet = reader.GetBoolean("internet");
                int textReadMontant = reader.GetInt16("TARIFSEMHEB");
                int textReadanneremise = reader.GetInt16("ANNEEHEB");
                string textReadorientation = reader["ORIENTATIONHEB"].ToString();
                string textReadetat = reader["ETATHEB"].ToString();
                string textReaddescription = reader["DESCRIHEB"].ToString();
                string textReadphoto = reader["PHOTOHEB"].ToString();
                Hebergement hebergement1 = new Hebergement(textReadNom, textReadnbplace, textReadsurface, textReadInternet, textReadanneremise, textReadsecteur, textReadorientation, textReadetat, textReaddescription, textReadphoto, textReadMontant, textReadCodetype);
                hebergement1.SetNum(reader.GetInt32("NOHEB"));
                test.Add(hebergement1);
            }
            return test;
        }
        public List<Hebergement> RechercheFiltreinternetsurface(bool internet, int surface)
        {
            SeConnecter();
            string query = "SELECT * FROM hebergement WHERE INTERNET=" + internet + " AND SURFACEHEB>=" + surface + "";
            MySqlCommand cmd = new MySqlCommand(query, cnn);
            MySqlDataReader reader = cmd.ExecuteReader();
            List<Hebergement> test = new List<Hebergement>();
            while (reader.Read())
            {
                string textReadNom = reader["NOMHEB"].ToString();
                string textReadCodetype = reader["CODETYPEHEB"].ToString();
                int textReadnbplace = reader.GetInt16("NBPLACEHEB");
                int textReadsurface = reader.GetInt16("NBPLACEHEB");
                string textReadsecteur = reader["SECTEURHEB"].ToString();
                bool textReadInternet = reader.GetBoolean("internet");
                int textReadMontant = reader.GetInt16("TARIFSEMHEB");
                int textReadanneremise = reader.GetInt16("ANNEEHEB");
                string textReadorientation = reader["ORIENTATIONHEB"].ToString();
                string textReadetat = reader["ETATHEB"].ToString();
                string textReaddescription = reader["DESCRIHEB"].ToString();
                string textReadphoto = reader["PHOTOHEB"].ToString();
                Hebergement hebergement1 = new Hebergement(textReadNom, textReadnbplace, textReadsurface, textReadInternet, textReadanneremise, textReadsecteur, textReadorientation, textReadetat, textReaddescription, textReadphoto, textReadMontant, textReadCodetype);
                hebergement1.SetNum(reader.GetInt32("NOHEB"));
                test.Add(hebergement1);
            }
            return test;
        }
        public List<Hebergement> RechercheFiltreinternetnbplace(bool internet, int nbplace)
        {
            SeConnecter();
            string query = "SELECT * FROM hebergement WHERE INTERNET=" + internet + " AND NBPLACEHEB>=" + nbplace + "";
            MySqlCommand cmd = new MySqlCommand(query, cnn);
            MySqlDataReader reader = cmd.ExecuteReader();
            List<Hebergement> test = new List<Hebergement>();
            while (reader.Read())
            {
                string textReadNom = reader["NOMHEB"].ToString();
                string textReadCodetype = reader["CODETYPEHEB"].ToString();
                int textReadnbplace = reader.GetInt16("NBPLACEHEB");
                int textReadsurface = reader.GetInt16("NBPLACEHEB");
                string textReadsecteur = reader["SECTEURHEB"].ToString();
                bool textReadInternet = reader.GetBoolean("internet");
                int textReadMontant = reader.GetInt16("TARIFSEMHEB");
                int textReadanneremise = reader.GetInt16("ANNEEHEB");
                string textReadorientation = reader["ORIENTATIONHEB"].ToString();
                string textReadetat = reader["ETATHEB"].ToString();
                string textReaddescription = reader["DESCRIHEB"].ToString();
                string textReadphoto = reader["PHOTOHEB"].ToString();
                Hebergement hebergement1 = new Hebergement(textReadNom, textReadnbplace, textReadsurface, textReadInternet, textReadanneremise, textReadsecteur, textReadorientation, textReadetat, textReaddescription, textReadphoto, textReadMontant, textReadCodetype);
                hebergement1.SetNum(reader.GetInt32("NOHEB"));
                test.Add(hebergement1);
            }
            return test;
        }
        public List<Hebergement> RechercheFiltreinternetprix(bool internet, int prixmax)
        {
            SeConnecter();
            string query = "SELECT * FROM hebergement WHERE INTERNET=" + internet + " AND TARIFSEMHEB<=" + prixmax + ""; ;
            MySqlCommand cmd = new MySqlCommand(query, cnn);
            MySqlDataReader reader = cmd.ExecuteReader();
            List<Hebergement> test = new List<Hebergement>();
            while (reader.Read())
            {
                string textReadNom = reader["NOMHEB"].ToString();
                string textReadCodetype = reader["CODETYPEHEB"].ToString();
                int textReadnbplace = reader.GetInt16("NBPLACEHEB");
                int textReadsurface = reader.GetInt16("NBPLACEHEB");
                string textReadsecteur = reader["SECTEURHEB"].ToString();
                bool textReadInternet = reader.GetBoolean("internet");
                int textReadMontant = reader.GetInt16("TARIFSEMHEB");
                int textReadanneremise = reader.GetInt16("ANNEEHEB");
                string textReadorientation = reader["ORIENTATIONHEB"].ToString();
                string textReadetat = reader["ETATHEB"].ToString();
                string textReaddescription = reader["DESCRIHEB"].ToString();
                string textReadphoto = reader["PHOTOHEB"].ToString();
                Hebergement hebergement1 = new Hebergement(textReadNom, textReadnbplace, textReadsurface, textReadInternet, textReadanneremise, textReadsecteur, textReadorientation, textReadetat, textReaddescription, textReadphoto, textReadMontant, textReadCodetype);
                hebergement1.SetNum(reader.GetInt32("NOHEB"));
                test.Add(hebergement1);
            }
            return test;
        }
        public List<Hebergement> RechercheFiltreinternetprixnbplace(bool internet, int prixmax, int nbplace)
        {
            SeConnecter();
            string query = "SELECT * FROM hebergement WHERE INTERNET=" + internet + " AND TARIFSEMHEB<=" + prixmax + " AND  NBPLACEHEB>=" + nbplace + "";
            MySqlCommand cmd = new MySqlCommand(query, cnn);
            MySqlDataReader reader = cmd.ExecuteReader();
            List<Hebergement> test = new List<Hebergement>();
            while (reader.Read())
            {
                string textReadNom = reader["NOMHEB"].ToString();
                string textReadCodetype = reader["CODETYPEHEB"].ToString();
                int textReadnbplace = reader.GetInt16("NBPLACEHEB");
                int textReadsurface = reader.GetInt16("NBPLACEHEB");
                string textReadsecteur = reader["SECTEURHEB"].ToString();
                bool textReadInternet = reader.GetBoolean("internet");
                int textReadMontant = reader.GetInt16("TARIFSEMHEB");
                int textReadanneremise = reader.GetInt16("ANNEEHEB");
                string textReadorientation = reader["ORIENTATIONHEB"].ToString();
                string textReadetat = reader["ETATHEB"].ToString();
                string textReaddescription = reader["DESCRIHEB"].ToString();
                string textReadphoto = reader["PHOTOHEB"].ToString();
                Hebergement hebergement1 = new Hebergement(textReadNom, textReadnbplace, textReadsurface, textReadInternet, textReadanneremise, textReadsecteur, textReadorientation, textReadetat, textReaddescription, textReadphoto, textReadMontant, textReadCodetype);
                hebergement1.SetNum(reader.GetInt32("NOHEB"));
                test.Add(hebergement1);
            }
            return test;
        }
        public List<Hebergement> RechercheFiltreprixnbplacesecteur(int prixmax, int nbplace, string secteur)
        {
            SeConnecter();
            string query = "SELECT * FROM hebergement WHERE TARIFSEMHEB<=" + prixmax + " AND  NBPLACEHEB>=" + nbplace + " AND SECTEURHEB='" + secteur + "'";
            MySqlCommand cmd = new MySqlCommand(query, cnn);
            MySqlDataReader reader = cmd.ExecuteReader();
            List<Hebergement> test = new List<Hebergement>();
            while (reader.Read())
            {
                string textReadNom = reader["NOMHEB"].ToString();
                string textReadCodetype = reader["CODETYPEHEB"].ToString();
                int textReadnbplace = reader.GetInt16("NBPLACEHEB");
                int textReadsurface = reader.GetInt16("NBPLACEHEB");
                string textReadsecteur = reader["SECTEURHEB"].ToString();
                bool textReadInternet = reader.GetBoolean("internet");
                int textReadMontant = reader.GetInt16("TARIFSEMHEB");
                int textReadanneremise = reader.GetInt16("ANNEEHEB");
                string textReadorientation = reader["ORIENTATIONHEB"].ToString();
                string textReadetat = reader["ETATHEB"].ToString();
                string textReaddescription = reader["DESCRIHEB"].ToString();
                string textReadphoto = reader["PHOTOHEB"].ToString();
                Hebergement hebergement1 = new Hebergement(textReadNom, textReadnbplace, textReadsurface, textReadInternet, textReadanneremise, textReadsecteur, textReadorientation, textReadetat, textReaddescription, textReadphoto, textReadMontant, textReadCodetype);
                hebergement1.SetNum(reader.GetInt32("NOHEB"));
                test.Add(hebergement1);
            }
            return test;
        }
        public List<Hebergement> RechercheFiltrenbplaceinternetsurface(int nbplace, bool internet, int surface)
        {
            SeConnecter();
            string query = "SELECT * FROM hebergement WHERE NBPLACEHEB>=" + nbplace + " AND  INTERNET=" + internet + " AND SURFACEHEB>=" + surface + "";
            MySqlCommand cmd = new MySqlCommand(query, cnn);
            MySqlDataReader reader = cmd.ExecuteReader();
            List<Hebergement> test = new List<Hebergement>();
            while (reader.Read())
            {
                string textReadNom = reader["NOMHEB"].ToString();
                string textReadCodetype = reader["CODETYPEHEB"].ToString();
                int textReadnbplace = reader.GetInt16("NBPLACEHEB");
                int textReadsurface = reader.GetInt16("NBPLACEHEB");
                string textReadsecteur = reader["SECTEURHEB"].ToString();
                bool textReadInternet = reader.GetBoolean("internet");
                int textReadMontant = reader.GetInt16("TARIFSEMHEB");
                int textReadanneremise = reader.GetInt16("ANNEEHEB");
                string textReadorientation = reader["ORIENTATIONHEB"].ToString();
                string textReadetat = reader["ETATHEB"].ToString();
                string textReaddescription = reader["DESCRIHEB"].ToString();
                string textReadphoto = reader["PHOTOHEB"].ToString();
                Hebergement hebergement1 = new Hebergement(textReadNom, textReadnbplace, textReadsurface, textReadInternet, textReadanneremise, textReadsecteur, textReadorientation, textReadetat, textReaddescription, textReadphoto, textReadMontant, textReadCodetype);
                hebergement1.SetNum(reader.GetInt32("NOHEB"));
                test.Add(hebergement1);
            }
            return test;
        }
        public List<Hebergement> RechercheFiltreinternetsecteursurface(bool internet, string secteur, int surface)
        {
            SeConnecter();
            string query = "SELECT * FROM hebergement WHERE SURFACEHEB>=" + surface + " AND  INTERNET=" + internet + " AND SECTEURHEB='" + secteur + "'";
            MySqlCommand cmd = new MySqlCommand(query, cnn);
            MySqlDataReader reader = cmd.ExecuteReader();
            List<Hebergement> test = new List<Hebergement>();
            while (reader.Read())
            {
                string textReadNom = reader["NOMHEB"].ToString();
                string textReadCodetype = reader["CODETYPEHEB"].ToString();
                int textReadnbplace = reader.GetInt16("NBPLACEHEB");
                int textReadsurface = reader.GetInt16("NBPLACEHEB");
                string textReadsecteur = reader["SECTEURHEB"].ToString();
                bool textReadInternet = reader.GetBoolean("internet");
                int textReadMontant = reader.GetInt16("TARIFSEMHEB");
                int textReadanneremise = reader.GetInt16("ANNEEHEB");
                string textReadorientation = reader["ORIENTATIONHEB"].ToString();
                string textReadetat = reader["ETATHEB"].ToString();
                string textReaddescription = reader["DESCRIHEB"].ToString();
                string textReadphoto = reader["PHOTOHEB"].ToString();
                Hebergement hebergement1 = new Hebergement(textReadNom, textReadnbplace, textReadsurface, textReadInternet, textReadanneremise, textReadsecteur, textReadorientation, textReadetat, textReaddescription, textReadphoto, textReadMontant, textReadCodetype);
                hebergement1.SetNum(reader.GetInt32("NOHEB"));
                test.Add(hebergement1);
            }
            return test;
        }
        public List<Hebergement> RechercheFiltreprixsecteursurface(int prixmax, string secteur, int surface)
        {
            SeConnecter();
            string query = "SELECT * FROM hebergement WHERE SURFACEHEB>=" + surface + " AND  TARIFSEMHEB<=" + prixmax + " AND SECTEURHEB='" + secteur + "'";
            MySqlCommand cmd = new MySqlCommand(query, cnn);
            MySqlDataReader reader = cmd.ExecuteReader();
            List<Hebergement> test = new List<Hebergement>();
            while (reader.Read())
            {
                string textReadNom = reader["NOMHEB"].ToString();
                string textReadCodetype = reader["CODETYPEHEB"].ToString();
                int textReadnbplace = reader.GetInt16("NBPLACEHEB");
                int textReadsurface = reader.GetInt16("NBPLACEHEB");
                string textReadsecteur = reader["SECTEURHEB"].ToString();
                bool textReadInternet = reader.GetBoolean("internet");
                int textReadMontant = reader.GetInt16("TARIFSEMHEB");
                int textReadanneremise = reader.GetInt16("ANNEEHEB");
                string textReadorientation = reader["ORIENTATIONHEB"].ToString();
                string textReadetat = reader["ETATHEB"].ToString();
                string textReaddescription = reader["DESCRIHEB"].ToString();
                string textReadphoto = reader["PHOTOHEB"].ToString();
                Hebergement hebergement1 = new Hebergement(textReadNom, textReadnbplace, textReadsurface, textReadInternet, textReadanneremise, textReadsecteur, textReadorientation, textReadetat, textReaddescription, textReadphoto, textReadMontant, textReadCodetype);
                test.Add(hebergement1);
            }
            return test;
        }
        public List<Hebergement> RechercheFiltretype(string code)
        {
            SeConnecter();
            string query = "SELECT * FROM hebergement WHERE CODETYPEHEB='" + code + "'";
            MySqlCommand cmd = new MySqlCommand(query, cnn);
            MySqlDataReader reader = cmd.ExecuteReader();
            List<Hebergement> test = new List<Hebergement>();
            while (reader.Read())
            {
                string textReadNom = reader["NOMHEB"].ToString();
                string textReadCodetype = reader["CODETYPEHEB"].ToString();
                int textReadnbplace = reader.GetInt16("NBPLACEHEB");
                int textReadsurface = reader.GetInt16("NBPLACEHEB");
                string textReadsecteur = reader["SECTEURHEB"].ToString();
                bool textReadInternet = reader.GetBoolean("internet");
                int textReadMontant = reader.GetInt16("TARIFSEMHEB");
                int textReadanneremise = reader.GetInt16("ANNEEHEB");
                string textReadorientation = reader["ORIENTATIONHEB"].ToString();
                string textReadetat = reader["ETATHEB"].ToString();
                string textReaddescription = reader["DESCRIHEB"].ToString();
                string textReadphoto = reader["PHOTOHEB"].ToString();
                Hebergement hebergement1 = new Hebergement(textReadNom, textReadnbplace, textReadsurface, textReadInternet, textReadanneremise, textReadsecteur, textReadorientation, textReadetat, textReaddescription, textReadphoto, textReadMontant, textReadCodetype);
                hebergement1.SetNum(reader.GetInt32("NOHEB"));
                test.Add(hebergement1);
            }
            return test;
        }
        public Compte Utilisateur(string utilisateur, string mdp)
        {
            SeConnecter();
            string query = "SELECT * FROM compte WHERE NOMCPTE ='" + utilisateur + "' AND MDP ='" + mdp + "'";
            MySqlCommand cmd = new MySqlCommand(query, cnn);
            cmd.ExecuteNonQuery();
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                Compte compte1 = new Compte(reader["USER"].ToString(), reader["MDP"].ToString(), reader["NOMCPTE"].ToString(), reader["TYPECOMPTE"].ToString());
                return compte1;
            }
            else
            {
                return null;
            }


        }
        public List<Hebergement> RechercheFiltretypesecteur(string code, string secteur)
        {
            SeConnecter();
            string query = "SELECT * FROM hebergement WHERE CODETYPEHEB='" + code + "' AND SECTEURHEB='" + secteur + "'";
            MySqlCommand cmd = new MySqlCommand(query, cnn);
            MySqlDataReader reader = cmd.ExecuteReader();
            List<Hebergement> test = new List<Hebergement>();
            while (reader.Read())
            {
                string textReadNom = reader["NOMHEB"].ToString();
                string textReadCodetype = reader["CODETYPEHEB"].ToString();
                int textReadnbplace = reader.GetInt16("NBPLACEHEB");
                int textReadsurface = reader.GetInt16("NBPLACEHEB");
                string textReadsecteur = reader["SECTEURHEB"].ToString();
                bool textReadInternet = reader.GetBoolean("internet");
                int textReadMontant = reader.GetInt16("TARIFSEMHEB");
                int textReadanneremise = reader.GetInt16("ANNEEHEB");
                string textReadorientation = reader["ORIENTATIONHEB"].ToString();
                string textReadetat = reader["ETATHEB"].ToString();
                string textReaddescription = reader["DESCRIHEB"].ToString();
                string textReadphoto = reader["PHOTOHEB"].ToString();
                Hebergement hebergement1 = new Hebergement(textReadNom, textReadnbplace, textReadsurface, textReadInternet, textReadanneremise, textReadsecteur, textReadorientation, textReadetat, textReaddescription, textReadphoto, textReadMontant, textReadCodetype);
                hebergement1.SetNum(reader.GetInt32("NOHEB"));
                test.Add(hebergement1);
            }
            return test;
        }
        public void ModifierHebergement(string nomheb, string nbplace, string surfaceheb, bool internet, string annee, string secteur, string orientation, string description, string type, string montant)
        {
            SeConnecter();
            string query = "UPDATE HEBERGEMENT SET TARIFSEMHEB='" + montant + "',SECTEURHEB='" + secteur + "',CODETYPEHEB='" + type + "',ANNEEHEB='" + annee + "',NBPLACEHEB='" + nbplace + "',	SURFACEHEB='" + surfaceheb + "',INTERNET=" + internet + ",ORIENTATIONHEB='" + orientation + "',DESCRIHEB='" + description + "'WHERE NOMHEB='" + nomheb + "'";
            MySqlCommand cmd = new MySqlCommand(query, cnn);
            cmd.ExecuteNonQuery();
        }
        public List<DateTime> HebergementReserver(Hebergement hebergement1)
        {
            SeConnecter();
            string query = "SELECT DATEDEBSEM FROM SEMAINE WHERE DATEDEBSEM NOT IN(SELECT DATEDEBSEM FROM hebergement,resa WHERE hebergement.NOHEB = resa.NOHEB AND hebergement.NOHEB ='" + hebergement1.GetNum() + "')AND DATEDEBSEM >=Now()";
            MySqlCommand cmd = new MySqlCommand(query, cnn);
            MySqlDataReader reader = cmd.ExecuteReader();
            List<DateTime> test = new List<DateTime>();
            while (reader.Read())
            {
                DateTime textReaddescription = reader.GetDateTime("DATEDEBSEM");
                test.Add(textReaddescription);
            }
            return test;

        }
        public bool Reserver(string debutsemaine, Hebergement hebergement1, int nboccupant)
        {
            SeConnecter();

            string query = "INSERT INTO RESA(USER,DATEDEBSEM,NOHEB,DATERESA,NBOCCUPANT,TARIFSEMRESA,MONTANTARRHES,DATEARRHES,CODEETATRESA) VALUES ('1','" + debutsemaine + "'," + hebergement1.GetNum() + ",NOW()," + nboccupant + "," + hebergement1.GetMontant() + ",100,NOW(),'1')";
            MySqlCommand cmd = new MySqlCommand(query, cnn);
            cmd.ExecuteNonQuery();
            if (cmd.CommandText.Count() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }


        }
        public string AfficherReservation(string datesemaine, Hebergement hebergement1)
        {
            SeConnecter();
            string query = "SELECT NORESA FROM resa WHERE DATEDEBSEM='" + datesemaine + "' AND NOHEB=" + hebergement1.GetNum() + "";
            MySqlCommand cmd = new MySqlCommand(query, cnn);
            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                string num = reader["NORESA"].ToString();
                return num;
            }
            else
            {
                return null;
            }
        }
        public List<Reservation> AfficherListeReservation(string date)
        {
            SeConnecter();
            string query = "SELECT * FROM resa where DATEDEBSEM='" + date + "'";
            MySqlCommand cmd = new MySqlCommand(query, cnn);
            MySqlDataReader reader = cmd.ExecuteReader();
            List<Reservation> LesReservation = new List<Reservation>();
            while (reader.Read())
            {
                int montant = reader.GetInt32("TARIFSEMRESA");
                int NBOCCUPANT = reader.GetInt32("NBOCCUPANT");
                string etat = reader["CODEETATRESA"].ToString();
                string compte = reader["USER"].ToString();
                string NOHEB = reader["NOHEB"].ToString();
                int montantarret = reader.GetInt32("MONTANTARRHES");
                string Noresa = reader["NORESA"].ToString();
                DateTime dateresa = reader.GetDateTime("DATERESA");
                DateTime datearret = reader.GetDateTime("DATEARRHES");
                DateTime debsemaine = reader.GetDateTime("DATEDEBSEM");
                Reservation Reservation1 = new Reservation(montant, NBOCCUPANT, etat, compte, NOHEB, montantarret, Noresa, dateresa, datearret, debsemaine);
                LesReservation.Add(Reservation1);
            }
            return LesReservation;
        }
        public string EtatReserv(string etat)
        {
            SeConnecter();
            string query = "SELECT NOMETATRESA FROM etat_resa WHERE CODEETATRESA='" + etat + "'";
            MySqlCommand cmd = new MySqlCommand(query, cnn);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                string nometat = reader["NOMETATRESA"].ToString();
                return nometat;
            }
            else
            {
                return null;
            }
        }
        public List<Reservation> AfficherListeResaHeberg(string code)
        {
            SeConnecter();
            string query = "SELECT * FROM resa where NOHEB='" + code + "'";
            MySqlCommand cmd = new MySqlCommand(query, cnn);
            MySqlDataReader reader = cmd.ExecuteReader();
            List<Reservation> LesReservation = new List<Reservation>();
            while (reader.Read())
            {
                int montant = reader.GetInt32("TARIFSEMRESA");
                int NBOCCUPANT = reader.GetInt32("NBOCCUPANT");
                string etat = reader["CODEETATRESA"].ToString();
                string compte = reader["USER"].ToString();
                string NOHEB = reader["NOHEB"].ToString();
                int montantarret = reader.GetInt32("MONTANTARRHES");
                string Noresa = reader["NORESA"].ToString();
                DateTime dateresa = reader.GetDateTime("DATERESA");
                DateTime datearret = reader.GetDateTime("DATEARRHES");
                DateTime debsemaine = reader.GetDateTime("DATEDEBSEM");
                Reservation Reservation1 = new Reservation(montant, NBOCCUPANT, etat, compte, NOHEB, montantarret, Noresa, dateresa, datearret, debsemaine);
                LesReservation.Add(Reservation1);
            }
            return LesReservation;
        }
        public string CodeHeberg(string nom)
        {
            SeConnecter();
            string query = "SELECT CODETYPEHEB FROM hebergement where NOMHEB='" + nom + "'";
            MySqlCommand cmd = new MySqlCommand(query, cnn);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                string code = reader["CODETYPEHEB"].ToString();
                return code;
            }
            else
            {
                return null;
            }
        }
        public List<Reservation> AfficherListeResaHebergDate(string code, string date)
        {
            SeConnecter();
            string query = "SELECT * FROM resa where NOHEB='" + code + "'AND DATEDEBSEM='" + date + "'";
            MySqlCommand cmd = new MySqlCommand(query, cnn);
            MySqlDataReader reader = cmd.ExecuteReader();
            List<Reservation> LesReservation = new List<Reservation>();
            while (reader.Read())
            {
                int montant = reader.GetInt32("TARIFSEMRESA");
                int NBOCCUPANT = reader.GetInt32("NBOCCUPANT");
                string etat = reader["CODEETATRESA"].ToString();
                string compte = reader["USER"].ToString();
                string NOHEB = reader["NOHEB"].ToString();
                int montantarret = reader.GetInt32("MONTANTARRHES");
                string Noresa = reader["NORESA"].ToString();
                DateTime dateresa = reader.GetDateTime("DATERESA");
                DateTime datearret = reader.GetDateTime("DATEARRHES");
                DateTime debsemaine = reader.GetDateTime("DATEDEBSEM");
                Reservation Reservation1 = new Reservation(montant, NBOCCUPANT, etat, compte, NOHEB, montantarret, Noresa, dateresa, datearret, debsemaine);
                LesReservation.Add(Reservation1);
            }
            return LesReservation;

        }
        public List<string> AfficherListeEtat()
        {
            SeConnecter();
            string query = "SELECT NOMETATRESA FROM etat_resa";
            MySqlCommand cmd = new MySqlCommand(query, cnn);
            MySqlDataReader reader = cmd.ExecuteReader();
            List<string> listeEtat = new List<string>();
            while (reader.Read())
            {
                string nometat = reader["NOMETATRESA"].ToString();
                listeEtat.Add(nometat);
            }
            return listeEtat;
        }
        public bool ModifierEtape(string code, string noresa)
        {
            SeConnecter();
            string query = "UPDATE resa SET CODEETATRESA='" + code + "'WHERE NORESA='" + noresa + "'";
            MySqlCommand cmd = new MySqlCommand(query, cnn);
            cmd.ExecuteNonQuery();
            if (cmd.CommandText.Count() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public string CodeEtatReserv(string etat)
        {
            SeConnecter();
            string query = "SELECT CODEETATRESA FROM etat_resa WHERE NOMETATRESA='" + etat + "'";
            MySqlCommand cmd = new MySqlCommand(query, cnn);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                string nometat = reader["CODEETATRESA"].ToString();
                return nometat;
            }
            else
            {
                return null;
            }
        }
        public List<Compte> AfficherListeCompte()
        {
            SeConnecter();
            string query = "SELECT * FROM compte";
            MySqlCommand cmd = new MySqlCommand(query, cnn);
            MySqlDataReader reader = cmd.ExecuteReader();
            List<Compte> LesComptes = new List<Compte>();
            while (reader.Read())
            {
                string USER = reader["USER"].ToString();
                string MDP = reader["MDP"].ToString();
                string NOMCPTE = reader["NOMCPTE"].ToString();
                string PRENOMCPTE = reader["PRENOMCPTE"].ToString();
                DateTime DATEINSCRIP = reader.GetDateTime("DATEINSCRIP");
                string TYPECOMPTE = reader["TYPECOMPTE"].ToString();
                string ADRMAILCPTE = reader["ADRMAILCPTE"].ToString();
                string NOTELCPTE = reader["NOTELCPTE"].ToString();
                string NOPORTCPTE = reader["NOPORTCPTE"].ToString();
                Compte c = new Compte(USER, MDP, NOMCPTE, PRENOMCPTE, DATEINSCRIP,TYPECOMPTE, ADRMAILCPTE, NOTELCPTE, NOPORTCPTE);
                LesComptes.Add(c);
            }
            return LesComptes;
        }
    }
}

