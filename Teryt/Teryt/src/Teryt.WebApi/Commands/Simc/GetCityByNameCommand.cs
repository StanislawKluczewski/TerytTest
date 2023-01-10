using MediatR;
using Teryt.WebApi.Data;
using Teryt.WebApi.DTO.Response;

namespace Teryt.WebApi.Commands.Simc
{
    public class GetCityByNameCommand : IRequest<IEnumerable<SIMCDto>>
    {
        public string Nazwa { get; set; }
        public class GetCityByNameCommandHandler : IRequestHandler<GetCityByNameCommand, IEnumerable<SIMCDto>>
        {
            private readonly DataContext context;

            public GetCityByNameCommandHandler(DataContext context)
            {
                this.context = context;
            }
            public async Task<IEnumerable<SIMCDto>> Handle(GetCityByNameCommand request, CancellationToken cancellationToken)
            {
                var result = from c in context.SIMCs
                             where (c.SymNumer == c.SymPod && c.RmNumer == 96)
                             && c.Nazwa == request.Nazwa
                             select new SIMCDto
                             {
                                 Nazwa = request.Nazwa,
                                 WojewodztwoId = c.WojewodztwoId,
                                 PowiatId = c.PowiatId,
                                 GminaId = c.GminaId,
                                 RodzGminaId = c.RodzGminaId,
                                 StanNa = c.StanNa
                             };
                return result;
            }
        }
    }
}

