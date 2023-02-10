using MediatR;
using Teryt.WebApi.Data;
using Teryt.WebApi.DTO.Response;

namespace Teryt.WebApi.Commands.Terc
{
    public class GetDeleganciesAndQuartersCommand : IRequest<IEnumerable<TERCDto>>
    {
        public class GetDeleganciesCommandHandler : IRequestHandler<GetDeleganciesAndQuartersCommand, IEnumerable<TERCDto>>
        {
            private readonly DataContext dataContext;

            public GetDeleganciesCommandHandler(DataContext dataContext)
            {
                this.dataContext = dataContext;
            }

            public async Task<IEnumerable<TERCDto>> Handle(GetDeleganciesAndQuartersCommand request, CancellationToken cancellationToken)
            {
                var result = from t in dataContext.TERCs
                             where t.RodzGminaId == 8 || t.RodzGminaId == 9
                             orderby t.Nazwa
                             select new TERCDto
                             {
                                 WojewodztwoId = t.WojewodztwoId,
                                 Nazwa = t.Nazwa,
                                 NazwaTerytorialna = t.NazwaTerytorialna,
                                 StanNa = t.StanNa,
                                 PowiatId = (int)t.PowiatId
                             };
                return await Task.FromResult(result);
            }
        }

    }
}
