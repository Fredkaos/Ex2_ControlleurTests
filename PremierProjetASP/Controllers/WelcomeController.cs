using Microsoft.AspNetCore.Mvc;

namespace PremierProjetASP.Controllers
{
    public class WelcomeController : Controller
    {
        public IActionResult WelcomeDefault()
        {
            return View("Default");
        }
        public IActionResult WelcomeName(string nom, string prenom)
        {
            if (nom == null || prenom == null) { return View("Erreur"); }
            else
            {
                ViewData["nom"] = nom;
                ViewData["prenom"] = prenom;
                return View("Name");
            }
        }
    }
}
