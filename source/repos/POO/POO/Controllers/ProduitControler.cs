using BLL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Components.RenderTree;
using Microsoft.AspNetCore.Http.HttpResults;
using Models.Produit;
namespace POO.Controllers
{
    public class ProduitControler : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
  
        /// <returns></returns>
        public IActionResult Liste(int id)
        {

            if (id == 0)
            {
                return NotFound();
            }
            ProduitService produitService = new ProduitService();


            ViewData["TitrePage"] = $"Le produit de la categorie {id}";
            ViewData["DescriptioPage"] = "Description de la page Catégorie";

            return View(produitService.ListParCategorie(id));
        }

        /// <summary>
        ///  Adresse Serveur/Produit/Detail
        /// </summary>
        /// <returns></returns>
        public IActionResult Detail(int id)
        {

            if (id == null) { return NotFound(); }

            ProduitService produitService = new ProduitService();
            var model = produitService.Detail(id);
            ViewData["Title"] = model.Titre;
            ViewData["Description"] = model.Description;


            return View(model);
        }
    }
}

