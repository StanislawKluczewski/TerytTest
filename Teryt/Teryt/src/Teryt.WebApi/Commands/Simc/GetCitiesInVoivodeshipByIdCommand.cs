using MediatR;
using Teryt.WebApi.Data;
using Teryt.WebApi.DTO.Response;

namespace Teryt.WebApi.Commands.Simc
{
    public class GetCitiesInVoivodeshipByIdCommand : IRequest<IEnumerable<SIMCDto>>
    {
        public int WojewodztwoId { get; set; }
        public class GetCityByNameCommandHandler : IRequestHandler<GetCitiesInVoivodeshipByIdCommand, IEnumerable<SIMCDto>>
        {
            private readonly DataContext context;

            public GetCityByNameCommandHandler(DataContext context)
            {
                this.context = context;
            }
            public async Task<IEnumerable<SIMCDto>> Handle(GetCitiesInVoivodeshipByIdCommand request, CancellationToken cancellationToken)
            {
                var result = from c in context.SIMCs
                             where (c.SymNumer == c.SymPod && c.RmNumer == 96)
                             && (c.RodzGminaId == 4 || c.RodzGminaId == 1) &&
                             c.WojewodztwoId == request.WojewodztwoId
                             orderby c.Nazwa
                             select new SIMCDto
                             {
                                 Nazwa = c.Nazwa,
                                 WojewodztwoId = c.WojewodztwoId,
                                 PowiatId = c.PowiatId,
                                 GminaId = c.GminaId,
                                 RodzGminaId = c.RodzGminaId,
                                 StanNa = c.StanNa,
                                 RmNumer = c.RmNumer
                             };
                return await Task.FromResult(result);
            }
        }
    }
}

