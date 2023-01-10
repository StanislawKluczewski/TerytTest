using MediatR;
using Teryt.WebApi.Data;
using Teryt.WebApi.DTO.Response;

namespace Teryt.WebApi.Commands.Terc
{
    public class GetCititesCommand : IRequest<IEnumerable<TERCDto>>
    {
        public class GetCitiesCommandHandler : IRequestHandler<GetCititesCommand, IEnumerable<TERCDto>>
        {
            private readonly DataContext context;

            public GetCitiesCommandHandler(DataContext context)
            {
                this.context = context;
            }

            public async Task<IEnumerable<TERCDto>> Handle(GetCititesCommand request, CancellationToken cancellationToken)
            {
                var result = from c in context.TERCs
                             where (c.RodzGminaId == 3 || c.RodzGminaId == 4 || c.RodzGminaId == 5)
                             select new TERCDto
                             {
                                 Nazwa = c.Nazwa,
                                 NazwaTerytorialna = c.NazwaTerytorialna,
                                 WojewodztwoId = c.WojewodztwoId,
                                 StanNa = c.StanNa
                             };
                return result;
            }
        }
    }
}
