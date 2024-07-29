using Microsoft.AspNetCore.Mvc;
using ProjetoCRUD.Models;

namespace ProjetoCRUD.Controllers
{
    public class ContatoController : Controller
    {
        public IActionResult Index()
        {
            ContatoModel contato = new ContatoModel();

            contato.Nome = "Pedro";
            contato.Sobrenome = "Brito";
            contato.Celular = 943724661;

            return View(contato);
        }
    }
}
