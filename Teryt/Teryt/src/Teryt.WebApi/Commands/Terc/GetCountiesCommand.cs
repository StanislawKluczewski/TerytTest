using Azure.Core;
using MediatR;
using Teryt.WebApi.Data;
using Teryt.WebApi.DTO.Response;

namespace Teryt.WebApi.Commands.Terc
{
    public class GetCountiesCommand : IRequest<IEnumerable<TERCDto>>
    {
        public class GetCountyCommandHandler : IRequestHandler<GetCountiesCommand, IEnumerable<TERCDto>>
        {
            private readonly DataContext context;

            public GetCountyCommandHandler(DataContext context)
            {
                this.context = context;
            }
            public async Task<IEnumerable<TERCDto>> Handle(GetCountiesCommand request, CancellationToken cancellationToken)
            {
                var result = from c in context.TERCs
                             where c.PowiatId != null && c.GminaId == 0 && c.RodzGminaId == 0
                             && c.NazwaTerytorialna != "województwo"
                             select new TERCDto
                             {
                                 WojewodztwoId = c.WojewodztwoId,
                                 Nazwa = c.Nazwa,
                                 NazwaTerytorialna = c.NazwaTerytorialna,
                                 StanNa = c.StanNa
                             };
                return result;
            }
        }
    }
}
