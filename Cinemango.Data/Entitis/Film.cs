using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinemango.Data.Entitis
{
    public class Film : IEntityTypeConfiguration<Film>
    {
        public int Id { get; set; }
        public string ImdbID { get; set; }
        public string Cim { get; set; }
        public string EredetiCim { get; set; }
        public int kiadasEve { get; set; }
        public string LeirasHTML { get; set; }
        public string? ElozetesURL { get; set; }
        public byte[]? Boritokep { get; set; }

        public ICollection<Vetites> Vetitesek { get; set; }

        public void Configure(EntityTypeBuilder<Film> builder)
        {
            throw new NotImplementedException();
        }
    }
}
