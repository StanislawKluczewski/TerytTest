using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Teryt.WebApi.Commands.Terc;

namespace Teryt.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TERCController : ControllerBase
    {
        private readonly IMediator mediator;
        public TERCController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpPost]
        [Route("/DajWojewodztwa")]
        public async Task<IActionResult> GetAllVoivodeships(GetVoivodeshipsCommand command)
        {
            return Ok(await mediator.Send(command));
        }

        [HttpPost]
        [Route("/DajWojewodztwo")]
        public async Task<IActionResult> GetVoivodeshipById(GetVoivodeshipByIdCommand command)
        {
            return Ok(await mediator.Send(command));
        }

        [HttpPost]
        [Route("/DajMiasta")]
        public async Task <IActionResult> GetAllCities(GetCititesCommand command)
        {
            return Ok(await mediator.Send(command));
        }

        [HttpPost]
        [Route("/DajPowiaty")]
        public async Task <IActionResult>GetCounties(GetCountiesCommand command)
        {
            return Ok(await mediator.Send(command));
        }

        [HttpPost]
        [Route("/DajGminy")]
        public async Task<IActionResult>GetDistrictsById(GetDistrictsByIdCommand command)
        {
            return Ok(await mediator.Send(command));
        }

        [HttpPost]
        [Route("/DajDelegaturyDzielnice")]
        public async Task<IActionResult>GetDeleganciesAndQuarters(GetDeleganciesAndQuartersCommand command)
        {
            return Ok(await mediator.Send(command));
        }

        [HttpPost]
        [Route("/DajTerenyWiejskie")]
        public async Task<IActionResult>GetCountrysides(GetCoutrysidesCommand command)
        {
            return Ok(await mediator.Send(command));
        }
    }
}
