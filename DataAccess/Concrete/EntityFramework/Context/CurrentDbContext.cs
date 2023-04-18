using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework.Context
{
    public class CurrentDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-8KSC47J\SQLEXPRESS;Database=CurrentDb;Integrated Security=true;Encrypt=false");
        }

        public DbSet<Grub>  Grubs { get; set; }
        public DbSet<Tur>  Turs { get; set; }
        public DbSet<Ulke>  Ulkes { get; set; }
        public DbSet<Sehir> Sehirs { get; set; }
        public DbSet<İlce> İlces  { get; set; }
        public DbSet<Bilgilerim> Bilgilerims  { get; set; }


    }
}
