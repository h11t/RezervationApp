using Microsoft.EntityFrameworkCore;
using RezervationApp.Model.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace RezervationApp.Dal
{
    public class RezervationContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DENEME24; Database=FBRezervationDB; Trusted_Connection=true; ");
        }

        public DbSet<Bilet> Bilet { get; set; }
        public DbSet<Rota> Rota { get; set; }
        public DbSet<Ucus> Ucus { get; set; }
        public DbSet<Sehir> Sehir { get; set; }
        public DbSet<Kullanici> Kullanici { get; set; }

        //Migration eklemek için microsoft.entityframeworkcore.tools indirilmeli
    }
}
