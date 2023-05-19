using Microsoft.EntityFrameworkCore;
using Teryt.WebApi.BLL.Interfaces;
using Teryt.WebApi.Data;

namespace Teryt.WebApi.BLL.Services
{
    public class SimcService : ISimcService
    {
        private readonly DataContext dataContext;

        public SimcService(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public async Task<IEnumerable<SIMC>> GetSimcs()
        {
            var result = await this.dataContext.SIMCs.ToListAsync();
            return result;
        }
    }
}
