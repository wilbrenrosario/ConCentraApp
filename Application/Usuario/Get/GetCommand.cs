using ErrorOr;
using MediatR;

namespace Application.Usuario.Get
{
    public record GetCommand(string usuario, string clave) : IRequest<ErrorOr<Unit>>;
}
