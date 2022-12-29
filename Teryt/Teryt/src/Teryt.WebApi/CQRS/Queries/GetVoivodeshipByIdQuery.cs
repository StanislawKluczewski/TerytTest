using MediatR;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.EntityFrameworkCore;
using Teryt.WebApi.Data;
using Teryt.WebApi.Models;

namespace Teryt.WebApi.CQRS.Queries
{
    public class GetVoivodeshipByIdQuery : IRequest<TERC>
    {
        public int Id { get; set; }
        public class GetVoivodeshipByIdQueryHandler : IRequestHandler<GetVoivodeshipByIdQuery, TERC>
        {
            private readonly DataContext context;

            public GetVoivodeshipByIdQueryHandler(DataContext context)
            {
                this.context = context;
            }

            public async Task<TERC> Handle(GetVoivodeshipByIdQuery request, CancellationToken cancellationToken)
            {
                var result = await context.TERCs.Where(x => x.NazwaTerytorialna == "województwo" && x.WojewodztwoId == request.Id).FirstAsync();
                return result;
            }
        }
    }
}
