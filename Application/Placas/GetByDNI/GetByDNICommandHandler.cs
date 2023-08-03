using Application.Placas.Common;
using Application.Placas.Create;
using Domain.Placas;
using ErrorOr;
using MediatR;

namespace Application.Placas.GetByDNI
{
    public sealed class GetByDNICommandHandler : IRequestHandler<GetByDNICommand, ErrorOr<IReadOnlyList<PlacasResponse>>>
    {

        private readonly IPlacasRepository _placasRepository;
        public GetByDNICommandHandler(IPlacasRepository placasRepository)
        {
            _placasRepository = placasRepository ?? throw new ArgumentNullException(nameof(placasRepository));
        }

        public async Task<ErrorOr<IReadOnlyList<PlacasResponse>>> Handle(GetByDNICommand request, CancellationToken cancellationToken)
        {
            IReadOnlyList<Placa> pla = await _placasRepository.GetAll();
          
            return pla.Where(x => x.Cedula.Value == request.dni).Select(placa => new PlacasResponse(
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
