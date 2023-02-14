using MediatR;
using Teryt.WebApi.Data;
using Teryt.WebApi.DTO.Response;

namespace Teryt.WebApi.Commands.Simc
{
    public class GetVillagesInCountyCommand : IRequest<IEnumerable<SIMCDto>>
    {
        public int WojewodztwoId { get; set; }
        public int PowiatId { get; set; }
        public class GetVillagesInCountyCommandHandler : IRequestHandler<GetVillagesInCountyCommand, IEnumerable<SIMCDto>>
        {
            private readonly DataContext dataContext;

            public GetVillagesInCountyCommandHandler(DataContext dataContext)
            {
                this.dataContext = dataContext;
            }

            public async Task<IEnumerable<SIMCDto>> Handle(GetVillagesInCountyCommand request, CancellationToken cancellationToken)
            {
                var result = from s in dataContext.SIMCs
                             from t in dataContext.TERCs
                             where s.RmNumer == 1 && t.WojewodztwoId == request.WojewodztwoId &&
                             t.PowiatId == request.PowiatId && s.WojewodztwoId == request.WojewodztwoId
                             && s.PowiatId == request.PowiatId
                             select new SIMCDto
                             {
                                 Nazwa = s.Nazwa,
                                 WojewodztwoId = s.WojewodztwoId,
                                 PowiatId = s.PowiatId,
                                 GminaId = s.GminaId,
                                 RodzGminaId = s.RodzGminaId,
                                 StanNa = s.StanNa,
                                 RmNumer = s.RmNumer
                             };

                return await Task.FromResult(result.Distinct());
            }
        }
    }
}
