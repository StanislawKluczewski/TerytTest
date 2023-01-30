using MediatR;
using Teryt.WebApi.Data;
using Teryt.WebApi.DTO.Response;

namespace Teryt.WebApi.Commands.Ulic
{
    public class GetPathsCommand : IRequest<IEnumerable<ULICDto>>
    {
        public class GetAllPathsCommandHandler : IRequestHandler<GetPathsCommand, IEnumerable<ULICDto>>
        {
            private readonly DataContext dataContext;

            public GetAllPathsCommandHandler(DataContext dataContext)
            {
                this.dataContext = dataContext;
            }

            public async Task<IEnumerable<ULICDto>> Handle(GetPathsCommand request, CancellationToken cancellationToken)
            {
                var result = from u in dataContext.ULICs
                             where u.Cecha.Contains("droga")
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
                return await Task.FromResult(result);
            }
        }
    }
}
