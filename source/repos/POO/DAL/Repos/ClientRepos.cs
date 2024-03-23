using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public class ClientRepos
    {
        public void Create(Client entity)
        {
            MyDbContext db = new MyDbContext();
            db.Client.Add(entity);
            db.SaveChanges();
        }

        public Client Read(int id) 
        {
            MyDbContext db = new MyDbContext();
            var entity = db.Client.Find(id);
            return entity;
        }

        public List<Client> All() 
        {
            MyDbContext db = new MyDbContext();
            return db.Client.ToList();
        }
    }
}
