using PierreFeuilleCiseau;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace PierreFeuilleCiseauTest
{
    public class JoueurTest
    {

        [Fact]
        public async Task GetNomJoueur_ShouldReturnNomJoueur()
        {
            Joueur FauxJoueur = new Joueur()
            {
                JoueurNom = "FauxNom"
            };

            //act 
            string results = FauxJoueur.getJoueur();

            //assert
            Assert.Equal(results, FauxJoueur.JoueurNom);
        }
    }
}
