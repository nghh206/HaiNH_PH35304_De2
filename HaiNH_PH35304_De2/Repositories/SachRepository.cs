using De2.Context;
using De2.DomainClass;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace De2.Repositories
{
    internal class SachRepository
    {
        FinalassFpolyNetJavaSm22Bl2Context dbContext;

        public SachRepository()
        {
            dbContext = new();
        }
        public List<Sach> GetAll()
        {
            var lstSach = dbContext.Saches.ToList();
            return lstSach;
        }
        public List<Sach> FindByName(string name)
        {
            var lstSach = dbContext.Saches.Where(n => n.Ten.Contains(name)).ToList();
            return lstSach;
        }
        public Sach Add(Sach sach)
        {
            using (var obj = new FinalassFpolyNetJavaSm22Bl2Context())
            {
                obj.Saches.Add(sach);
                obj.SaveChanges();
                return sach;
            }
        }
        public void Update(Sach sach)
        {
            if (sach != null)
            {
                using (var obj = new FinalassFpolyNetJavaSm22Bl2Context())
                {
                    obj.Saches.Attach(sach);
                    obj.Entry(sach).State = EntityState.Modified;
                    obj.SaveChanges();
                }
            }
        }
        public void Delete(Sach sach)
        {
            using (var obj = new FinalassFpolyNetJavaSm22Bl2Context())
            {
                obj.Saches.Attach(sach);
                obj.Saches.Remove(sach);
                obj.SaveChanges();
            }
        }
    }
}
