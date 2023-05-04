using Microsoft.AspNetCore.Mvc;
using PremierProjetASP.Controllers;
using PremierProjetASP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2Tests.Controllers
{
    public class ControllerShould
    {
        [Fact]
        public void ShowTextString()
        {
            var homeController = new HomeController();

            var result = homeController.Numero1();

            var expectedResult = "<h2>Bienvenu dans mon site web</h2>";
            Assert.IsType<string>(result);
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void ReturnContent()
        {
            var homeController = new HomeController();

            var result = homeController.Numero2();

            Assert.IsType<ContentResult>(result);

            var expectedContent = "<h2>Bienvenu dans mon site web</h2>";
            var content = Assert.IsType<string>(result.Content);
            Assert.Equal(expectedContent, content);

            var expectedContentType = "text/html";
            var contentType = Assert.IsType<string>(result.ContentType);
            Assert.Equal(expectedContentType, contentType);
        }

        [Fact]
        public void IndexShouldReturnViewResult()
        {
            var homeController = new HomeController();

            var result = homeController.Numero3();

            Assert.IsType<ViewResult>(result);

        }

        [Fact]
        public void AfficherPdfShouldReturnVirtualFileResult()
        {
            var homeController = new HomeController();

            var result = homeController.Numero4();

            Assert.IsType<VirtualFileResult>(result);

            var expectedFileName = "~/pdf/Chapitre1.pdf";
            Assert.Equal(expectedFileName, result.FileName);

            var expectedContentType = "application/pdf";
            Assert.Equal(expectedContentType, result.ContentType);
        }

        [Fact]
        public void AfficherJsonShouldReturnJsonResult()
        {
            var homeController = new HomeController();

            var result = homeController.Numero5();

            Assert.IsType<JsonResult>(result);

            dynamic valueJson = result.Value;

            Client expectedClient1 = new Client(1, "Dupont", "Jean", "jean.dupont@example.com");
            Client expectedClient2 = new Client(2, "Tremblay", "Marie", "marie.tremblay@example.com");

            var jsonElement1 = valueJson[0];
            var jsonElement2 = valueJson[1];

            Assert.IsType<Client>(jsonElement1);
            Assert.IsType<Client>(jsonElement2);

            Assert.Equal<int>(jsonElement1.Numero, expectedClient1.Numero);
            Assert.Equal(jsonElement1.Nom, expectedClient1.Nom);
            Assert.Equal(jsonElement1.Prenom, expectedClient1.Prenom);
            Assert.Equal(jsonElement1.Courriel, expectedClient1.Courriel);

            Assert.Equal<int>(expectedClient2.Numero, jsonElement2.Numero);
            Assert.Equal(expectedClient2.Nom, jsonElement2.Nom);
            Assert.Equal(expectedClient2.Prenom, jsonElement2.Prenom);
            Assert.Equal(expectedClient2.Courriel, jsonElement2.Courriel);
        }

        [Fact]
        public void RedirigerShouldReturnStringActionResult()
        {
            var homeController = new HomeController();

            var result = homeController.Numero6();
            var viewResult = Assert.IsType<RedirectToActionResult>(result);

            var expectedActionName = "Numero1";
            var actionName = Assert.IsType<string>(viewResult.ActionName);
            Assert.Equal(expectedActionName, actionName);
        }

        /*
        [Fact] // Type de test
        public void NumeroUn() // Methode de test
        {
            // Creer le controlleur
            var homeController = new HomeController();

            // Appeler le methode d'action a tester
            var result = homeController.Numero1();

            // Verifier le type du resultat
            Assert.IsType<string>(result);
        }

        [Fact] 
        public void NumeroDeux()
        {
            var homeController = new HomeController();

            var result = homeController.Numero2();

            Assert.IsType<ContentResult>(result);
        }

        [Fact]
        public void NumeroTrois()
        {
            var homeController = new HomeController();

            var result = homeController.Numero3();

            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void NumeroQuatre()
        {
            var homeController = new HomeController();

            var result = homeController.Numero4();

            Assert.IsAssignableFrom<VirtualFileResult>(result);
        }

        [Fact]
        public void NumeroCinq()
        {
            var homeController = new HomeController();

            var result = homeController.Numero5();

            Assert.IsType<JsonResult>(result);
        }

        [Fact]
        public void NumeroSix()
        {
            var homeController = new HomeController();

            var result = homeController.Numero6();

            Assert.IsType<string>(result);
        }
        */
    }
}
