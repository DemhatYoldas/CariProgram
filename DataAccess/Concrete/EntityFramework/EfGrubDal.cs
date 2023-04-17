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
    public class EfGrubDal : IGrubDal
    {
        public void Add(Grub grub)
        {
            using (var context =new CurrentDbContext())
            {
                context.Grubs.Add(grub);
                context.SaveChanges();
            }
        }

        public void Delete(Grub grub)
        {
            using (var context = new CurrentDbContext())
            {
                context.Grubs.Remove(grub);
                context.SaveChanges();
            }
        }

        public Grub Get(int id)
        {
            using (var context = new CurrentDbContext())
            {
                var result = context.Grubs.Where(x=>x.id==id).FirstOrDefault();
                return result;
            }
        }

        public List<Grub> GetList()
        {
            using (var context = new CurrentDbContext())
            {
                var result =context.Grubs.ToList();
                return result;
            }
        }

        public void Update(Grub grub)
        {
            using (var context = new CurrentDbContext())
            {
                context.Grubs.Update(grub);
                context.SaveChanges();
            }
        }
    }
}
