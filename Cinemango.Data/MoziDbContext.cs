using Cinemango.Data.Entitis;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Cinemango.Data
{
    public class MoziDbContext : DbContext
    {
        public MoziDbContext(DbContextOptions<MoziDbContext> options) : base(options) { }

        public DbSet<Felhasznalo> Felhasznalok { get; set; }
        public DbSet<Film> Filmek { get; set; }
        public DbSet<Jegy> Jegyek { get; set; }
        public DbSet<JegyTipus> JegyTipusok { get; set; }
        public DbSet<Terem> Termek { get; set; }
        public DbSet<Ulohely> Ulohelyek { get; set; }
        public DbSet<Vasarlas> Vasarlasok { get; set; }
        public DbSet<Vetites> Vetitesek { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
