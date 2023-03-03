using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Teryt.WebApi.Authentication;
using Teryt.WebApi.Commands.Terc;


namespace Teryt.WebApi.Controllers
{
    [ApiController]
    [Produces("application/json")]
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
        [Route("api/[controller]/DajWojewodztwa")]
        public async Task<IActionResult> GetAllVoivodeships(GetVoivodeshipsCommand command)
        {
            try
            {
                var accessToken = Request.Headers["authorization"].ToString().Replace("Bearer ", "");
                var userAuth = UserAuthenticationCheck.IsUserAuthenticated(accessToken);
                var userRole = UserAuthenticationCheck.UserRoleCheck(accessToken);
                if (userAuth == false && (userRole != "Admin" || userRole != "User"))
                {
                    throw new Exception("Unauthorized");
                }
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
                else if (ex.Message == "Unauthorized")
                {
                    return Unauthorized("You have to be logged in to use this action.");
                }
                else
                {
                    return StatusCode(StatusCodes.Status500InternalServerError);
                }
            }
            return Ok(await mediator.Send(command));
        }

        [HttpPost]
        [Route("api/[controller]/DajWojewodztwo")]
        public async Task<IActionResult> GetVoivodeshipById(GetVoivodeshipByIdCommand command)
        {
            try
            {
                var accessToken = Request.Headers["authorization"].ToString().Replace("Bearer ", "");
                var userAuth = UserAuthenticationCheck.IsUserAuthenticated(accessToken);
                var userRole = UserAuthenticationCheck.UserRoleCheck(accessToken);
                if (userAuth == false && (userRole != "Admin" || userRole != "User"))
                {
                    throw new Exception("Unauthorized");
                }
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
                else if (ex.Message == "Unauthorized")
                {
                    return Unauthorized("You have to be logged in to use this action.");
                }
                else
                {
                    return StatusCode(StatusCodes.Status500InternalServerError);
                }
            }
            return Ok(await mediator.Send(command));

        }

        [HttpPost]
        [Route("api/[controller]/DajMiastaWojewodztwie")]
        public async Task<IActionResult> GetAllCitiesInVoivodeshipById([FromBody]GetCititesInVoivodeshipByIdCommand command)
        {
            try
            {

                var accessToken = Request.Headers["authorization"].ToString().Replace("Bearer ", "");
                var userAuth = UserAuthenticationCheck.IsUserAuthenticated(accessToken);
                var userRole = UserAuthenticationCheck.UserRoleCheck(accessToken);
                if (userAuth == false && (userRole != "Admin" || userRole != "User"))
                {
                    throw new Exception("Unauthorized");
                }
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
                else if (ex.Message == "Unauthorized")
                {
                    return Unauthorized("You have to be logged in to use this action.");
                }
                else
                {
                    return StatusCode(StatusCodes.Status500InternalServerError);
                }
            }
            return Ok(await mediator.Send(command));
        }

        [HttpPost]
        [Route("api/[controller]/DajPowiatyWojewodztwie")]
        public async Task<IActionResult> GetCountiesInVoivodeshipById([FromBody]GetCountiesInVoivodeshipByIdCommand command)
        {
            try
            {
                var accessToken = Request.Headers["authorization"].ToString().Replace("Bearer ", "");
                var userAuth = UserAuthenticationCheck.IsUserAuthenticated(accessToken);
                var userRole = UserAuthenticationCheck.UserRoleCheck(accessToken);
                if (userAuth == false && (userRole != "Admin" || userRole != "User"))
                {
                    throw new Exception("Unauthorized");
                }
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
                else if (ex.Message == "Unauthorized")
                {
                    return Unauthorized("You have to be logged in to use this action.");
                }
                else
                {
                    return StatusCode(StatusCodes.Status500InternalServerError);
                }
            }
            return Ok(await mediator.Send(command));
        }

        [HttpPost]
        [Route("api/[controller]/DajPowiat")]
        public async Task<IActionResult> GetCountyById(GetCountyByIdCommand command)
        {
            try
            {
                var accessToken = Request.Headers["authorization"].ToString().Replace("Bearer ", "");
                var userAuth = UserAuthenticationCheck.IsUserAuthenticated(accessToken);
                var userRole = UserAuthenticationCheck.UserRoleCheck(accessToken);
                if (userAuth == false && (userRole != "Admin" || userRole != "User"))
                {
                    throw new Exception("Unauthorized");
                }
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
                else if (ex.Message == "Unauthorized")
                {
                    return Unauthorized("You have to be logged in to use this action.");
                }
                else
                {
                    return StatusCode(StatusCodes.Status500InternalServerError);
                }
            }
            return Ok(await mediator.Send(command));
        }

        [HttpPost]
        [Route("api/[controller]/DajGminy")]
        public async Task<IActionResult> GetDistrictsById(GetDistrictsByIdCommand command)
        {
            try
            {
                var accessToken = Request.Headers["authorization"].ToString().Replace("Bearer ", "");
                var userAuth = UserAuthenticationCheck.IsUserAuthenticated(accessToken);
                var userRole = UserAuthenticationCheck.UserRoleCheck(accessToken);
                if (userAuth == false && (userRole != "Admin" || userRole != "User"))
                {
                    throw new Exception("Unauthorized");
                }
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
                else if (ex.Message == "Unauthorized")
                {
                    return Unauthorized("You have to be logged in to use this action.");
                }
                else
                {
                    return StatusCode(StatusCodes.Status500InternalServerError);
                }
            }
            return Ok(await mediator.Send(command));
        }

        [HttpPost]
        [Route("api/[controller]/DajDelegaturyDzielnice")]
        public async Task<IActionResult> GetDeleganciesAndQuarters(GetDeleganciesAndQuartersCommand command)
        {
            try
            {
                var accessToken = Request.Headers["authorization"].ToString().Replace("Bearer ", "");
                var userAuth = UserAuthenticationCheck.IsUserAuthenticated(accessToken);
                var userRole = UserAuthenticationCheck.UserRoleCheck(accessToken);
                if (userAuth == false && (userRole != "Admin" || userRole != "User"))
                {
                    throw new Exception("Unauthorized");
                }
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
                else if (ex.Message == "Unauthorized")
                {
                    return Unauthorized("You have to be logged in to use this action.");
                }
                else
                {
                    return StatusCode(StatusCodes.Status500InternalServerError);
                }
            }
            return Ok(await mediator.Send(command));
        }

        [HttpPost]
        [Route("api/[controller]/DajTerenyWiejskieWPowiecie")]
        public async Task<IActionResult> GetCountrysides(GetCoutrysidesInCountyByIdCommand command)
        {
            try
            {
                var accessToken = Request.Headers["authorization"].ToString().Replace("Bearer ", "");
                var userAuth = UserAuthenticationCheck.IsUserAuthenticated(accessToken);
                var userRole = UserAuthenticationCheck.UserRoleCheck(accessToken);
                if (userAuth == false && (userRole != "Admin" || userRole != "User"))
                {
                    throw new Exception("Unauthorized");
                }
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
                else if (ex.Message == "Unauthorized")
                {
                    return Unauthorized("You have to be logged in to use this action.");
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
