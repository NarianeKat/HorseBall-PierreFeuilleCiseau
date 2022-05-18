using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PierreFeuilleCiseau
{
    public class Choix
    {
        public string ChoixNom { get; set; }

        public Choix () {
            }

        public string getChoix()
        {
            return this.ChoixNom;
        }

        public string setChoix(string choix)
        {
            this.ChoixNom = choix;
            return this.ChoixNom;
        }
    }
}
