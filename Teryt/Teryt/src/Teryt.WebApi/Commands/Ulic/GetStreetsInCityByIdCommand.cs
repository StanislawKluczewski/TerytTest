using MediatR;
using Teryt.WebApi.Data;
using Teryt.WebApi.DTO.Response;

namespace Teryt.WebApi.Commands.Ulic
{
    public class GetStreetsInCityByIdCommand : IRequest<IEnumerable<ULICDto>>
    {
        public int WojewodztwoId { get; set; }
        public int PowiatId { get; set; }
        public int GminaId { get; set; }

        public class GetStreetsInDistrictByIdCommandHandler : IRequestHandler<GetStreetsInCityByIdCommand, IEnumerable<ULICDto>>
        {
            private readonly DataContext dataContext;

            public GetStreetsInDistrictByIdCommandHandler(DataContext dataContext)
            {
                this.dataContext = dataContext;
            }

            public async Task<IEnumerable<ULICDto>> Handle(GetStreetsInCityByIdCommand request, CancellationToken cancellationToken)
            {
                var result = from u in dataContext.ULICs
                             join s in dataContext.SIMCs
                             on u.WojewodztwoId equals s.WojewodztwoId
                             where u.WojewodztwoId == request.WojewodztwoId
                             && u.PowiatId == request.PowiatId && u.GminaId == request.GminaId
                             && s.PowiatId == u.PowiatId && s.GminaId == u.GminaId
                             && u.RodzGminaId == 4 && s.RodzGminaId == 4
                             && s.RmNumer == 99 && u.Cecha.Contains("ul.")
                             select new ULICDto
                             {
                                 WojewodztwoId = u.WojewodztwoId,
                                 PowiatId = u.PowiatId,
                                 GminaId = u.GminaId,
                                 Cecha = u.Cecha,
                                 Nazwa1 = u.Nazwa1,
                                 Nazwa2 = u.Nazwa2,
                                 StanNa = u.StanNa
                             };
                return await Task.FromResult(result.Distinct());
            }
        }
    }
}
