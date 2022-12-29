using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Teryt.WebApi.CQRS.Queries;

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
            return Ok(mediator.Send(new GetStreetByNameAndSymNumberQuery { Nazwa = nazwa, SymNumer = number }));
        }
    }
}
