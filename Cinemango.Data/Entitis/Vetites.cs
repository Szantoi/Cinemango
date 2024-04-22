using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinemango.Data.Entitis
{
    public class Vetites : IEntityTypeConfiguration<Vetites>
    {
        public int Id { get; set; }
        public DateTime Idopont { get; set; }
        public VetitesTipus Tipus { get; set; }

        public int FilmId { get; set; }
        public Film Film { get; set; }

        public int TermeId { get; set; }
        public Terem Terem { get; set; }

        public ICollection<Jegy> Jegyek { get; set; }

        public void Configure(EntityTypeBuilder<Vetites> builder)
        {
            builder.HasOne(vetites => vetites.Film).WithMany(film => film.Vetitesek)
                .HasForeignKey(vetites => vetites.FilmId).HasPrincipalKey(film => film.Id);
            builder.HasOne(vetites => vetites.Terem).WithMany(terem => terem.Vetitesek)
                .HasForeignKey(vetites=>vetites.Terem).HasPrincipalKey(terem => terem.Id);
        }
    }
}
