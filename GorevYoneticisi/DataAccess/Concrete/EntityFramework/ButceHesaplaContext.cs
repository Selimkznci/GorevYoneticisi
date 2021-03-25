using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public class ButceHesaplaContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=ButceHesapla;Trusted_Connection=True"));
        }
        public DbSet<Gider> Giderler { get; set; }     

        public DbSet<Gelir> Gelirler { get; set; }
        public DbSet<Borc> Borclar { get; set; }
        public DbSet<Fatura> Faturalar { get; set; }
        public DbSet<Eglence> Eglenceler { get; set; }
    }
}
