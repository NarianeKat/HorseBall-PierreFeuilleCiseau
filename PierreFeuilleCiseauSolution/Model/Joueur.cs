using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PierreFeuilleCiseau
{
    public class Joueur
    {
        public int JoueurID { get; set; }
        public string JoueurNom { get; set; }
        public Choix JoueurChoix { get; set; }

        public Joueur()
        {
        }

        public string getJoueur()
        {
            return this.JoueurNom;
        }

        public string setJoueur(string nouveauNom)
        {
            this.JoueurNom = nouveauNom;
            return this.JoueurNom;
        }

        public Choix setChoix(Choix choix)
        {
            Random random = new Random();
            string[] listChoix = { "pierre", "feuille", "ciseau" };

            Choix choixJoueur  = new Choix();
            string result = choixJoueur.SetChoix(listChoix[random.Next(listChoix.Length)]);

            return this.JoueurChoix;
        }


    }
}
