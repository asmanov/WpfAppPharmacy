using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfAppPharmacy.Model;

namespace WpfAppPharmacy.ViewModel
{
    public class PharmacyDbContext : DbContext
    {
        public DbSet<Medicine> medecines { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=PharmacyDB;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}
