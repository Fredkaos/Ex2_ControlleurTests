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
        public VirtualFileResult Numero4()
        {
            var filePath = "~/pdf/Chapitre1.pdf";
            return File(filePath, "application/pdf");
        }
        public JsonResult Numero5()
        {
            // Créez une liste d'objets clients
            var clients = new List<Client>
            {
                new Client(1, "Dupont", "Jean", "jean.dupont@example.com"),
                new Client(2, "Tremblay", "Marie", "marie.tremblay@example.com"),
            };

            var options = new JsonSerializerOptions { WriteIndented= true };
           
            JsonResult listJSon = Json(clients, options);

            return listJSon;
        }
        public RedirectToActionResult Numero6()
        {
            return RedirectToAction("Numero1");
        }
    }
}
