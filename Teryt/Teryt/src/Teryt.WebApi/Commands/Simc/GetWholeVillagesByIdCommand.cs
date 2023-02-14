using MediatR;
using Teryt.WebApi.Data;
using Teryt.WebApi.DTO.Response;

namespace Teryt.WebApi.Commands.Simc
{
    public class GetWholeVillagesByIdCommand : IRequest<IEnumerable<SIMCDto>>
    {
        public int WojewodztwoId { get; set; }
        public int PowiatId { get; set; }
        public int GminaId { get; set; }
        public class GetWholeVillagesByIdCommandHandler : IRequestHandler<GetWholeVillagesByIdCommand, IEnumerable<SIMCDto>>
        {
            private readonly DataContext dataContext;

            public GetWholeVillagesByIdCommandHandler(DataContext dataContext)
            {
                this.dataContext = dataContext;
            }

            public async Task<IEnumerable<SIMCDto>> Handle(GetWholeVillagesByIdCommand request, CancellationToken cancellationToken)
            {
                var result = from w in dataContext.SIMCs
                             where (w.RmNumer == 1 || w.RmNumer == 2 || w.RmNumer == 3)
                             && w.WojewodztwoId == request.WojewodztwoId && w.PowiatId == request.PowiatId
                             && w.GminaId == request.GminaId
                             select new SIMCDto
                             {
                                 Nazwa = w.Nazwa,
                                 WojewodztwoId = w.WojewodztwoId,
                                 PowiatId = w.PowiatId,
                                 GminaId = w.GminaId,
                                 RodzGminaId = w.RodzGminaId,
                                 StanNa = w.StanNa,
                                 RmNumer = w.RmNumer
                             };
                return await Task.FromResult(result);
            }
        }
    }
}
