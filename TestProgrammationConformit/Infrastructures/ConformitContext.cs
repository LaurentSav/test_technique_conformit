using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TestProgrammationConformit.Model;

namespace TestProgrammationConformit.Infrastructures
{
    public class ConformitContext : DbContext
    {
        public ConformitContext(DbContextOptions options) : base(options)
        {

        }

        public virtual DbSet<Evenement> Evenements { get; set; }
        public virtual DbSet<Commentaire> Commentaires { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Evenement>().ToTable("Evenements");
            modelBuilder.Entity<Commentaire>().ToTable("Commentaires");
        }
        
    }
}
