using MediatR;
using Teryt.WebApi.Data;
using Teryt.WebApi.DTO.Response;

namespace Teryt.WebApi.Commands.Terc
{
    public class GetCititesInVoivodeshipByIdCommand : IRequest<IEnumerable<TERCDto>>
    {
        public int WojewodztwoId { get; set; }
        public class GetCitiesCommandHandler : IRequestHandler<GetCititesInVoivodeshipByIdCommand, IEnumerable<TERCDto>>
        {
            private readonly DataContext context;

            public GetCitiesCommandHandler(DataContext context)
            {
                this.context = context;
            }

            public async Task<IEnumerable<TERCDto>> Handle(GetCititesInVoivodeshipByIdCommand request, CancellationToken cancellationToken)
            {
                var result = from c in context.TERCs
                             where (c.RodzGminaId == 3 || c.RodzGminaId == 4 || c.RodzGminaId == 5)
                             && c.WojewodztwoId == request.WojewodztwoId
                             select new TERCDto
                             {
                                 Nazwa = c.Nazwa,
                                 NazwaTerytorialna = c.NazwaTerytorialna,
                                 WojewodztwoId = c.WojewodztwoId,
                                 StanNa = c.StanNa,
                                 PowiatId= (int)c.PowiatId
                             };
                return await Task.FromResult(result);
            }
        }
    }
}
