using Application.Placas.Common;
using ErrorOr;
using MediatR;

namespace Application.Placas.UpdatePlacaCommand
{
    public record UpdatePlacaCommand(
         Guid id,
         string nombres,
         string apellidos,
         string cedula,
         string fechaNacimiento,
         string tipoPlaca,
         string tipoPersonas,
         string tipoAutomovil,
         double valorTotalPlaca) : IRequest<ErrorOr<Unit>>;
}
