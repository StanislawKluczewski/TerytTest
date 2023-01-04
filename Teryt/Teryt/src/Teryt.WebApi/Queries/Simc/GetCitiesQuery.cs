using MediatR;
using Microsoft.EntityFrameworkCore;
using Teryt.WebApi.Data;

namespace Teryt.WebApi.Queries.Simc
{
    public class GetCitiesQuery : IRequest<IEnumerable<SIMC>>
    {
        public class GetCitiesQueryHandler : IRequestHandler<GetCitiesQuery, IEnumerable<SIMC>>
        {
            private readonly DataContext dataContext;

            public GetCitiesQueryHandler(DataContext dataContext)
            {
                this.dataContext = dataContext;
            }

            public async Task<IEnumerable<SIMC>> Handle(GetCitiesQuery request, CancellationToken cancellationToken)
            {
                var result = from c in dataContext.SIMCs
                                          where c.RmNumer == 96 && c.SymNumer == c.SymPod
                                          select c;
                return result;
            }
        }
    }
}
