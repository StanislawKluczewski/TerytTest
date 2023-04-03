using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Net.Http.Headers;
using Teryt.WebApi.Authentication;
using Teryt.WebApi.Commands.Simc;
using Teryt.WebApi.Commands.Terc;
using Teryt.WebApi.Data;

namespace Teryt.WebApi.Controllers
{
    [ApiController]
    public class SIMCController : ControllerBase
    {
        private readonly IMediator mediator;
        private readonly ILogger<SIMCController> logger;
        public SIMCController(IMediator mediator, ILogger<SIMCController> logger)
        {
            this.mediator = mediator;
            this.logger = logger;
        }

        [HttpPost]
        [Route("api/[controller]/DajMiasta")]
        public async Task<IActionResult> GetCitiesCommand(GetCitiesCommand command)
        {
            try
            {
                var accessToken = Request.Headers["authorization"].ToString().Replace("Bearer ", "");
                var userAuth = UserAuthenticationCheck.IsUserAuthenticated(accessToken);
                var userRole = UserAuthenticationCheck.UserRoleCheck(accessToken);
                //if (userAuth == false && (userRole != "Admin" || userRole != "User"))
                //{
                //    throw new Exception("Unauthorized");
                //}
                if (command is null)
                {
                    throw new Exception("Not Found");
                }
                else if (command.GetType() != typeof(GetCitiesCommand))
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
                    return BadRequest("Something went wrong. Yours typeof command class is not GetCitiesCommand type. Plese check you request.");
                }
                //else if (ex.Message == "Unauthorized")
                //{
                //    return Unauthorized("You have to be logged in to use this action.");
                //}
                else
                {
                    return StatusCode(StatusCodes.Status500InternalServerError);
                }
            }
            return Ok(await mediator.Send(command));
        }

