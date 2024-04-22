using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cinemango.Data.Entitis
{
    public class Vasarlas : IEntityTypeConfiguration<Vasarlas>
    {

        public int Id { get; set; }
        public DateTime Datum { get; set; }
        
        public ICollection<Jegy> Jegyek { get; set; }

        public int FelhasznaloId { get; set; }
        public Felhasznalo Felhasznalo { get; set; }

        public void Configure(EntityTypeBuilder<Vasarlas> builder)
        {
            builder.HasOne(vasarlas => vasarlas.Felhasznalo).WithMany(felhasznalo => felhasznalo.Vasarlasoks)
                .HasForeignKey(vasalas => vasalas.FelhasznaloId).HasPrincipalKey(felhasznalo=> felhasznalo.Id);
        }
    }
}