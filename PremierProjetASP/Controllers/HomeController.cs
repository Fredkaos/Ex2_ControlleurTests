using Microsoft.AspNetCore.Mvc;
using PremierProjetASP.Models;
using System.Text.Json;

namespace PremierProjetASP.Controllers
{
    public class HomeController : Controller
    {
        public string Numero1()
        {
            // return View();
            
            string texte = "<h2>Bienvenu dans mon site web</h2>";
            return texte; 
            
        }
        public ContentResult Numero2()
        {
            string texte = "<h2>Bienvenu dans mon site web</h2>";
            return Content(texte, "text/html");
        }
        public ViewResult Numero3()
        {
            return View("Numero3");
        }
        public FileResult Numero4()
        {
            var filePath = "~/pdf/Chapitre1.pdf";
            return File(filePath, "application/pdf");
        }
        public ContentResult Numero5()
        {
            // Créez une liste d'objets clients
            var clients = new List<Client>
            {
                new Client(1, "Dupont", "Jean", "jean.dupont@example.com"),
                new Client(2, "Tremblay", "Marie", "marie.tremblay@example.com"),
                new Client(3, "Gagnon", "Luc", "luc.gagnon@example.com")
            };

            // Sérialiser la liste au format JSON
            var json = JsonSerializer.Serialize(clients);

            // Afficher la liste sur le navigateur
            return Content(json, "application/json");
        }
        public string Numero6()
        {
            return Numero1();
        }
    }
}
