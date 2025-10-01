using Microsoft.AspNetCore.Mvc;

namespace ProjetoLoja.Models
{
    public class Usuario : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
