using Application.Placas.Create;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Application.Placas.GetAll;
using Application.Placas.GetByDNI;
using Application.Placas.UpdatePlacaCommand;
using Application.Placas.GetAllNotActive;
using Microsoft.AspNetCore.Authorization;

namespace Web.API.Controllers
{
    [Authorize]
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

        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            var createResult = await _mediator.Send(new GetPlacasCommand());

            return createResult.Match(
                   customers => Ok(customers),
                   errors => Problem("Error al crear")
               );
        }

        [HttpGet("{dni}")]
        public async Task<ActionResult> GetByDNI(string dni)
        {
            var createResult = await _mediator.Send(new GetByDNICommand(dni));

            return createResult.Match(
                   customers => Ok(customers),
                   errors => Problem("Error al crear")
               );
        }

        [HttpGet("GetAllNotActive/{active}")]
        public async Task<ActionResult> GetAllNotActive(bool active)
        {
            var createResult = await _mediator.Send(new GetAllNotActiveCommand(active));

            return createResult.Match(
                   customers => Ok(customers),
                   errors => Problem("Error al crear")
               );
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Update(Guid id, [FromBody] UpdatePlacaCommand command) // Aceptar solicitud para crear # Placa
        {

            if (command.id != id)
            {
                return Problem("No fue posible confirmar la creacion de la placa.");
            }

            var createResult = await _mediator.Send(command);
            return createResult.Match(
            customers => Ok(customers),
            err => Problem());

        }
    }
}
