using MediatR;
using Teryt.WebApi.Data;
using Teryt.WebApi.DTO.Response;

namespace Teryt.WebApi.Commands.Simc
{
    public class GetPartsOfLocalitiesByIdCommand : IRequest<IEnumerable<SIMCDto>>
    {
        public int WojewodztwoId { get; set; }
        public int PowiatId { get; set; }
        public class GetPartsOfLocalityByIdCommandHandler : IRequestHandler<GetPartsOfLocalitiesByIdCommand, IEnumerable<SIMCDto>>
        {
            private readonly DataContext dataContext;

            public GetPartsOfLocalityByIdCommandHandler(DataContext dataContext)
            {
                this.dataContext = dataContext;
            }

            public async Task<IEnumerable<SIMCDto>> Handle(GetPartsOfLocalitiesByIdCommand request, CancellationToken cancellationToken)
            {
                var result = from p in dataContext.SIMCs
                             where p.RmNumer == 0 && p.WojewodztwoId == request.WojewodztwoId
                             && p.PowiatId == request.PowiatId
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
