using Microsoft.AspNetCore.Mvc;

namespace ProjetoLoja.Models
{
    public class Cliente : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
