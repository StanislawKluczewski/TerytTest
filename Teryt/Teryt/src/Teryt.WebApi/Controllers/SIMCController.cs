using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Teryt.WebApi.Queries.Simc;

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

        [HttpGet]
        [Route("/Miasta")]
        public async Task<IActionResult> GetCities()
        {
            return Ok(await mediator.Send(new GetCitiesQuery()));
        }

        [HttpGet]
        [Route("/DajMiasto")]
        public async Task<IActionResult> GetCityByName(string nazwa)
        {
            return Ok(await mediator.Send(new GetCityByNameQuery { Nazwa = nazwa }));
        }
    }
}
