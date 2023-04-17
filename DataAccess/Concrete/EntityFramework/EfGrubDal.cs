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
    public class EfGrubDal : IGrubDal
    {
        public List<Grub> GetList()
        {
            using (var context = new CurrentDbContext())
            {
                var result =context.Grubs.ToList();
                return result;
            }
        }
    }
}
