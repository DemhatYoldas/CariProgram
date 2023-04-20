using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfBilgilerimDal : IBilgilerimDal
    {
        public void add(Bilgilerim bilgilerim)
        {
            using (var context = new CurrentDbContext())
            {
                context.Bilgilerims.Add(bilgilerim);
                context.SaveChanges();
            }
        }

        public void Delete(Bilgilerim bilgilerim)
        {
            using (var context = new CurrentDbContext())
            {
                context.Bilgilerims.Remove(bilgilerim);
                context.SaveChanges();
            }
        }

        public Bilgilerim Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Bilgilerim> GetList()
        {
            using (var context = new CurrentDbContext())
            {
                var result = context.Bilgilerims.ToList();
                return result;
            }
        }

        public void Update(Bilgilerim bilgilerim)
        {
            using (var context = new CurrentDbContext())
            {
                context.Bilgilerims.Update(bilgilerim);
                context.SaveChanges();
            }
        }
    }
}
