using MediatR;
using Teryt.WebApi.Data;
using Teryt.WebApi.DTO.Response;

namespace Teryt.WebApi.Commands.Simc
{
    public class GetCitiesCommand : IRequest<IEnumerable<SIMCDto>>
    {
        public class GetCitiesCommandHandler : IRequestHandler<GetCitiesCommand, IEnumerable<SIMCDto>>
        {
            private readonly DataContext context;

            public GetCitiesCommandHandler(DataContext context)
            {
                this.context = context;
            }

            public async Task<IEnumerable<SIMCDto>> Handle(GetCitiesCommand request, CancellationToken cancellationToken)
            {
                var result = from c in context.SIMCs
                             where c.SymNumer == c.SymPod && c.RmNumer == 96
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
