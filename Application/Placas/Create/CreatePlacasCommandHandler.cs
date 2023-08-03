using Domain.Placas;
using Domain.Primitives;
using Domain.ValueObjects;
using MediatR;

namespace Application.Placas.Create
{
    public sealed class CreatePlacasCommandHandler : IRequestHandler<CreatePlacasCommand, Unit>
    {

        private readonly IPlacasRepository _placasRepository;
        private readonly IUnitOfWork _unitOfWork;

        public CreatePlacasCommandHandler(IPlacasRepository placasRepository, IUnitOfWork unitOfWork)
        {
            _placasRepository = placasRepository ?? throw new ArgumentNullException(nameof(placasRepository));
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
        }

        public async Task<Unit> Handle(CreatePlacasCommand request, CancellationToken cancellationToken)
        {
            if (DNI.Create(request.cedula) is not DNI dNi)
            {
                throw new ArgumentException(nameof(dNi));
            }

            var placa = new Placa(
                new PlacasId(Guid.NewGuid()),
                request.nombres,
                request.apellidos,
                dNi,
                request.fechaNacimiento,
                request.tipoPlaca,
                request.tipoPersonas,
                request.tipoAutomovil,
                request.valorTotalPlaca,
                true
                );

            _placasRepository.Add(placa);

            await _unitOfWork.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
