using Microsoft.EntityFrameworkCore;
using Teryt.WebApi.BLL.Interfaces;
using Teryt.WebApi.Data;

namespace Teryt.WebApi.BLL.Services
{
    public class UlicService : IUlicService
    {
        private readonly DataContext dataContext;

        public UlicService(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public async Task<IEnumerable<ULIC>> GetUlics()
        {
            var result = await this.dataContext.ULICs.ToListAsync();
            return result;
        }
    }
}
