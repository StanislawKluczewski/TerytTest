using MediatR;
using Microsoft.EntityFrameworkCore;
using Teryt.WebApi.Data;
using Teryt.WebApi.Models;

namespace Teryt.WebApi.CQRS.Queries
{
    public class GetAllVoivodeshipsQuery : IRequest<IEnumerable<TERC>>
    {
        public class GetAllVoivodeshipsHandler : IRequestHandler<GetAllVoivodeshipsQuery, IEnumerable<TERC>>
        {
            private readonly DataContext context;

            public GetAllVoivodeshipsHandler(DataContext _context)
            {
                this.context = _context;
            }
            public async Task<IEnumerable<TERC>> Handle(GetAllVoivodeshipsQuery request, CancellationToken cancellationToken)
            {
                var result = await context.TERCs.Where(x => x.NazwaTerytorialna == "województwo").ToListAsync();
                return result;
            }
        }

      
    }
}
