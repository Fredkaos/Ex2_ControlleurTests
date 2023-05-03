using Microsoft.AspNetCore.Mvc;
using PremierProjetASP.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2Tests.Controllers
{
    public class ControllerShould
    {
        [Fact] // Type de test
        public void NumeroUn() // Methode de test
        {
            // Creer le controlleur
            var homeController = new HomeController();

            // Appeler le methode d'action a tester
            var result = homeController.Numero1();

            // Verifier le type du resultat
            var textResult = Assert.IsType<string>(result);
        }

        [Fact] 
        public void NumeroDeux()
        {
            var homeController = new HomeController();

            var result = homeController.Numero2();

            var textResult = Assert.IsType<ContentResult>(result);
        }

        [Fact]
        public void NumeroTrois()
        {
            var homeController = new HomeController();

            var result = homeController.Numero3();

            var textResult = Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void NumeroQuatre()
        {
            var homeController = new HomeController();

            var result = homeController.Numero4();

            var textResult = Assert.IsAssignableFrom<FileResult>(result);
        }

        [Fact]
        public void NumeroCinq()
        {
            var homeController = new HomeController();

            var result = homeController.Numero5();

            var textResult = Assert.IsType<ContentResult>(result);
        }

        [Fact]
        public void NumeroSix()
        {
            var homeController = new HomeController();

            var result = homeController.Numero6();

            var textResult = Assert.IsType<string>(result);
        }
    }
}
