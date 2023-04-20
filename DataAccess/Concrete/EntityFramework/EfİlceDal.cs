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
    public class EfİlceDal : IİlceDal
    {
        
        public void add(İlce ilce)
        {
            using (var contex = new CurrentDbContext())
            {
                contex.İlces.Add(ilce);
                contex.SaveChanges();
            }
        }

        public List<İlce> GetList()
        {
            using (var context = new CurrentDbContext())
            {
                var result = context.İlces.ToList();
                return result;
            }
        }
    }
}
