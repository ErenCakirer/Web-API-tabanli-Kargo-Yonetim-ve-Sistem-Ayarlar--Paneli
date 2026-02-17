using KargoTakip.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KargoTakip.Data.Context
{

    public class KargoContext : DbContext
    {
        public KargoContext(DbContextOptions<KargoContext> options) : base(options) { }

       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=KargoTakipDb;Trusted_Connection=True;TrustServerCertificate=True;");
            }
        }

        public DbSet<Sevkiyat> Sevkiyatlar { get; set; }
        public DbSet<SevkiyatGeçmişi> SevkiyatGeçmişleri { get; set; }
        public DbSet<Kurye> Kuryeler { get; set; }
        public DbSet<Mesaj> Mesajlar { get; set; }
        public DbSet<KargoHareket> KargoHareketleri { get; set; }
     
        public DbSet<Ayarlar> Ayarlars { get; set; }
    }
}