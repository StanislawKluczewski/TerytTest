using MediatR;
using Microsoft.EntityFrameworkCore;
using Teryt.WebApi.Data;

namespace Teryt.WebApi.Queries.Terc
{
    public class GetAllVoivodeshipsQuery : IRequest<IEnumerable<TERC>>
    {
        public class GetAllVoivodeshipsHandler : IRequestHandler<GetAllVoivodeshipsQuery, IEnumerable<TERC>>
        {
            private readonly DataContext context;

            public GetAllVoivodeshipsHandler(DataContext _context)
            {
                context = _context;
            }
            public async Task<IEnumerable<TERC>> Handle(GetAllVoivodeshipsQuery request, CancellationToken cancellationToken)
            {
                var result = await context.TERCs.Where(x => x.NazwaTerytorialna == "województwo").ToListAsync();
                return result;
            }
        }


    }
}
