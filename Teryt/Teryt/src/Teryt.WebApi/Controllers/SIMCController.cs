using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Teryt.WebApi.Commands.Simc;
using Teryt.WebApi.Commands.Terc;
using Teryt.WebApi.Helpers;

namespace Teryt.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SIMCController : ControllerBase
    {
        private readonly IMediator mediator;
        private ExceptionHandler exceptionHandler;
        private readonly ILogger<SIMCController> logger;
        public SIMCController(IMediator mediator, ILogger<SIMCController> logger)
        {
            this.mediator = mediator;
            this.exceptionHandler = new ExceptionHandler();
            this.logger = logger;
        }

        [HttpGet]
        [Route("/api/[controller]/logs")]
        public IEnumerable<string> Get()
        {
            logger.LogDebug("This is a debug message");
            logger.LogInformation("This is an info message");
            logger.LogWarning("Thi is a warning message");
            logger.LogError(new Exception(), "This is an error message");
            return new string[] { };
        }

        [HttpPost]
        [Route("/Miasta")]
        public async Task<IActionResult> GetCitiesCommand(GetCitiesCommand command)
        {
            var result = exceptionHandler.GetException(command, typeof(GetCitiesCommand));
            if (result == 404)
            {
                return NotFound("Something went wrong. Command is probably null");
            }
            else if (result == 400)
            {
                return BadRequest("Something went wrong. Yours typeof command class is not GetCitiesCommand type. Plese check you request.");
            }
            else if (result == 500)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
            return Ok(await mediator.Send(command));
        }

        [HttpPost]
        [Route("/DajMiastaWWojewodztwie")]
        public async Task<IActionResult> GetCityByNameCommand(GetCitiesInVoivodeshipByIdCommand command)
        {
            var result = exceptionHandler.GetException(command, typeof(GetCitiesInVoivodeshipByIdCommand));
            if (result == 404)
            {
                return NotFound("Something went wrong. Command is probably null");
            }
            else if (result == 400)
            {
                return BadRequest("Something went wrong. Yours typeof command class is not GetCitiesInVoivodeshipByIdCommand type. Plese check you request.");
            }
            else if (result == 500)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
            return Ok(await mediator.Send(command));
        }

        [HttpPost]
        [Route("/DajWsieWPowiecie")]
        public async Task<IActionResult> GetVillagesInCountyCommand(GetVillagesInCountyCommand command)
        {
            var result = exceptionHandler.GetException(command, typeof(GetVillagesInCountyCommand));
            if (result == 404)
            {
                return NotFound("Something went wrong. Command is probably null");
            }
            else if (result == 400)
            {
                return BadRequest("Something went wrong. Yours typeof command class is not GetVillagesInCountyCommand type. Plese check you request.");
            }
            else if (result == 500)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
            return Ok(await mediator.Send(command));
        }

        [HttpPost]
        [Route("/DajDelegaturyMiast")]
        public async Task<IActionResult> GetDeleganciesOfCityByName(GetDeleganciesByIdCommand command)
        {
            var result = exceptionHandler.GetException(command, typeof(GetDeleganciesByIdCommand));
            if (result == 404)
            {
                return NotFound("Something went wrong. Command is probably null");
            }
            else if (result == 400)
            {
                return BadRequest("Something went wrong. Yours typeof command class is not GetDeleganciesByIdCommand type. Plese check you request.");
            }
            else if (result == 500)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
            return Ok(await mediator.Send(command));
        }

        [HttpPost]
        [Route("/DajCzesciMiejscowosci")]
        public async Task<IActionResult> GetPartsOfLocalitiesById(GetPartsOfLocalitiesByIdCommand command)
        {
            var result = exceptionHandler.GetException(command, typeof(GetPartsOfLocalitiesByIdCommand));
            if (result == 404)
            {
                return NotFound("Something went wrong. Command is probably null");
            }
            else if (result == 400)
            {
                return BadRequest("Something went wrong. Yours typeof command class is not GetPartsOfLocalitiesByIdCommand type. Plese check you request.");
            }
            else if (result == 500)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
            return Ok(await mediator.Send(command));
        }

        [HttpPost]
        [Route("/DajCaleWsie")]
        public async Task<IActionResult> GetVillagesById(GetWholeVillagesByIdCommand command)
        {
            var result = exceptionHandler.GetException(command, typeof(GetWholeVillagesByIdCommand));
            if (result == 404)
            {
                return NotFound("Something went wrong. Command is probably null");
            }
            else if (result == 400)
            {
                return BadRequest("Something went wrong. Yours typeof command class is not GetWholeVillagesByIdCommand type. Plese check you request.");
            }
            else if (result == 500)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
            return Ok(await mediator.Send(command));
        }

        [HttpPost]
        [Route("/DajOsadyWPowiecie")]
        public async Task<IActionResult> GetSettlementsInCountyById(GetSettlementsInCountyByIdCommand command)
        {
            var result = exceptionHandler.GetException(command, typeof(GetSettlementsInCountyByIdCommand));
            if (result == 404)
            {
                return NotFound("Something went wrong. Command is probably null");
            }
            else if (result == 400)
            {
                return BadRequest("Something went wrong. Yours typeof command class is not GetSettlementsInCountyByIdCommand type. Plese check you request.");
            }
            else if (result == 500)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
            return Ok(await mediator.Send(command));
        }

        [HttpPost]
        [Route("/DajCzesciMiasta")]
        public async Task<IActionResult> GetPartsOfCityById(GetPartsOfCitiesByIdCommand command)
        {
            var result = exceptionHandler.GetException(command, typeof(GetPartsOfCitiesByIdCommand));
            if (result == 404)
            {
                return NotFound("Something went wrong. Command is probably null");
            }
            else if (result == 400)
            {
                return BadRequest("Something went wrong. Yours typeof command class is not GetPartsOfCitiesByIdCommand type. Plese check you request.");
            }
            else if (result == 500)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
            return Ok(await mediator.Send(command));
        }

        [HttpPost]
        [Route("/DajSchroniskaTurstyczne")]
        public async Task<IActionResult> GetTourisiticSheltersInVoivodeshipById(GetTouristicSheltersInVoivodeshipByIdCommand command)
        {
            var result = exceptionHandler.GetException(command, typeof(GetTouristicSheltersInVoivodeshipByIdCommand));
            if (result == 404)
            {
                return NotFound("Something went wrong. Command is probably null");
            }
            else if (result == 400)
            {
                return BadRequest("Something went wrong. Yours typeof command class is not GetTouristicSheltersInVoivodeshipByIdCommand type. Plese check you request.");
            }
            else if (result == 500)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
            return Ok(await mediator.Send(command));
        }
    }
}
