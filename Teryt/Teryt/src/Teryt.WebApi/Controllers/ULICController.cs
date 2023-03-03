using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Teryt.WebApi.Authentication;
using Teryt.WebApi.Commands.Simc;
using Teryt.WebApi.Commands.Ulic;


namespace Teryt.WebApi.Controllers
{
    [ApiController]
    public class ULICController : ControllerBase
    {
        private readonly IMediator mediator;
        private readonly ILogger<ULICController> logger;

        public ULICController(IMediator mediator, ILogger<ULICController> logger)
        {
            this.mediator = mediator;
            this.logger = logger;
        }

        [HttpPost]
        [Route("api/[controller]/DajUliceWPowiecie")]
        public async Task<IActionResult> GetStreets(GetStreetsInCountyByIdCommand command)
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
                else if (command.GetType() != typeof(GetStreetsInCountyByIdCommand))
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
                    return BadRequest("Something went wrong. Yours typeof command class is not GetStreetsInCountyByIdCommand type. Plese check you request.");
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
        [Route("api/[controller]/DajRynki")]
        public async Task<IActionResult> GetMarketSquaresInCounty(GetMarketSquaresInCountyByIdCommand command)
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
                else if (command.GetType() != typeof(GetMarketSquaresInCountyByIdCommand))
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
                    return BadRequest("Something went wrong. Yours typeof command class is not GetMarketSquaresInCountyByIdCommand type. Plese check you request.");
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
        [Route("api/[controller]/DajUliceWMiescie")]
        public async Task<IActionResult> GetStreetsInCityById(GetStreetsInCityByIdCommand command)
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
                else if (command.GetType() != typeof(GetStreetsInCityByIdCommand))
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
                    return BadRequest("Something went wrong. Yours typeof command class is not GetStreetsInCityByIdCommand type. Plese check you request.");
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
        [Route("api/[controller]/DajDrogi")]
        public async Task<IActionResult> GetAllPathsInPoland(GetPathsCommand command)
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
                else if (command.GetType() != typeof(GetPathsCommand))
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
                    return BadRequest("Something went wrong. Yours typeof command class is not GetPathsCommand type. Plese check you request.");
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
        [Route("api/[controller]/DajMostyWWojewodztwie")]
        public async Task<IActionResult> GetBridgesInVoivodeshipById(GetBridgesInVoivodeshipByIdCommand command)
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
                else if (command.GetType() != typeof(GetBridgesInVoivodeshipByIdCommand))
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
                    return BadRequest("Something went wrong. Yours typeof command class is not GetBridgesInVoivodeshipByIdCommand type. Plese check you request.");
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
        [Route("api/[controller]/DajParkiWWojewodztwie")]
        public async Task<IActionResult> GetAllParksInVoivodeshipById(GetParksInVoivodeshipByIdCommand command)
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
                else if (command.GetType() != typeof(GetParksInVoivodeshipByIdCommand))
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
                    return BadRequest("Something went wrong. Yours typeof command class is not GetParksInVoivodeshipByIdCommand type. Plese check you request.");
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