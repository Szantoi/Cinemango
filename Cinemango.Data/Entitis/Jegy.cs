using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cinemango.Data.Entitis
{
    public class Jegy : IEntityTypeConfiguration<Jegy>
    {
        public int Id { get; set; }
        public int? Ar { get; set; }

        public int? TipusId { get; set; }
        public JegyTipus? Tipus { get; set; }

        public int UlohelyId { get; set; }
        public Ulohely Ulohely { get; set; }

        public int? VasarlasId { get; set; }
        public Vasarlas? Vasarlas { get; set; }

        public int VetitesId { get; set; }
        public Vetites Vetites { get; set; }

        public void Configure(EntityTypeBuilder<Jegy> builder)
        {
            builder.HasIndex(jegy => new { jegy.UlohelyId, jegy.VasarlasId }).IsUnique();


            builder.HasOne(jegy => jegy.Tipus).WithMany(jegyTipus => jegyTipus.Jegyek)
                .HasForeignKey(jegy => jegy.TipusId).HasPrincipalKey(jegyTipus => jegyTipus.Id)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(jegy => jegy.Ulohely).WithMany(ulohely => ulohely.Jegyek)
                .HasForeignKey(jegy => jegy.UlohelyId).HasPrincipalKey(ulohely => ulohely.Id)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(jegy => jegy.Vasarlas).WithMany(vasarlas => vasarlas.Jegyek)
                .HasForeignKey(jegy => jegy.VasarlasId).HasPrincipalKey(vasarlas => vasarlas.Id)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(jegy => jegy.Vetites).WithMany(vetites => vetites.Jegyek)
                .HasForeignKey(jegy => jegy.VetitesId).HasPrincipalKey(vetites => vetites.Id)
                .OnDelete(DeleteBehavior.Restrict);

        }
    }
}