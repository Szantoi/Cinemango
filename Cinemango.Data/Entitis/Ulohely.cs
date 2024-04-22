using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cinemango.Data.Entitis
{
    public class Ulohely : IEntityTypeConfiguration<Ulohely>
    {
        public int Id { get; set; }
        public UlohelyOldal? Oldal { get; set; }
        public int Sor { get; set; }
        public int Szek { get; set; }

        public int TeremId { get; set; }
        public Terem Terem { get; set; }

        public ICollection<Jegy> Jegyek { get; set; }

        public void Configure(EntityTypeBuilder<Ulohely> builder)
        {
            builder.HasIndex(ulohely => new { ulohely.TeremId, ulohely.Oldal,ulohely.Sor,ulohely.Szek});

            builder.HasOne(ulohely => ulohely.Terem).WithMany(terem => terem.Ulohelyek)
                .HasForeignKey(ulohely => ulohely.TeremId).HasPrincipalKey(terem => terem.Id);
        }
    }
}