using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Teryt.WebApi.Commands.Ulic;

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

        [HttpPost]
        [Route("/DajUliceWPowiecie")]
        public async Task<IActionResult> GetStreets(GetStreetsInCountyByIdCommand command)
        {
            return Ok(await mediator.Send(command));
        }

        [HttpPost]
        [Route("/DajRynki")]
        public async Task<IActionResult> GetMarketSquaresInCounty(GetMarketSquaresInCountyByIdCommand command)
        {
            return Ok(await mediator.Send(command));
        }

        [HttpPost]
        [Route("/DajUliceWMiescie")]
        public async Task<IActionResult>GetStreetsInCityById(GetStreetsInCityByIdCommand command)
        {
            return Ok(await mediator.Send(command));
        }
    }
}