        [HttpPost]
        [Route("api/[controller]/DajMiastaWWojewodztwie")]
        public async Task<IActionResult> GetCityInVoivodeshipCommand(GetCitiesInVoivodeshipByIdCommand command)
        {
            try
            {
                var accessToken = Request.Headers["authorization"].ToString().Replace("Bearer ", "");
                var userAuth = UserAuthenticationCheck.IsUserAuthenticated(accessToken);
                var userRole = UserAuthenticationCheck.UserRoleCheck(accessToken);
                //if (userAuth == false && (userRole != "Admin" || userRole != "User"))
                //{
                //    throw new Exception("Unauthorized");
                //}
                if (command is null)
                {
                    throw new Exception("Not Found");
                }
                else if (command.GetType() != typeof(GetCitiesInVoivodeshipByIdCommand))
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
                    return BadRequest("Something went wrong. Yours typeof command class is not GetCitiesInVoivodeshipByIdCommand type. Plese check you request.");
                }
                //else if (ex.Message == "Unauthorized")
                //{
                //    return Unauthorized("You have to be logged in to use this action.");
                //}
                else
                {
                    return StatusCode(StatusCodes.Status500InternalServerError);
                }
            }
            return Ok(await mediator.Send(command));
        }

        [HttpPost]
        [Route("api/[controller]/DajWsieWPowiecie")]
        public async Task<IActionResult> GetVillagesInCountyCommand(GetVillagesInCountyCommand command)
        {
            try
            {
                var accessToken = Request.Headers["authorization"].ToString().Replace("Bearer ", "");
                var userAuth = UserAuthenticationCheck.IsUserAuthenticated(accessToken);
                var userRole = UserAuthenticationCheck.UserRoleCheck(accessToken);
                //if (userAuth == false && (userRole != "Admin" || userRole != "User"))
                //{
                //    throw new Exception("Unauthorized");
                //}
                if (command is null)
                {
                    throw new Exception("Not Found");
                }
                else if (command.GetType() != typeof(GetVillagesInCountyCommand))
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
                    return BadRequest("Something went wrong. Yours typeof command class is not GetVillagesInCountyCommand type. Plese check you request.");
                }
                //else if (ex.Message == "Unauthorized")
                //{
                //    return Unauthorized("You have to be logged in to use this action.");
                //}
                else
                {
                    return StatusCode(StatusCodes.Status500InternalServerError);
                }
            }
            return Ok(await mediator.Send(command));
        }

        [HttpPost]
        [Route("api/[controller]/DajDelegaturyMiast")]
        public async Task<IActionResult> GetDeleganciesOfCityByName(GetDeleganciesByIdCommand command)
        {
            try
            {
                var accessToken = Request.Headers["authorization"].ToString().Replace("Bearer ", "");
                var userAuth = UserAuthenticationCheck.IsUserAuthenticated(accessToken);
                var userRole = UserAuthenticationCheck.UserRoleCheck(accessToken);
                //if (userAuth == false && (userRole != "Admin" || userRole != "User"))
                //{
                //    throw new Exception("Unauthorized");
                //}
                if (command is null)
                {
                    throw new Exception("Not Found");
                }
                else if (command.GetType() != typeof(GetDeleganciesByIdCommand))
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
                    return BadRequest("Something went wrong. Yours typeof command class is not GetDeleganciesByIdCommand type. Plese check you request.");
                }
                //else if (ex.Message == "Unauthorized")
                //{
                //    return Unauthorized("You have to be logged in to use this action.");
                //}
                else
                {
                    return StatusCode(StatusCodes.Status500InternalServerError);
                }
            }
            return Ok(await mediator.Send(command));
        }

        [HttpPost]
        [Route("api/[controller]/DajCzesciMiejscowosci")]
        public async Task<IActionResult> GetPartsOfLocalitiesById(GetPartsOfLocalitiesByIdCommand command)
        {
            try
            {
                var accessToken = Request.Headers["authorization"].ToString().Replace("Bearer ", "");
                var userAuth = UserAuthenticationCheck.IsUserAuthenticated(accessToken);
                var userRole = UserAuthenticationCheck.UserRoleCheck(accessToken);
                //if (userAuth == false && (userRole != "Admin" || userRole != "User"))
                //{
                //    throw new Exception("Unauthorized");
                //}
                if (command is null)
                {
                    throw new Exception("Not Found");
                }
                else if (command.GetType() != typeof(GetPartsOfLocalitiesByIdCommand))
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
                    return BadRequest("Something went wrong. Yours typeof command class is not GetPartsOfLocalitiesByIdCommand type. Plese check you request.");
                }
                //else if (ex.Message == "Unauthorized")
                //{
                //    return Unauthorized("You have to be logged in to use this action.");
                //}
                else
                {
                    return StatusCode(StatusCodes.Status500InternalServerError);
                }
            }
            return Ok(await mediator.Send(command));
        }

        [HttpPost]
        [Route("api/[controller]/DajCaleWsie")]
        public async Task<IActionResult> GetVillagesById(GetWholeVillagesByIdCommand command)
        {
            try
            {
                var accessToken = Request.Headers["authorization"].ToString().Replace("Bearer ", "");
                var userAuth = UserAuthenticationCheck.IsUserAuthenticated(accessToken);
                var userRole = UserAuthenticationCheck.UserRoleCheck(accessToken);
                //if (userAuth == false && (userRole != "Admin" || userRole != "User"))
                //{
                //    throw new Exception("Unauthorized");
                //}
                if (command is null)
                {
                    throw new Exception("Not Found");
                }
                else if (command.GetType() != typeof(GetWholeVillagesByIdCommand))
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
                    return BadRequest("Something went wrong. Yours typeof command class is not GetWholeVillagesByIdCommand type. Plese check you request.");
                }
                //else if (ex.Message == "Unauthorized")
                //{
                //    return Unauthorized("You have to be logged in to use this action.");
                //}
                else
                {
                    return StatusCode(StatusCodes.Status500InternalServerError);
                }
            }
            return Ok(await mediator.Send(command));
        }

        [HttpPost]
        [Route("api/[controller]/DajOsadyWPowiecie")]
        public async Task<IActionResult> GetSettlementsInCountyById(GetSettlementsInCountyByIdCommand command)
        {
            try
            {
                var accessToken = Request.Headers["authorization"].ToString().Replace("Bearer ", "");
                var userAuth = UserAuthenticationCheck.IsUserAuthenticated(accessToken);
                var userRole = UserAuthenticationCheck.UserRoleCheck(accessToken);
                //if (userAuth == false && (userRole != "Admin" || userRole != "User"))
                //{
                //    throw new Exception("Unauthorized");
                //}
                if (command is null)
                {
                    throw new Exception("Not Found");
                }
                else if (command.GetType() != typeof(GetSettlementsInCountyByIdCommand))
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
                    return BadRequest("Something went wrong. Yours typeof command class is not GetSettlementsInCountyByIdCommand type. Plese check you request.");
                }
                //else if (ex.Message == "Unauthorized")
                //{
                //    return Unauthorized("You have to be logged in to use this action.");
                //}
                else
                {
                    return StatusCode(StatusCodes.Status500InternalServerError);
                }
            }
            return Ok(await mediator.Send(command));
        }

        [HttpPost]
        [Route("api/[controller]/DajCzesciMiasta")]
        public async Task<IActionResult> GetPartsOfCityById(GetPartsOfCitiesByIdCommand command)
        {
            try
            {
                var accessToken = Request.Headers["authorization"].ToString().Replace("Bearer ", "");
                var userAuth = UserAuthenticationCheck.IsUserAuthenticated(accessToken);
                var userRole = UserAuthenticationCheck.UserRoleCheck(accessToken);
                //if (userAuth == false && (userRole != "Admin" || userRole != "User"))
                //{
                //    throw new Exception("Unauthorized");
                //}
                if (command is null)
                {
                    throw new Exception("Not Found");
                }
                else if (command.GetType() != typeof(GetPartsOfCitiesByIdCommand))
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
                    return BadRequest("Something went wrong. Yours typeof command class is not GetPartsOfCitiesByIdCommand type. Plese check you request.");
                }
                //else if (ex.Message == "Unauthorized")
                //{
                //    return Unauthorized("You have to be logged in to use this action.");
                //}
                else
                {
                    return StatusCode(StatusCodes.Status500InternalServerError);
                }
            }
            return Ok(await mediator.Send(command));
        }

        [HttpPost]
        [Route("api/[controller]/DajSchroniskaTurstyczne")]
        public async Task<IActionResult> GetTourisiticSheltersInVoivodeshipById(GetTouristicSheltersInVoivodeshipByIdCommand command)
        {
            try
            {
                var accessToken = Request.Headers["authorization"].ToString().Replace("Bearer ", "");
                var userAuth = UserAuthenticationCheck.IsUserAuthenticated(accessToken);
                var userRole = UserAuthenticationCheck.UserRoleCheck(accessToken);
                //if (userAuth == false && (userRole != "Admin" || userRole != "User"))
                //{
                //    throw new Exception("Unauthorized");
                //}
                if (command is null)
                {
                    throw new Exception("Not Found");
                }
                else if (command.GetType() != typeof(GetTouristicSheltersInVoivodeshipByIdCommand))
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
                    return BadRequest("Something went wrong. Yours typeof command class is not GetTouristicSheltersInVoivodeshipByIdCommand type. Plese check you request.");
                }
                //else if (ex.Message == "Unauthorized")
                //{
                //    return Unauthorized("You have to be logged in to use this action.");
                //}
                else
                {
                    return StatusCode(StatusCodes.Status500InternalServerError);
                }
            }
            return Ok(await mediator.Send(command));
        }
    }
}
