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
        private readonly ILogger<TERCController> logger;
        public TERCController(IMediator mediator, ILogger<TERCController> logger)
        {
            this.mediator = mediator;
            this.logger = logger;
        }

        [HttpPost]
        [Route("/DajWojewodztwa")]
        public async Task<IActionResult> GetAllVoivodeships(GetVoivodeshipsCommand command)
        {
            try
            {
                if (command is null)
                {
                    throw new Exception("Not Found");
                }
                else if (command.GetType() != typeof(GetVoivodeshipsCommand))
                {
                    throw new Exception("Bad Request");
                }
            }
            catch (Exception ex)
            {
                logger.LogError(ex.ToString());
                if (ex.Message == "Not Found")
                {
                    return NotFound("Something went wrong. Command is probably null");
                }
                else if (ex.Message == "Bad Request")
                {
                    return BadRequest("Something went wrong. Yours typeof command class is not GetVoivodeshipsCommand type. Plese check you request.");
                }
                else
                {
                    return StatusCode(StatusCodes.Status500InternalServerError);
                }
            }
            return Ok(await mediator.Send(command));
        }

        [HttpPost]
        [Route("/DajWojewodztwo")]
        public async Task<IActionResult> GetVoivodeshipById(GetVoivodeshipByIdCommand command)
        {
            try
            {
                if (command is null)
                {
                    throw new Exception("Not Found");
                }
                else if (command.GetType() != typeof(GetVoivodeshipByIdCommand))
                {
                    throw new Exception("Bad Request");
                }
            }
            catch (Exception ex)
            {
                logger.LogError(ex.ToString());
                if (ex.Message == "Not Found")
                {
                    return NotFound("Something went wrong. Command is probably null");
                }
                else if (ex.Message == "Bad Request")
                {
                    return BadRequest("Something went wrong. Yours typeof command class is not GetVoivodeshipByIdCommand type. Plese check you request.");
                }
                else
                {
                    return StatusCode(StatusCodes.Status500InternalServerError);
                }
            }
            return Ok(await mediator.Send(command));

        }

        [HttpPost]
        [Route("/DajMiastaWojewodztwie")]
        public async Task<IActionResult> GetAllCitiesInVoivodeshipById(GetCititesInVoivodeshipByIdCommand command)
        {
            try
            {
                if (command is null)
                {
                    throw new Exception("Not Found");
                }
                else if (command.GetType() != typeof(GetCititesInVoivodeshipByIdCommand))
                {
                    throw new Exception("Bad Request");
                }
            }
            catch (Exception ex)
            {
                logger.LogError(ex.ToString());
                if (ex.Message == "Not Found")
                {
                    return NotFound("Something went wrong. Command is probably null");
                }
                else if (ex.Message == "Bad Request")
                {
                    return BadRequest("Something went wrong. Yours typeof command class is not GetCititesInVoivodeshipByIdCommand type. Plese check you request.");
                }
                else
                {
                    return StatusCode(StatusCodes.Status500InternalServerError);
                }
            }
            return Ok(await mediator.Send(command));
        }

        [HttpPost]
        [Route("/DajPowiatyWWojewodztwie")]
        public async Task<IActionResult> GetCountiesInVoivodeshipById(GetCountiesInVoivodeshipByIdCommand command)
        {
            try
            {
                if (command is null)
                {
                    throw new Exception("Not Found");
                }
                else if (command.GetType() != typeof(GetCountiesInVoivodeshipByIdCommand))
                {
                    throw new Exception("Bad Request");
                }
            }
            catch (Exception ex)
            {
                logger.LogError(ex.ToString());
                if (ex.Message == "Not Found")
                {
                    return NotFound("Something went wrong. Command is probably null");
                }
                else if (ex.Message == "Bad Request")
                {
                    return BadRequest("Something went wrong. Yours typeof command class is not GetCountiesInVoivodeshipByIdCommand type. Plese check you request.");
                }
                else
                {
                    return StatusCode(StatusCodes.Status500InternalServerError);
                }
            }
            return Ok(await mediator.Send(command));
        }

        [HttpPost]
        [Route("/DajPowiat")]
        public async Task<IActionResult> GetCountyById(GetCountyByIdCommand command)
        {
            try
            {
                if (command is null)
                {
                    throw new Exception("Not Found");
                }
                else if (command.GetType() != typeof(GetCountyByIdCommand))
                {
                    throw new Exception("Bad Request");
                }
            }
            catch (Exception ex)
            {
                logger.LogError(ex.ToString());
                if (ex.Message == "Not Found")
                {
                    return NotFound("Something went wrong. Command is probably null");
                }
                else if (ex.Message == "Bad Request")
                {
                    return BadRequest("Something went wrong. Yours typeof command class is not GetCountyByIdCommand type. Plese check you request.");
                }
                else
                {
                    return StatusCode(StatusCodes.Status500InternalServerError);
                }
            }
            return Ok(await mediator.Send(command));
        }

        [HttpPost]
        [Route("/DajGminy")]
        public async Task<IActionResult> GetDistrictsById(GetDistrictsByIdCommand command)
        {
            try
            {
                if (command is null)
                {
                    throw new Exception("Not Found");
                }
                else if (command.GetType() != typeof(GetDistrictsByIdCommand))
                {
                    throw new Exception("Bad Request");
                }
            }
            catch (Exception ex)
            {
                logger.LogError(ex.ToString());
                if (ex.Message == "Not Found")
                {
                    return NotFound("Something went wrong. Command is probably null");
                }
                else if (ex.Message == "Bad Request")
                {
                    return BadRequest("Something went wrong. Yours typeof command class is not GetDistrictsByIdCommand type. Plese check you request.");
                }
                else
                {
                    return StatusCode(StatusCodes.Status500InternalServerError);
                }
            }
            return Ok(await mediator.Send(command));
        }

        [HttpPost]
        [Route("/DajDelegaturyDzielnice")]
        public async Task<IActionResult> GetDeleganciesAndQuarters(GetDeleganciesAndQuartersCommand command)
        {
            try
            {
                if (command is null)
                {
                    throw new Exception("Not Found");
                }
                else if (command.GetType() != typeof(GetDeleganciesAndQuartersCommand))
                {
                    throw new Exception("Bad Request");
                }
            }
            catch (Exception ex)
            {
                logger.LogError(ex.ToString());
                if (ex.Message == "Not Found")
                {
                    return NotFound("Something went wrong. Command is probably null");
                }
                else if (ex.Message == "Bad Request")
                {
                    return BadRequest("Something went wrong. Yours typeof command class is not GetDeleganciesAndQuartersCommand type. Plese check you request.");
                }
                else
                {
                    return StatusCode(StatusCodes.Status500InternalServerError);
                }
            }
            return Ok(await mediator.Send(command));
        }

        [HttpPost]
        [Route("/DajTerenyWiejskieWPowiecie")]
        public async Task<IActionResult> GetCountrysides(GetCoutrysidesInCountyByIdCommand command)
        {
            try
            {
                if (command is null)
                {
                    throw new Exception("Not Found");
                }
                else if (command.GetType() != typeof(GetCoutrysidesInCountyByIdCommand))
                {
                    throw new Exception("Bad Request");
                }
            }
            catch (Exception ex)
            {
                logger.LogError(ex.ToString());
                if (ex.Message == "Not Found")
                {
                    return NotFound("Something went wrong. Command is probably null");
                }
                else if (ex.Message == "Bad Request")
                {
                    return BadRequest("Something went wrong. Yours typeof command class is not GetCoutrysidesInCountyByIdCommand type. Plese check you request.");
                }
                else
                {
                    return StatusCode(StatusCodes.Status500InternalServerError);
                }
            }
            return Ok(await mediator.Send(command));
        }
    }
}
