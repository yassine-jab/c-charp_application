using Microsoft.AspNetCore.Mvc;
using BLL;
namespace POO.Controllers
{
    public class Categorie : Controller
    {

        public IActionResult Index()
        {
            CategorieService categories = new  CategorieService();
            var list= categories.List();

            return View(list);


        }
    }
}
