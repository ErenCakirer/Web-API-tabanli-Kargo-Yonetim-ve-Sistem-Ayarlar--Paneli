using KargoTakip.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KargoTakip.Data
{
    public class KargoContextFactory : IDesignTimeDbContextFactory<KargoContext>
    {
        public KargoContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<KargoContext>();
          
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=KargoTakipDb;Trusted_Connection=True;TrustServerCertificate=True;");

            return new KargoContext(optionsBuilder.Options);
        }
    }
}
