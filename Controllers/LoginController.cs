using Microsoft.AspNetCore.Mvc;
using progeto2b.Repositorio;
using progeto2b.Models;

namespace progeto2b.Controllers
{
    public class LoginController : Controller
    {
        //DECLARA UMA VARIAVEL  PRIVADA SOMENTE LEITURA
        private readonly UsuarioRepositorio _usuarioRepositorio;

        //CONSTRUTOR

        public LoginController(UsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }


        public IActionResult Login()
        {
            return View();

        }
        [HttpPost]
        public IActionResult Login(String email, string senha)
        {
            //Ele usa _usuarioRepositorio.ObterUsuario(email) para buscar o usuário no banco de dados.
            var usuario = _usuarioRepositorio.ObterUsuario(email);

            //Se o usuário for encontrado e a senha estiver correta, ele redireciona o usuário para a página inicial (RedirectToAction("Index", "Home")).
            if (usuario != null && usuario.Senha == senha)
            {
                // Autenticação bem-sucedida
                return RedirectToAction("Index", "Home");
            }
            //Caso contrário, ele adiciona um erro ao ModelState e retorna a visualização de login, exibindo a mensagem de erro.
            ModelState.AddModelError("", "Email ou senha inválidos.");

            //retorna a visualização (a página HTML) associada a este método
            return View();
           

        }

        public IActionResult cadastro()
        {
            return View();
        }

        public IActionResult cadastro(Usuario usuario)
        {
            return View();
        }
    }   
}