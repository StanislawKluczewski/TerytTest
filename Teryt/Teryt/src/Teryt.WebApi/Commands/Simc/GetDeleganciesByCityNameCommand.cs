using MediatR;
using Teryt.WebApi.Data;
using Teryt.WebApi.DTO.Response;

namespace Teryt.WebApi.Commands.Simc
{
    public class GetDeleganciesByCityNameCommand : IRequest<IEnumerable<SIMCDto>>
    {
        public string Nazwa { get; set; }
        public class GetDeleganciesOfCityByNameCommandHandler : IRequestHandler<GetDeleganciesByCityNameCommand, IEnumerable<SIMCDto>>
        {
            private readonly DataContext dataContext;

            public GetDeleganciesOfCityByNameCommandHandler(DataContext dataContext)
            {
                this.dataContext = dataContext;
            }

            public async Task<IEnumerable<SIMCDto>> Handle(GetDeleganciesByCityNameCommand request, CancellationToken cancellationToken)
            {
                var result = from s in dataContext.SIMCs
                             from t in dataContext.TERCs
                             where t.NazwaTerytorialna == "delegatura" && s.RmNumer == 98
                             && s.Nazwa.Contains(request.Nazwa.ToLower()) && t.WojewodztwoId == s.WojewodztwoId
                             && t.PowiatId == s.PowiatId
                             select new SIMCDto
                             {
                                 Nazwa = s.Nazwa,
                                 WojewodztwoId = s.WojewodztwoId,
                                 PowiatId = s.PowiatId,
                                 GminaId = s.GminaId,
                                 RodzGminaId = s.RodzGminaId,
                                 StanNa = s.StanNa
                             };
                return result.Distinct();
            }
        }
    }
}
