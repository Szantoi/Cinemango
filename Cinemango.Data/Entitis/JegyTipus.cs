using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinemango.Data.Entitis
{
    public class JegyTipus : IEntityTypeConfiguration<JegyTipus>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Ar { get; set; }

        public ICollection<Jegy> Jegyek { get; set; }

        public void Configure(EntityTypeBuilder<JegyTipus> builder)
        {
            builder.Property(jegyTipu=>jegyTipu.Name).HasMaxLength(20);
            builder.HasIndex(jegyTipus=>jegyTipus.Name).IsUnique();
        }
    }
}
