using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cinemango.Data.Entitis
{
    public class Terem : IEntityTypeConfiguration<Terem>
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Ulohely> Ulohelyek { get; set; }

        public ICollection<Vetites> Vetitesek { get; set; }

        public void Configure(EntityTypeBuilder<Terem> builder)
        {
            builder.Property(terem=>terem.Name).HasMaxLength(20);
            builder.HasIndex(terem=> terem.Name).IsUnique();
        }
    }
}