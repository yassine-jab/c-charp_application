using DAL.Entity;
using DAL.Repos;
using Models;
using Models.Produit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ProduitService
    {

        public List<Models.Produit.ProduitListVM> ListParCategorie(int idCategorie)
        {
            var list = new List<Models.Produit.ProduitListVM>();

            //Phase 1 

            ProduitRepo repos = new ProduitRepo();



            foreach (var item in repos.ReadAll().Where(a => a.IdCategorie == idCategorie))
            {
                ProduitListVM obj = new ProduitListVM()
                { Description = item.Description, Id = item.Id, Nom = item.Titre, Prix = item.Prix };
                list.Add(obj);
            }

            return list;
        }

        public ProduitDetailVM Detail(int id)
        {
            var source = new ProduitRepo();
            var objSource = source.Read(id);
            ProduitDetailVM obj = new ProduitDetailVM();

            obj.Id = objSource.Id;
            obj.Description = objSource.Description;
            obj.Prix = objSource.Prix;


            return obj;
        }
        public List<Models.Produit.ProduitListVM> Liste()
        {
            var list = new List<Models.Produit.ProduitListVM>();

            //Phase 1 

            ProduitRepo repos = new ProduitRepo();



            foreach (var item in repos.ReadAll())
            {
                ProduitListVM obj = new ProduitListVM()
                { Description = item.Description, Id = item.Id, Nom = item.Titre, Prix = item.Prix };
                list.Add(obj);
            }

            return list;
        }
    }
   


}
