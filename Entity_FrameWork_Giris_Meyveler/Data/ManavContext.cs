using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_FrameWork_Giris_Meyveler.Data
{
    public class ManavContext : DbContext
    {
        public DbSet<Meyve> Meyveler => Set<Meyve>(); // tablo adı

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;database=Manav;trusted_connection=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // SEED DATA -- ORNEK VERILER
            modelBuilder.Entity<Meyve>().HasData(
                new Meyve() { Id=1, Ad="Elma" },
                new Meyve() { Id = 2, Ad = "Armut" },
                new Meyve() { Id = 3, Ad = "Portakal" },
                new Meyve() { Id = 4, Ad = "Muz" }
                );
        }
    }
}
