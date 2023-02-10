using MediatR;
using Teryt.WebApi.Data;
using Teryt.WebApi.DTO.Response;

namespace Teryt.WebApi.Commands.Terc
{
    public class GetCountyByIdCommand : IRequest<IEnumerable<TERCDto>>
    {
        public int WojewodztwoId { get; set; }
        public int PowiatId { get; set; }

        public class GetCountyByIdCommandHandler : IRequestHandler<GetCountyByIdCommand, IEnumerable<TERCDto>>
        {
            private readonly DataContext dataContext;

            public GetCountyByIdCommandHandler(DataContext dataContext)
            {
                this.dataContext = dataContext;
            }

            public async Task<IEnumerable<TERCDto>> Handle(GetCountyByIdCommand request, CancellationToken cancellationToken)
            {
                var result = from p in dataContext.TERCs
                             where p.WojewodztwoId == request.WojewodztwoId
                             && p.PowiatId == request.PowiatId
                             && p.GminaId == 0 && p.RodzGminaId == 0
                             select new TERCDto
                             {
                                 WojewodztwoId = p.WojewodztwoId,
                                 Nazwa = p.Nazwa,
                                 NazwaTerytorialna = p.NazwaTerytorialna,
                                 StanNa = p.StanNa,
                                 PowiatId = (int)p.PowiatId
                             };
                return await Task.FromResult(result);
            }
        }
    }
}
