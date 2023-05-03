using Microsoft.AspNetCore.Mvc;
using PremierProjetASP.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2Tests.Controllers
{
    public class WelcomeShould
    {
        [Fact] // Type de test
        public void Default() // Methode de test
        {
            // Creer le controlleur
            var welcomeController = new WelcomeController();

            // Appeler le methode d'action a tester
            var result = welcomeController.WelcomeDefault();

            // Verifier le type du resultat
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Name()
        {
            var welcomeController = new WelcomeController();

            var result = welcomeController.WelcomeName("Fred", "Latreille");

            Assert.IsType<ViewResult>(result);
        }
    }
}
