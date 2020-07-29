using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESA
{
    public class Semaine
    {
        private DateTime date_debut;
        private DateTime date_fin;
   

        public Semaine(DateTime date_debut)
        {
            this.date_debut = date_debut;
            this.date_fin = date_debut.AddDays(7);
        }
        public Semaine()
        {

        }


        public DateTime GetDateFin()
        {
            return date_fin;
        }
        public DateTime GetDateDebut()
        {
            return date_debut;
        }
        public void SetDateDebut(DateTime date_fin)
        {
            this.date_debut = date_fin;
        }
        public void SetDatefin(DateTime date_fin)
        {
            this.date_debut.AddDays(7);
        }


    }
}
