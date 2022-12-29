using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Teryt.WebApi.CQRS.Queries;

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

        [HttpGet]
        [Route("/DajWojewodztwa")]
        public async Task<IActionResult> GetAllVoivodeships()
        {
            return Ok(await mediator.Send(new GetAllVoivodeshipsQuery()));
        }
        [HttpGet]
        [Route("/DajWojewodztwo/{id}")]
        public async Task<IActionResult> GetVoivodeshipById(int id)
        {
            return Ok(await mediator.Send(new GetVoivodeshipByIdQuery { Id = id }));
        }
        [HttpGet]
        [Route("/DajMiasta")]
        public async Task<IActionResult> GetCities()
        {
            return Ok(await mediator.Send(new GetCitiesQuery()));
        }
    }
}
