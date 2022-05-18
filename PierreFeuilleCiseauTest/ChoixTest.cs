﻿using Xunit;
using PierreFeuilleCiseau; 
using System.Threading.Tasks;

namespace PierreFeuilleCiseauTest
{
    public class ChoixTest
    {
        [Fact]
        public async Task GetChoixNom_ShouldReturnChoixNom()
        {
            Choix FauxChoix = new Choix()
            {
                ChoixNom = "Puit"
            };

            //act 
            string results = FauxChoix.getChoix();

            //assert
            Assert.Equal(results, FauxChoix.ChoixNom);
        }

        [Fact]
        public async Task SetChoixNom_ShouldReturnChoixNomNouveau()
        {
            Choix FauxChoix = new Choix()
            {
                ChoixNom = "ChoixAChanger"
            };

            //act 
            string results = FauxChoix.setChoix("NouveauChoix");

            //assert
            Assert.Equal(results, "NouveauChoix");
        }

    }
}
