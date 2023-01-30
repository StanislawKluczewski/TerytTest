using MediatR;
using Teryt.WebApi.Data;
using Teryt.WebApi.DTO.Response;

namespace Teryt.WebApi.Commands.Ulic
{
    public class GetMarketSquaresInCountyByIdCommand : IRequest <IEnumerable<ULICDto>>
    {
        public int WojewodztwoId { get; set; }
        public int PowiatId { get; set; }
        public class GetMarketSquaresByIdHandler : IRequestHandler<GetMarketSquaresInCountyByIdCommand, IEnumerable<ULICDto>>
        {
            private readonly DataContext dataContext;

            public GetMarketSquaresByIdHandler(DataContext dataContext)
            {
                this.dataContext = dataContext;
            }

            public async Task<IEnumerable<ULICDto>> Handle(GetMarketSquaresInCountyByIdCommand request, CancellationToken cancellationToken)
            {
                var result = from r in dataContext.ULICs
                             where r.Cecha.Contains("rynek")
                             && r.WojewodztwoId == request.WojewodztwoId
                             && r.PowiatId == request.PowiatId
                             select new ULICDto
                             {
                                 WojewodztwoId = r.WojewodztwoId,
                                 PowiatId = r.PowiatId,
                                 GminaId = r.GminaId,
                                 Cecha = r.Cecha,
                                 Nazwa1 = r.Nazwa1,
                                 Nazwa2 = r.Nazwa2,
                                 StanNa = r.StanNa
                             };
                return await Task.FromResult(result);
            }
        }
    }
}
