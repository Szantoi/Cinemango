using Cinemango.Data;

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
        public async Task GetJegyTipusokAsync() { }
        public async Task VasarlasAsync() { }
    }
}
