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
    public class EfUlkeDal : IUlkeDal
    {
        public void add(Ulke ulke)
        {
            using (var context = new CurrentDbContext())
            {
                context.Ulkes.Add(ulke);
                context.SaveChanges();
            }
        }
    }
}
