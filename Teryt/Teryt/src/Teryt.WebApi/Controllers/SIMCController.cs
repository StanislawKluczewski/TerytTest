using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Teryt.WebApi.Commands.Simc;

namespace Teryt.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SIMCController : ControllerBase
    {
        private readonly IMediator mediator;

        public SIMCController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpPost]
        [Route("/Miasta")]
        public async Task<IActionResult> GetCitiesCommand(GetCitiesCommand command)
        {
            return Ok(await mediator.Send(command));
        }

        [HttpPost]
        [Route("/DajMiasto")]
        public async Task<IActionResult>GetCityByNameCommand(GetCityByNameCommand command)
        {
            return Ok(await mediator.Send(command));
        }

        [HttpPost]
        [Route("/DajWsieWPowiecie")]
        public async Task<IActionResult>GetVillagesInCountyCommand(GetVillagesInCountyCommand command)
        {
            return Ok(await mediator.Send(command));
        }

        [HttpPost]
        [Route("/DajDelegaturyMiast")]
        public async Task<IActionResult> GetDeleganciesOfCityByName(GetDeleganciesByCityNameCommand command)
        {
            return Ok(await mediator.Send(command));
        }
    }
}
