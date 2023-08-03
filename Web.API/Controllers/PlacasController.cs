using Application.Placas.Create;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using ErrorOr;

namespace Web.API.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class PlacasController : ControllerBase
    {
        private readonly ISender _mediator;

        public PlacasController(ISender mediator)
        {
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        }

        [HttpPost]
        public async Task<ActionResult> Create([FromBody] CreatePlacasCommand command)
        {
            var createResult = await _mediator.Send(command);

            return createResult.Match(
                   customers => Ok(customers),
                   errors => Problem("Error al crear")
               );
        }
    }
}
