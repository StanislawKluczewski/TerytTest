using MediatR;
using Teryt.WebApi.Data;
using Teryt.WebApi.DTO.Response;

namespace Teryt.WebApi.Commands.Terc
{
    public class GetCoutrysidesCommand : IRequest<IEnumerable<TERCDto>>
    {
        public class GetCoutrysidesCommandHandler : IRequestHandler<GetCoutrysidesCommand, IEnumerable<TERCDto>>
        {
            private readonly DataContext dataContext;

            public GetCoutrysidesCommandHandler(DataContext dataContext)
            {
                this.dataContext = dataContext;
            }

            public async Task<IEnumerable<TERCDto>> Handle(GetCoutrysidesCommand request, CancellationToken cancellationToken)
            {
                var result = from t in dataContext.TERCs
                             where t.RodzGminaId == 5
                             select new TERCDto
                             {
                                 WojewodztwoId = t.WojewodztwoId,
                                 Nazwa = t.Nazwa,
                                 NazwaTerytorialna = t.NazwaTerytorialna,
                                 StanNa = t.StanNa
                             };
                return result;
            }
        }
    }
}
