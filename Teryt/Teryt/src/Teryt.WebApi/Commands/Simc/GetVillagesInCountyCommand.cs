using MediatR;
using Teryt.WebApi.Data;
using Teryt.WebApi.DTO.Response;

namespace Teryt.WebApi.Commands.Simc
{
    public class GetVillagesInCountyCommand : IRequest<IEnumerable<SIMCDto>>
    {
        public string Nazwa { get; set; }
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
                             where t.Nazwa.Contains(request.Nazwa.ToLower()) &&
                             t.WojewodztwoId == s.WojewodztwoId && s.RmNumer == 1
                             select new SIMCDto
                             {
                                 Nazwa = s.Nazwa,
                                 WojewodztwoId = s.WojewodztwoId,
                                 PowiatId = s.PowiatId,
                                 GminaId = s.GminaId,
                                 RodzGminaId = s.RodzGminaId,
                                 StanNa = s.StanNa
                             };

                return result;
            }
        }
    }
}
