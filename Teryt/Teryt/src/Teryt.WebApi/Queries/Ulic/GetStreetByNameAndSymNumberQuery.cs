using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Teryt.WebApi.Data;
using Teryt.WebApi.Models;

namespace Teryt.WebApi.Queries.Ulic
{
    public class GetStreetByNameAndSymNumberQuery : IRequest<ULIC>
    {
        public int SymNumer { get; set; }
        public string Nazwa1 { get; set; }
        public class GetStreetByNameAndSymNumberHandler : IRequestHandler<GetStreetByNameAndSymNumberQuery, ULIC>
        {
            private readonly DataContext context;
            public GetStreetByNameAndSymNumberHandler(DataContext _context)
            {
                context = _context;
            }
            public async Task<ULIC> Handle(GetStreetByNameAndSymNumberQuery request, CancellationToken cancellationToken)
            {
                var result = await context.ULICs.Where(u => u.Cecha == ".ul" && u.SymNumer == request.SymNumer && u.Nazwa1 == request.Nazwa1).FirstAsync();
                return result;
            }
        }
    }
}
