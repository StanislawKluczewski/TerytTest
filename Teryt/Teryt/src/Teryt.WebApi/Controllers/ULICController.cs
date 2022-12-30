using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Teryt.WebApi.Commands.Ulic;
using Teryt.WebApi.Queries.Ulic;

namespace Teryt.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ULICController : ControllerBase
    {
        private readonly IMediator mediator;

        public ULICController(IMediator mediator)
        {
            this.mediator = mediator;
        }
        [HttpGet]
        [Route("DajUlice")]
        public async Task<IActionResult> GetStreetByNameAndSymNumber(string nazwa, int number)
        {
            return Ok(await mediator.Send(new GetStreetByNameAndSymNumberQuery { Nazwa1 = nazwa, SymNumer = number }));
        }
        [HttpPost]
        [Route("DodajULIC")]
        public async Task<IActionResult>CreateULIC(CreateUlicCommand command)
        {
            return Ok(await mediator.Send(command));
        }
    }
}
