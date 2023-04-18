﻿using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfSehirDal : ISehirDal
    {
        public void add(Sehir sehir)
        {
            using (var context = new CurrentDbContext())
            {
                context.Sehirs.Add(sehir);
                context.SaveChanges();
            }
        }
    }
}
