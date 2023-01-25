using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Teryt.WebApi.Commands.Simc;
using Teryt.WebApi.Commands.Ulic;
using Teryt.WebApi.Helpers;

namespace Teryt.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ULICController : ControllerBase
    {
        private readonly IMediator mediator;
        private ExceptionHandler exceptionHandler;
        public ULICController(IMediator mediator)
        {
            this.mediator = mediator;
            this.exceptionHandler = new ExceptionHandler();
        }

        [HttpPost]
        [Route("/DajUliceWPowiecie")]
        public async Task<IActionResult> GetStreets(GetStreetsInCountyByIdCommand command)
        {
            var result = exceptionHandler.GetException(command, typeof(GetStreetsInCountyByIdCommand));
            if (result == 404)
            {
                return NotFound("Something went wrong. Command is probably null");
            }
            else if (result == 400)
            {
                return BadRequest("Something went wrong. Yours typeof command class is not GetStreetsInCountyByIdCommand type. Plese check you request.");
            }
            else if (result == 500)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
            return Ok(await mediator.Send(command));
        }

        [HttpPost]
        [Route("/DajRynki")]
        public async Task<IActionResult> GetMarketSquaresInCounty(GetMarketSquaresInCountyByIdCommand command)
        {
            var result = exceptionHandler.GetException(command, typeof(GetMarketSquaresInCountyByIdCommand));
            if (result == 404)
            {
                return NotFound("Something went wrong. Command is probably null");
            }
            else if (result == 400)
            {
                return BadRequest("Something went wrong. Yours typeof command class is not GetMarketSquaresInCountyByIdCommand type. Plese check you request.");
            }
            else if (result == 500)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
            return Ok(await mediator.Send(command));
        }

        [HttpPost]
        [Route("/DajUliceWMiescie")]
        public async Task<IActionResult> GetStreetsInCityById(GetStreetsInCityByIdCommand command)
        {
            var result = exceptionHandler.GetException(command, typeof(GetStreetsInCityByIdCommand));
            if (result == 404)
            {
                return NotFound("Something went wrong. Command is probably null");
            }
            else if (result == 400)
            {
                return BadRequest("Something went wrong. Yours typeof command class is not GetStreetsInCityByIdCommand type. Plese check you request.");
            }
            else if (result == 500)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
            return Ok(await mediator.Send(command));
        }

        [HttpPost]
        [Route("/DajDrogi")]
        public async Task<IActionResult> GetAllPathsInPoland(GetPathsCommand command)
        {
            var result = exceptionHandler.GetException(command, typeof(GetPathsCommand));
            if (result == 404)
            {
                return NotFound("Something went wrong. Command is probably null");
            }
            else if (result == 400)
            {
                return BadRequest("Something went wrong. Yours typeof command class is not GetPathsCommand type. Plese check you request.");
            }
            else if (result == 500)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
            return Ok(await mediator.Send(command));
        }

        [HttpPost]
        [Route("/DajMostyWWojewodztwie")]
        public async Task<IActionResult> GetBridgesInVoivodeshipById(GetBridgesInVoivodeshipByIdCommand command)
        {
            var result = exceptionHandler.GetException(command, typeof(GetBridgesInVoivodeshipByIdCommand));
            if (result == 404)
            {
                return NotFound("Something went wrong. Command is probably null");
            }
            else if (result == 400)
            {
                return BadRequest("Something went wrong. Yours typeof command class is not GetBridgesInVoivodeshipByIdCommand type. Plese check you request.");
            }
            else if (result == 500)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
            return Ok(await mediator.Send(command));
        }

        [HttpPost]
        [Route("/DajParkiWWojewodztwie")]
        public async Task<IActionResult> GetAllParksInVoivodeshipById(GetParksInVoivodeshipByIdCommand command)
        {
            var result = exceptionHandler.GetException(command, typeof(GetParksInVoivodeshipByIdCommand));
            if (result == 404)
            {
                return NotFound("Something went wrong. Command is probably null");
            }
            else if (result == 400)
            {
                return BadRequest("Something went wrong. Yours typeof command class is not GetParksInVoivodeshipByIdCommand type. Plese check you request.");
            }
            else if (result == 500)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
            return Ok(await mediator.Send(command));
        }
    }
}