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
        [Route("/DajMiastaWWojewodztwie")]
        public async Task<IActionResult>GetCityByNameCommand(GetCitiesInVoivodeshipByIdCommand command)
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
        public async Task<IActionResult> GetDeleganciesOfCityByName(GetDeleganciesByIdCommand command)
        {
            return Ok(await mediator.Send(command));
        }

        [HttpPost]
        [Route("/DajCzesciMiejscowosci")]
        public async Task<IActionResult>GetPartsOfLocalitiesById(GetPartsOfLocalitiesByIdCommand command)
        {
            return Ok(await mediator.Send(command));
        }
        [HttpPost]
        [Route("/DajCaleWsie")]
        public async Task <IActionResult>GetVillagesById(GetWholeVillagesByIdCommand command)
        {
            return Ok(await mediator.Send(command));
        }
        [HttpPost]
        [Route("/DajOsadyWPowiecie")]
        public async Task<IActionResult>GetSettlementsInCountyById(GetSettlementsInCountyByIdCommand command)
        {
            return Ok(await mediator.Send(command));
        }

        [HttpPost]
        [Route("/DajCzesciMiasta")]
        public async Task<IActionResult>GetPartsOfCityById(GetPartsOfCitiesByIdCommand command)
        {
            return Ok(await mediator.Send(command));
        }

        [HttpPost]
        [Route("/DajSchroniskaTurstyczne")]
        public async Task<IActionResult>GetTourisiticSheltersInVoivodeshipById(GetTouristicSheltersInVoivodeshipByIdCommand command)
        {
            return Ok(await mediator.Send(command));
        }
    }
}
