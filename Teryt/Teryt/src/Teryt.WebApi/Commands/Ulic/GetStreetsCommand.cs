using MediatR;
using Teryt.WebApi.Data;
using Teryt.WebApi.DTO.Response;

namespace Teryt.WebApi.Commands.Ulic
{
    public class GetStreetsCommand : IRequest<IEnumerable<ULICDto>>
    {
        public class GetStreetsCommandHandler : IRequestHandler<GetStreetsCommand, IEnumerable<ULICDto>>
        {
            private readonly DataContext context;

            public GetStreetsCommandHandler(DataContext datacontext)
            {
                this.context = datacontext;
            }

            public async Task<IEnumerable<ULICDto>> Handle(GetStreetsCommand request, CancellationToken cancellationToken)
            {
                var result = from u in context.ULICs
                             where u.Cecha == "ul."
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
                return result;

            }
        }
    }
}
