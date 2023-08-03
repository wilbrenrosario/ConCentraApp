using Application.Placas.Common;
using Domain.Placas;
using ErrorOr;
using MediatR;

namespace Application.Placas.GetAll
{
    public sealed class GetPlacasCommandHandler : IRequestHandler<GetPlacasCommand, ErrorOr<IReadOnlyList<PlacasResponse>>>
    {

        private readonly IPlacasRepository _placasRepository;
        public GetPlacasCommandHandler(IPlacasRepository placasRepository)
        {
            _placasRepository = placasRepository ?? throw new ArgumentNullException(nameof(placasRepository));
        }

        public async Task<ErrorOr<IReadOnlyList<PlacasResponse>>> Handle(GetPlacasCommand request, CancellationToken cancellationToken)
        {
            IReadOnlyList<Placa> pla = await _placasRepository.GetAll();
          
            return pla.Where(x => x.Active == true).Select(placa => new PlacasResponse(
                placa.Id.Value,
                placa.Nombres,
                placa.Apellidos,
                placa.Cedula.Value,
                placa.FechaNacimiento,
                placa.TipoPlaca,
                placa.TipoPersonas,
                placa.TipoAutomovil,
                placa.ValorTotalPlaca,
                placa.Active
               )).ToList();
        }
    }
}
