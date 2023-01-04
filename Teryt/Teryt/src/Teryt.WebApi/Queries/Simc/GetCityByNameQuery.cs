using MediatR;
using Teryt.WebApi.Data;

namespace Teryt.WebApi.Queries.Simc
{
    public class GetCityByNameQuery : IRequest<SIMC>
    { 
        public string Nazwa { get; set; }
        public class GetCityByNameQueryHandler : IRequestHandler<GetCityByNameQuery, SIMC>
        {
            private readonly DataContext context;
            public GetCityByNameQueryHandler(DataContext context)
            {
                this.context = context;
            }
    
            public async Task<SIMC> Handle(GetCityByNameQuery request, CancellationToken cancellationToken)
            {
                var result = from c in context.SIMCs
                             where c.RmNumer == 96 && c.RmNumer == c.SymPod && c.Nazwa == request.Nazwa
                             select c;
                return (SIMC)result;
            }
        }
    }
}
