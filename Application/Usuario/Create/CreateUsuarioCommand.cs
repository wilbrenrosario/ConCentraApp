using MediatR;

namespace Application.Usuario.Create
{
    public record CreateUsuarioCommand(
         string user, 
         string clave

        ) : IRequest<Unit>;
}
