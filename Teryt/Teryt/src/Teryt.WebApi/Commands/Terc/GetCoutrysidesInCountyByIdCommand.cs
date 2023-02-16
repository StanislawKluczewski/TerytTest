using MediatR;
using Teryt.WebApi.Data;
using Teryt.WebApi.DTO.Response;

namespace Teryt.WebApi.Commands.Terc
{
    public class GetCoutrysidesInCountyByIdCommand : IRequest<IEnumerable<TERCDto>>
    {
        public int WojewodztwoId { get; set; }
        public int PowiatId { get; set; }
        public class GetCoutrysidesCommandHandler : IRequestHandler<GetCoutrysidesInCountyByIdCommand, IEnumerable<TERCDto>>
        {
            private readonly DataContext dataContext;

            public GetCoutrysidesCommandHandler(DataContext dataContext)
            {
                this.dataContext = dataContext;
            }

            public async Task<IEnumerable<TERCDto>> Handle(GetCoutrysidesInCountyByIdCommand request, CancellationToken cancellationToken)
            {
                var result = from t in dataContext.TERCs
                             where t.RodzGminaId == 5
                             && t.WojewodztwoId == request.WojewodztwoId && t.PowiatId == request.PowiatId
                             select new TERCDto
                             {
                                 WojewodztwoId = t.WojewodztwoId,
                                 Nazwa = t.Nazwa,
                                 NazwaTerytorialna = t.NazwaTerytorialna,
                                 StanNa = t.StanNa,
                                 PowiatId = (int)t.PowiatId
                             };
                return await Task.FromResult(result);
            }
        }
    }
}
