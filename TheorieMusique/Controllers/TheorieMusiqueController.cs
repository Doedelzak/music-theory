using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Text.RegularExpressions;
using TheorieMusique.Models;

namespace TheorieMusique.Controllers
{
    public class TheorieMusiqueController : Controller
    {
        public IActionResult Accueil()
        {
            return View(new LayoutViewModel());
        }

        public IActionResult Page(string page)
        {
            return View(page);
        }
    }
}