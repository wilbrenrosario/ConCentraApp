using Application.Placas.Create;
using Application.Usuario.Create;
using Application.Usuario.Get;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {

        private readonly ISender _mediator;

        public UsuariosController(ISender mediator)
        {
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        }

        [HttpPost]
        public async Task<ActionResult> Login([FromBody] GetCommand command)
        {
            var createResult = await _mediator.Send(command);

            return createResult.Match(
                   customers => Ok(customers),
                   errors => Problem("Error al crear")
               );
        }

        [HttpPut]
        public async Task<ActionResult> CrearUsuario([FromBody] CreateUsuarioCommand command)
        {
            var createResult = await _mediator.Send(command);

            return Ok();
        }
    }
}
