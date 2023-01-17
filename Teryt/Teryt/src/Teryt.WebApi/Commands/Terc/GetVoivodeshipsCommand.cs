using MediatR;
using Teryt.WebApi.Data;
using Teryt.WebApi.DTO.Response;

namespace Teryt.WebApi.Commands.Terc
{
    public class GetVoivodeshipsCommand : IRequest<IEnumerable<TERCDto>>
    {
        public class GetVoivodeshipsCommandHandler : IRequestHandler<GetVoivodeshipsCommand, IEnumerable<TERCDto>>
        {
            private readonly DataContext context;

            public GetVoivodeshipsCommandHandler(DataContext context)
            {
                this.context = context;
            }

            public async Task<IEnumerable<TERCDto>> Handle(GetVoivodeshipsCommand request, CancellationToken cancellationToken)
            {
                var result = from v in context.TERCs
                             where v.PowiatId == 0 && v.GminaId == 0
                             && v.RodzGminaId == 0 && v.NazwaTerytorialna.Contains("województwo")
                             select new TERCDto
                             {
                                 Nazwa = v.Nazwa,
                                 NazwaTerytorialna = v.NazwaTerytorialna,
                                 WojewodztwoId = v.WojewodztwoId,
                                 StanNa = v.StanNa
                             };
                return result;
            }
        }
    }
}
