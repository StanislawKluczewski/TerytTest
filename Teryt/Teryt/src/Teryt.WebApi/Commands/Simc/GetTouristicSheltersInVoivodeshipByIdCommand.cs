using MediatR;
using Teryt.WebApi.Data;
using Teryt.WebApi.DTO.Response;

namespace Teryt.WebApi.Commands.Simc
{
    public class GetTouristicSheltersInVoivodeshipByIdCommand : IRequest<IEnumerable<SIMCDto>>
    {
        public int WojewodztwoId { get; set; }
        public class GetTouristicSheltersInVovodeshipByIdCommandHandler : IRequestHandler<GetTouristicSheltersInVoivodeshipByIdCommand, IEnumerable<SIMCDto>>
        {
            private readonly DataContext dataContext;

            public GetTouristicSheltersInVovodeshipByIdCommandHandler(DataContext dataContext)
            {
                this.dataContext = dataContext;
            }

            public async Task<IEnumerable<SIMCDto>> Handle(GetTouristicSheltersInVoivodeshipByIdCommand request, CancellationToken cancellationToken)
            {
                var result = from sch in dataContext.SIMCs
                             where sch.RmNumer == 7
                             && sch.WojewodztwoId == request.WojewodztwoId
                             select new SIMCDto
                             {
                                 Nazwa = sch.Nazwa,
                                 WojewodztwoId = sch.WojewodztwoId,
                                 PowiatId = sch.PowiatId,
                                 GminaId = sch.GminaId,
                                 RodzGminaId = sch.RodzGminaId,
                                 StanNa = sch.StanNa,
                                 RmNumer = sch.RmNumer
                             };
                return await Task.FromResult(result);
            }
        }
    }
}
