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

        public List<Bilgilerim> GetList()
        {
            throw new NotImplementedException();
        }
    }
}
