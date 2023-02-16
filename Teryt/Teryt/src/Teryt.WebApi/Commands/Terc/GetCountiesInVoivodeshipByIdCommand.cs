using Azure.Core;
using MediatR;
using Teryt.WebApi.Data;
using Teryt.WebApi.DTO.Response;

namespace Teryt.WebApi.Commands.Terc
{
    public class GetCountiesInVoivodeshipByIdCommand : IRequest<IEnumerable<TERCDto>>
    {
        public int WojewodztwoId { get; set; }
        public class GetCountyCommandHandler : IRequestHandler<GetCountiesInVoivodeshipByIdCommand, IEnumerable<TERCDto>>
        {
            private readonly DataContext context;

            public GetCountyCommandHandler(DataContext context)
            {
                this.context = context;
            }
            public async Task<IEnumerable<TERCDto>> Handle(GetCountiesInVoivodeshipByIdCommand request, CancellationToken cancellationToken)
            {
                var result = from c in context.TERCs
                             where c.PowiatId != null && c.GminaId == 0 && c.RodzGminaId == 0
                             && c.WojewodztwoId == request.WojewodztwoId
                             orderby c.Nazwa
                             select new TERCDto
                             {
                                 WojewodztwoId = c.WojewodztwoId,
                                 Nazwa = c.Nazwa,
                                 NazwaTerytorialna = c.NazwaTerytorialna,
                                 StanNa = c.StanNa,
                                 PowiatId = (int)c.PowiatId
                             };
                return await Task.FromResult(result);
            }
        }
    }
}
