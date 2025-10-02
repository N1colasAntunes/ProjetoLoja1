using Microsoft.AspNetCore.Mvc;

namespace ProjetoLoja.Models
{
    public class Usuario : Controller
    {
        //ENCAPSULAMENTO NO GET SET
        //GET PEGA A SENHA E O SET JOGA ELA PRA ALGUM LUGAR
        //FORMA DE SEGURANÇA, PARA PROTEGER OS DADOS
        public int  ?Id { get; set; } //acessores realizando o encapsulmento dos dados
        public string ?Nome { get; set; }
        public string ?Email { get; set; }
        public string ?Senha { get; set; }

        public IActionResult Index()
        {
            return View();
        }
    }
}
