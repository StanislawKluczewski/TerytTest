using MediatR;
using Teryt.WebApi.Data;
using Teryt.WebApi.DTO.Response;

namespace Teryt.WebApi.Commands.Simc
{
    public class GetPartsOfCitiesByIdCommand : IRequest<IEnumerable<SIMCDto>>
    {
        public int WojewodztwoId { get; set; }
        public int PowiatId { get; set; }
        public int GminaId { get; set; }
        public class GetPartsOfCitiesByIdCommandHandler : IRequestHandler<GetPartsOfCitiesByIdCommand, IEnumerable<SIMCDto>>
        {
            private readonly DataContext dataContext;

            public GetPartsOfCitiesByIdCommandHandler(DataContext dataContext)
            {
                this.dataContext = dataContext;
            }

            public async Task<IEnumerable<SIMCDto>> Handle(GetPartsOfCitiesByIdCommand request, CancellationToken cancellationToken)
            {
                var result = from p in dataContext.SIMCs
                             where p.RmNumer == 99 && (p.RodzGminaId == 4 || p.RodzGminaId == 1)
                             && p.WojewodztwoId == request.WojewodztwoId && p.PowiatId == request.PowiatId
                             && p.GminaId == request.GminaId
                             select new SIMCDto
                             {
                                 Nazwa = p.Nazwa,
                                 WojewodztwoId = p.WojewodztwoId,
                                 PowiatId = p.PowiatId,
                                 GminaId = p.GminaId,
                                 RodzGminaId = p.RodzGminaId,
                                 StanNa = p.StanNa,
                                 RmNumer = p.RmNumer
                             };
                return await Task.FromResult(result);
            }
        }
    }
}
