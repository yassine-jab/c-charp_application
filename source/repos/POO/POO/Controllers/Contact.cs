using Microsoft.AspNetCore.Mvc;

namespace POO.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Formulaire()
        {
            return View();
        }
    }

}
