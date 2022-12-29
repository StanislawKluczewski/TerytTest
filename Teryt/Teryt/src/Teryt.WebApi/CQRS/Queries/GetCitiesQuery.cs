using MediatR;
using Microsoft.EntityFrameworkCore;
using Teryt.WebApi.Data;
using Teryt.WebApi.Models;

namespace Teryt.WebApi.CQRS.Queries
{
    public class GetCitiesQuery : IRequest<IEnumerable<TERC>>
    {
        public class GetCityByIdQueryHandler : IRequestHandler<GetCitiesQuery, IEnumerable<TERC>>
        {
            private readonly DataContext context;
            public GetCityByIdQueryHandler(DataContext _context)
            {
                context = _context;
            }

            public async Task<IEnumerable<TERC>> Handle(GetCitiesQuery request, CancellationToken cancellationToken)
            {
                var result = await context.TERCs.Where(c => c.NazwaTerytorialna == "miasto" && c.RodzGminaId == 4).ToListAsync();
                return result;
            }

  
        }
    }
}
