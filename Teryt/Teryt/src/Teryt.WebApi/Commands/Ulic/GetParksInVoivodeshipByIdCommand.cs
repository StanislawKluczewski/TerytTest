using MediatR;
using Teryt.WebApi.Data;
using Teryt.WebApi.DTO.Response;

namespace Teryt.WebApi.Commands.Ulic
{
    public class GetParksInVoivodeshipByIdCommand : IRequest<IEnumerable<ULICDto>>
    {
        public int WojewodztwoId { get; set; }
        public class GetAllParkInVoivodeshipByIdCommandHandler : IRequestHandler<GetParksInVoivodeshipByIdCommand, IEnumerable<ULICDto>>
        {
            private readonly DataContext dataContext;

            public GetAllParkInVoivodeshipByIdCommandHandler(DataContext dataContext)
            {
                this.dataContext = dataContext;
            }

            public async Task<IEnumerable<ULICDto>> Handle(GetParksInVoivodeshipByIdCommand request, CancellationToken cancellationToken)
            {
                var result = from u in dataContext.ULICs
                             join s in dataContext.SIMCs
                             on u.SymNumer equals s.SymNumer
                             where u.WojewodztwoId == request.WojewodztwoId
                             && s.WojewodztwoId == request.WojewodztwoId
                             && (u.Cecha.Contains("park") || u.Cecha.Contains("ogród"))
                             select new ULICDto
                             {
                                 WojewodztwoId = u.WojewodztwoId,
                                 PowiatId = u.PowiatId,
                                 GminaId = u.GminaId,
                                 Cecha = u.Cecha,
                                 Nazwa1 = u.Nazwa1,
                                 Nazwa2 = u.Nazwa2,
                                 StanNa = u.StanNa,
                                 NazwaSimc = s.Nazwa
                             };
                return await Task.FromResult(result);
            }
        }
    }
}
