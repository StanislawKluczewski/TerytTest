using MediatR;
using Teryt.WebApi.Data;
using Teryt.WebApi.DTO.Response;

namespace Teryt.WebApi.Commands.Simc
{
    public class GetSettlementsInCountyByIdCommand : IRequest<IEnumerable<SIMCDto>>
    {
        public int WojewodztwoId { get; set; }
        public int PowiatId { get; set; }
        public class GetSettlementsInCoutnyByIdCommandHandler : IRequestHandler<GetSettlementsInCountyByIdCommand, IEnumerable<SIMCDto>>
        {
            private readonly DataContext dataContext;

            public GetSettlementsInCoutnyByIdCommandHandler(DataContext dataContext)
            {
                this.dataContext = dataContext;
            }

            public async Task<IEnumerable<SIMCDto>> Handle(GetSettlementsInCountyByIdCommand request, CancellationToken cancellationToken)
            {
                var result = from s in dataContext.SIMCs
                             where (s.RmNumer == 4 || s.RmNumer == 5)
                             && s.WojewodztwoId == request.WojewodztwoId
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
                return await Task.FromResult(result);
            }
        }
    }
}
