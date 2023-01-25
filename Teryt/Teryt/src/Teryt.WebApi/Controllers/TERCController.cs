using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Teryt.WebApi.Commands.Terc;
using Teryt.WebApi.Helpers;

namespace Teryt.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TERCController : ControllerBase
    {
        private readonly IMediator mediator;
        private ExceptionHandler exceptionHandler;
        public TERCController(IMediator mediator)
        {
            this.mediator = mediator;
            this.exceptionHandler = new ExceptionHandler();
        }

        [HttpPost]
        [Route("/DajWojewodztwa")]
        public async Task<IActionResult> GetAllVoivodeships(GetVoivodeshipsCommand command)
        {
            var result = exceptionHandler.GetException(command, typeof(GetVoivodeshipsCommand));
            if (result == 404)
            {
                return NotFound("Something went wrong. Command is probably null");
            }
            else if (result == 400)
            {
                return BadRequest("Something went wrong. Yours typeof command class is not GetVoivodeshipsCommand type. Plese check you request.");
            }
            else if (result == 500)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
            return Ok(await mediator.Send(command));
        }

        [HttpPost]
        [Route("/DajWojewodztwo")]
        public async Task<IActionResult> GetVoivodeshipById(GetVoivodeshipByIdCommand command)
        {
            var result = exceptionHandler.GetException(command, typeof(GetVoivodeshipByIdCommand));
            if (result == 404)
            {
                return NotFound("Something went wrong. Command is probably null");
            }
            else if (result == 400)
            {
                return BadRequest("Something went wrong. Yours typeof command class is not GetVoivodeshipByIdCommand type. Plese check you request.");
            }
            else if (result == 500)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
            return Ok(await mediator.Send(command));
        }

        [HttpPost]
        [Route("/DajMiastaWojewodztwie")]
        public async Task<IActionResult> GetAllCitiesInVoivodeshipById(GetCititesInVoivodeshipByIdCommand command)
        {
            var result = exceptionHandler.GetException(command, typeof(GetCititesInVoivodeshipByIdCommand));
            if (result == 404)
            {
                return NotFound("Something went wrong. Command is probably null");
            }
            else if (result == 400)
            {
                return BadRequest("Something went wrong. Yours typeof command class is not GetCititesInVoivodeshipByIdCommand type. Plese check you request.");
            }
            else if (result == 500)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
            return Ok(await mediator.Send(command));
        }

        [HttpPost]
        [Route("/DajPowiatyWWojewodztwie")]
        public async Task<IActionResult> GetCountiesInVoivodeshipById(GetCountiesInVoivodeshipByIdCommand command)
        {
            var result = exceptionHandler.GetException(command, typeof(GetCountiesInVoivodeshipByIdCommand));
            if (result == 404)
            {
                return NotFound("Something went wrong. Command is probably null");
            }
            else if (result == 400)
            {
                return BadRequest("Something went wrong. Yours typeof command class is not GetCountiesInVoivodeshipByIdCommand type. Plese check you request.");
            }
            else if (result == 500)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
            return Ok(await mediator.Send(command));
        }

        [HttpPost]
        [Route("/DajPowiat")]
        public async Task<IActionResult> GetCountyById(GetCountyByIdCommand command)
        {
            var result = exceptionHandler.GetException(command, typeof(GetCountyByIdCommand));
            if (result == 404)
            {
                return NotFound("Something went wrong. Command is probably null");
            }
            else if (result == 400)
            {
                return BadRequest("Something went wrong. Yours typeof command class is not GetCountyByIdCommand type. Plese check you request.");
            }
            else if (result == 500)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
            return Ok(await mediator.Send(command));
        }

        [HttpPost]
        [Route("/DajGminy")]
        public async Task<IActionResult> GetDistrictsById(GetDistrictsByIdCommand command)
        {
            var result = exceptionHandler.GetException(command, typeof(GetDistrictsByIdCommand));
            if (result == 404)
            {
                return NotFound("Something went wrong. Command is probably null");
            }
            else if (result == 400)
            {
                return BadRequest("Something went wrong. Yours typeof command class is not GetDistrictsByIdCommand type. Plese check you request.");
            }
            else if (result == 500)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
            return Ok(await mediator.Send(command));
        }

        [HttpPost]
        [Route("/DajDelegaturyDzielnice")]
        public async Task<IActionResult> GetDeleganciesAndQuarters(GetDeleganciesAndQuartersCommand command)
        {
            var result = exceptionHandler.GetException(command, typeof(GetDeleganciesAndQuartersCommand));
            if (result == 404)
            {
                return NotFound("Something went wrong. Command is probably null");
            }
            else if (result == 400)
            {
                return BadRequest("Something went wrong. Yours typeof command class is not GetDeleganciesAndQuartersCommand type. Plese check you request.");
            }
            else if (result == 500)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
            return Ok(await mediator.Send(command));
        }

        [HttpPost]
        [Route("/DajTerenyWiejskieWPowiecie")]
        public async Task<IActionResult> GetCountrysides(GetCoutrysidesInCountyByIdCommand command)
        {
            var result = exceptionHandler.GetException(command, typeof(GetCoutrysidesInCountyByIdCommand));
            if (result == 404)
            {
                return NotFound("Something went wrong. Command is probably null");
            }
            else if (result == 400)
            {
                return BadRequest("Something went wrong. Yours typeof command class is not GetCoutrysidesCommand type. Plese check you request.");
            }
            else if (result == 500)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
            return Ok(await mediator.Send(command));
        }
    }
}
