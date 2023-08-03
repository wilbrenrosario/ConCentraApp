using MediatR;

namespace Application.Placas.Create
{
    public record CreatePlacasCommand(
         string nombres, 
         string apellidos, 
         string cedula, 
         string fechaNacimiento,
         string tipoPlaca, 
         string tipoPersonas, 
         string tipoAutomovil, 
         double valorTotalPlaca, 
         bool active

        ) : IRequest<Unit>;
}
