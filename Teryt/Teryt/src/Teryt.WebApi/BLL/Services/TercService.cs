using Microsoft.EntityFrameworkCore;
using Teryt.WebApi.BLL.Interfaces;
using Teryt.WebApi.Data;

namespace Teryt.WebApi.BLL.Services
{
    public class TercService : ITercService
    {
        private readonly DataContext dataContext;

        public TercService(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public async Task<IEnumerable<TERC>> GetTERCs()
        {
            var result = await this.dataContext.TERCs.ToListAsync();
            return result;
        }
    }
}
