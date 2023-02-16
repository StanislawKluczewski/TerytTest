using MediatR;
using Teryt.WebApi.Data;
using Teryt.WebApi.DTO.Response;

namespace Teryt.WebApi.Commands.Ulic
{
    public class GetStreetsInCountyByIdCommand : IRequest<IEnumerable<ULICDto>>
    {
        public int WojewodztwoId { get; set; }
        public int PowiatId { get; set; }
        public class GetStreetsCommandHandler : IRequestHandler<GetStreetsInCountyByIdCommand, IEnumerable<ULICDto>>
        {
            private readonly DataContext context;

            public GetStreetsCommandHandler(DataContext datacontext)
            {
                this.context = datacontext;
            }

            public async Task<IEnumerable<ULICDto>> Handle(GetStreetsInCountyByIdCommand request, CancellationToken cancellationToken)
            {
                var result = from u in context.ULICs
                             where u.Cecha == "ul." 
                             && u.PowiatId == request.PowiatId 
                             && u.WojewodztwoId == request.WojewodztwoId
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
                return await Task.FromResult(result.Distinct());

            }
        }
    }
}
