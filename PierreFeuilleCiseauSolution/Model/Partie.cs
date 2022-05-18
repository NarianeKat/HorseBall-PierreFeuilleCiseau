using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PierreFeuilleCiseau
{
    public class Partie
    {
        public int PartieID { get; set; }
        public List<Tour> PartieTour { get; set; }
        public Joueur Joueur1 { get; set; }
        public Joueur Joueur2 { get; set; }
        public Joueur JoueurVictorieux { get; set; }
    }
}
