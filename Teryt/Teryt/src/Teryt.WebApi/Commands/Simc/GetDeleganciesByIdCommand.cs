using MediatR;
using Teryt.WebApi.Data;
using Teryt.WebApi.DTO.Response;

namespace Teryt.WebApi.Commands.Simc
{
    public class GetDeleganciesByIdCommand : IRequest<IEnumerable<SIMCDto>>
    {
        public int WojewodztwoId { get; set; }
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
                             where t.WojewodztwoId == request.WojewodztwoId &&
                             t.NazwaTerytorialna == "delegatura" && s.RmNumer == 98
                             select new SIMCDto
                             {
                                 Nazwa = s.Nazwa,
                                 WojewodztwoId = s.WojewodztwoId,
                                 PowiatId = s.PowiatId,
                                 GminaId = s.GminaId,
                                 RodzGminaId = s.RodzGminaId,
                                 StanNa = s.StanNa,
                                 RmNumer = s.RmNumer
                             };
                return await Task.FromResult(result.Distinct());
            }
        }
    }
}
