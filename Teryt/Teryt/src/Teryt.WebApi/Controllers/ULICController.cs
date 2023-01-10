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
        [Route("/DajUlice")]
        public async Task<IActionResult>GetStreets(GetStreetsCommand command)
        {
            return Ok(await mediator.Send(command));
        }
      
    }
}
