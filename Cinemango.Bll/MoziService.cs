using Cinemango;
using Cinemango.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Cinemando.Bll
{
    public class MoziService
    {
        public MoziService(MoziDbContext dbContext)
        {
            DdContext = dbContext;
        }

        public MoziDbContext DdContext { get; }

        public async Task GetFilmekAsync() { }

        public async Task GetUlohelyekAsync(int vetitesId) { }

        public async Task<IReadOnlyCollection<JegyTipus>> GetJegyTipusokAsync()
        {
            return await DdContext.JegyTipusok.Select(jegyTipus => new JegyTipus(jegyTipus.Id,jegyTipus.Name, jegyTipus.Ar)).ToListAsync();
        }

        public async Task VasarlasAsync() { }
    }
}
