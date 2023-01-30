using MediatR;
using Teryt.WebApi.Data;
using Teryt.WebApi.DTO.Response;

namespace Teryt.WebApi.Commands.Ulic
{
    public class GetBridgesInVoivodeshipByIdCommand : IRequest<IEnumerable<ULICDto>>
    {
        public int WojewodztwoId { get; set; }
        public class GetBridgesInVoivodeshipByIdCommandHandler : IRequestHandler<GetBridgesInVoivodeshipByIdCommand,IEnumerable<ULICDto>>
        {
            private readonly DataContext dataContext;

            public GetBridgesInVoivodeshipByIdCommandHandler(DataContext dataContext)
            {
                this.dataContext = dataContext;
            }

            public async Task<IEnumerable<ULICDto>> Handle(GetBridgesInVoivodeshipByIdCommand request, CancellationToken cancellationToken)
            {
                var result = from u in dataContext.ULICs
                             join s in dataContext.SIMCs
                             on u.SymNumer equals s.SymNumer
                             where u.WojewodztwoId == request.WojewodztwoId
                             where u.Cecha.Contains("inne") && u.Nazwa1.Contains("most")
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
