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
        public IActionResult Login(String email,string senha)
        {
            return View();
           
        }
        
        public IActionResult cadastro() 
        {
            return View();
        }

        public IActionResult cadastro()
        {
            return View();
        }
    }
