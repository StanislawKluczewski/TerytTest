using MediatR;
using Teryt.WebApi.Data;
using Teryt.WebApi.Models;

namespace Teryt.WebApi.Commands.Ulic
{
    public class CreateUlicCommand : IRequest<ULIC>
    {
        public ULIC Ulic { get; set; }
        public class CreateUlicCommandHandler : IRequestHandler<CreateUlicCommand, ULIC>
        {
            private readonly DataContext context;
            public CreateUlicCommandHandler(DataContext context)
            {
                this.context = context;
            }

            public async Task<ULIC> Handle(CreateUlicCommand request, CancellationToken cancellationToken)
            {
                var ulic = new ULIC();
                ulic.WojewodztwoId = request.Ulic.WojewodztwoId;
                ulic.PowiatId = request.Ulic.PowiatId;
                ulic.GminaId = request.Ulic.GminaId;
                ulic.RodzGminaId = request.Ulic.RodzGminaId;
                ulic.SymNumer = request.Ulic.SymNumer;
                ulic.SymNumerUlicy = request.Ulic.SymNumerUlicy;
                ulic.Cecha = request.Ulic.Cecha;
                ulic.Nazwa1 = request.Ulic.Nazwa1;
                ulic.Nazwa2 = request.Ulic.Nazwa2;
                ulic.StanNa = request.Ulic.StanNa;
                await context.ULICs.AddAsync(ulic);
                await context.SaveChangesAsync();
                return ulic;
            }
        }
    }
}
