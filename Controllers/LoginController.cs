using Microsoft.AspNetCore.Mvc;

namespace progeto2b.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
