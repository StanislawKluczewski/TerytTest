using MediatR;
using Teryt.WebApi.Data;
using Teryt.WebApi.DTO.Response;

namespace Teryt.WebApi.Commands.Terc
{
    public class GetDistrictsByIdCommand : IRequest<IEnumerable<TERCDto>>
    {
        public int WojewodztwoId { get; set; }
        public int PowiatId { get; set; }

        public class GetDistrictsCommandByIdHandler : IRequestHandler<GetDistrictsByIdCommand, IEnumerable<TERCDto>>
        {
            private readonly DataContext dataContext;

            public GetDistrictsCommandByIdHandler(DataContext dataContext)
            {
                this.dataContext = dataContext;
            }

            public async Task<IEnumerable<TERCDto>> Handle(GetDistrictsByIdCommand request, CancellationToken cancellationToken)
            {
                var result = from d in dataContext.TERCs
                             where (d.RodzGminaId == 1 || d.RodzGminaId == 2 || d.RodzGminaId == 3)
                             && d.PowiatId == request.PowiatId && d.WojewodztwoId == request.WojewodztwoId
                             select new TERCDto
                             {
                                 WojewodztwoId = d.WojewodztwoId,
                                 Nazwa = d.Nazwa,
                                 NazwaTerytorialna = d.NazwaTerytorialna,
                                 StanNa = d.StanNa,
                                 PowiatId = (int)d.PowiatId,
                                 GminaId = d.GminaId
                             };
                return await Task.FromResult(result);
            }
        }
    }
}
