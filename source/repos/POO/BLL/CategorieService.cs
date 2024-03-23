using DAL.Repos;
using Models.Categorie;
using Models.Produit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CategorieService
    {
        public List<Models.Categorie.CategorieList> List()
        {
            var list = new List<Models.Categorie.CategorieList>();

            //Phase 1 

            CategorieRepos repose = new CategorieRepos();



            foreach (var item in repose.All())
            {
                CategorieList obj = new CategorieList()
                { Description = item.Description, Id = item.Id,Nom=item.NomCategorie };
                list.Add(obj);
            }

            return list;
        }
    }
}
