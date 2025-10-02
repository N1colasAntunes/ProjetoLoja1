//IMPORTANDO PACOTES PARA O PROJETO
using Microsoft.AspNetCore.Mvc;
using ProjetoLoja.Repositorio;

//DEFINE O NOME E AONDE A CLASSE ESTA LOCALIZADA, NAMESPACE AJUDA A ORGANIZAR O CODIGO E EVITAR CONFLITOS DE NOMES
namespace ProjetoLoja.Controllers
{
    //CLASSE USUARIO CONTROLLER QUE ESTA HERDANDO DA CLASSE CONTROLLER
    public class UsuarioController : Controller
    {
        //DECLARA UMA VARIAVEL PRIVADA SOMENTE LEITURA DO TIPO USUARIOREPOSITORIO (INSTANCIAR) CHAMADA:
        //_usuarioRepositorio (UMA CLASSE RESPONSAVEL POR INTERAGIR COM A CAMADA DE DADOS E GERENCIAR AS INFORMAÇÕES DO USUARIO
        private readonly UsuarioRepositorio _usuarioRepositorio;

        //INJEÇÃO DE DEPENDENCIA =
        //CONSTRUTOR E RECEBE A INSTACNCIA USUARIOREPO COM PARAMETROS
        public UsuarioController (UsuarioRepositorio usuarioRepositorio)
        {
            //INSTANCIA NOVAMENTE
            _usuarioRepositorio = usuarioRepositorio;
        }
        //INTERFACE É UMA APRESENTAÇÃO DO RESULTADO (TELA)
        //APRENDER AS REQUISIÇÕES  HTTP (POST, GET, PUT, DELETE)
        [HttpGet]
        public IActionResult Login()
        {
            //RETORNA A PAGINA INDEX
            return View();
        }
        [HttpPost]
        public IActionResult login(string email, string senha)
        {
            var usuario = _usuarioRepositorio.ObterUsuario(email);
            if (usuario != null && usuario.senha != senha)
            {
                //PRIMEIRO ACTION SEGUNDO A CONTROLLER
                return RedirectToAction ("Index", "Cliente");
            }
            //MODEL STATE ARMAZENA O ERRO E MOSTRA PRO USUARIO
            ModelState.AddModelError("", "Email / senha invalida");

            //RETORNA A PAGINA QUE VOCE TA CRIANDO, NESSE CASO LOGIN.
            return View();
        }

    }
}
