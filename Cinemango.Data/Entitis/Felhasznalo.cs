using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinemango.Data.Entitis
{
    public class Felhasznalo : IEntityTypeConfiguration<Felhasznalo>
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Vasarlas> Vasarlasoks { get; set; }

        public void Configure(EntityTypeBuilder<Felhasznalo> builder)
        {
            builder.Property(felhasznalo => felhasznalo.Name).HasMaxLength(100);

        }
    }
}
