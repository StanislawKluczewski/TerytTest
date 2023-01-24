using MediatR;
using Teryt.WebApi.Data;
using Teryt.WebApi.DTO.Response;

namespace Teryt.WebApi.Commands.Simc
{
    public class GetDeleganciesByIdCommand : IRequest<IEnumerable<SIMCDto>>
    {
        public int Id { get; set; }
        public class GetDeleganciesOfCityByNameCommandHandler : IRequestHandler<GetDeleganciesByIdCommand, IEnumerable<SIMCDto>>
        {
            private readonly DataContext dataContext;

            public GetDeleganciesOfCityByNameCommandHandler(DataContext dataContext)
            {
                this.dataContext = dataContext;
            }

            public async Task<IEnumerable<SIMCDto>> Handle(GetDeleganciesByIdCommand request, CancellationToken cancellationToken)
            {
                var result = from s in dataContext.SIMCs
                             join t in dataContext.TERCs
                             on s.WojewodztwoId equals t.WojewodztwoId
                             where t.NazwaTerytorialna == "delegatura" && s.RmNumer == 98
                             && t.PowiatId == s.PowiatId
                             && t.WojewodztwoId == request.Id
                             select new SIMCDto
                             {
                                 Nazwa = s.Nazwa,
                                 WojewodztwoId = s.WojewodztwoId,
                                 PowiatId = s.PowiatId,
                                 GminaId = s.GminaId,
                                 RodzGminaId = s.RodzGminaId,
                                 StanNa = s.StanNa
                             };
                return await Task.FromResult(result);
            }
        }
    }
}
