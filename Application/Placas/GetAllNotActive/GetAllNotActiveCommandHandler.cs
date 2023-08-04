using Application.Placas.Common;
using Domain.Placas;
using ErrorOr;
using MediatR;

namespace Application.Placas.GetAllNotActive
{
    public sealed class GetAllNotActiveCommandHandler : IRequestHandler<GetAllNotActiveCommand, ErrorOr<IReadOnlyList<PlacasResponseValues>>>
    {

        private readonly IPlacasRepository _placasRepository;
        public GetAllNotActiveCommandHandler(IPlacasRepository placasRepository)
        {
            _placasRepository = placasRepository ?? throw new ArgumentNullException(nameof(placasRepository));
        }

        public async Task<ErrorOr<IReadOnlyList<PlacasResponseValues>>> Handle(GetAllNotActiveCommand request, CancellationToken cancellationToken)
        {
            IReadOnlyList<Placa> pla = await _placasRepository.GetAll();
          
            return pla.Where(x => x.Active == request.active).Select(placa => new PlacasResponseValues(
                placa.Id.Value,
                placa.Nombres,
                placa.Apellidos,
                placa.Cedula.Value,
                placa.FechaNacimiento,
                placa.TipoPlaca,
                placa.TipoPersonas,
                placa.TipoAutomovil,
                placa.ValorTotalPlaca,
                placa.NumeroPlaca,
                placa.Active
               )).ToList();
        }
    }
}
