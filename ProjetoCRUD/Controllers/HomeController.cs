using Microsoft.AspNetCore.Mvc;
using ProjetoCRUD.Models;
using System.Diagnostics;

namespace ProjetoCRUD.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            // Aqui � onde instanciamos a model dentro da controller para que possamos aplicar o tratamento dos dados
            HomeModel home = new HomeModel();

            // Dessa forma � como colocamos dados manualmente nos objetos.
            home.Nome = "Pedro";

            return View(home);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
