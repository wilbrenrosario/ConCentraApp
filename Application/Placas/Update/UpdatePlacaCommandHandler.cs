using Application.Placas.Common;
using Application.Placas.Create;
using Domain.Placas;
using Domain.Primitives;
using ErrorOr;
using MediatR;
using System.Linq;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using System.Net;
using Domain.ValueObjects;

namespace Application.Placas.UpdatePlacaCommand
{
    public sealed class UpdatePlacaCommandHandler : IRequestHandler<UpdatePlacaCommand, ErrorOr<Unit>>
    {

        private readonly IPlacasRepository _placasRepository;
        private readonly IUnitOfWork _unitOfWork;

        public UpdatePlacaCommandHandler(IPlacasRepository placasRepository, IUnitOfWork unitOfWork)
        {
            _placasRepository = placasRepository ?? throw new ArgumentNullException(nameof(placasRepository));
            _unitOfWork = unitOfWork;
        }

        public async Task<ErrorOr<Unit>> Handle(UpdatePlacaCommand request, CancellationToken cancellationToken)
        {
            if (DNI.Create(request.cedula) is not DNI dNi)
            {
                throw new ArgumentException(nameof(dNi));
            }

            var placaNumero = "";
            Random rnd = new Random();

            if (request.tipoAutomovil == "Publico")
            {
                placaNumero = "A" + rnd.Next(1, 9) + rnd.Next(1, 9) + rnd.Next(1, 9) + rnd.Next(1, 9) + rnd.Next(1, 9) + rnd.Next(1, 9);
            }
            else if (request.tipoAutomovil == "Privado")
            {
                placaNumero = "F" + rnd.Next(1, 9) + rnd.Next(1, 9) + rnd.Next(1, 9) + rnd.Next(1, 9) + rnd.Next(1, 9) + rnd.Next(1, 9);
            }
            else if (request.tipoAutomovil == "Transporte")
            {
                placaNumero = "T" + rnd.Next(1, 9) + rnd.Next(1, 9) + rnd.Next(1, 9) + rnd.Next(1, 9) + rnd.Next(1, 9) + rnd.Next(1, 9);
            }
            else if (request.tipoAutomovil == "Pesado")
            {
                placaNumero = "P" + rnd.Next(1, 9) + rnd.Next(1, 9) + rnd.Next(1, 9) + rnd.Next(1, 9) + rnd.Next(1, 9) + rnd.Next(1, 9);
            }

            var plca = Placa.UpdatePlaca(
                request.id,
                request.nombres,
                request.apellidos,
                dNi,
                request.tipoPlaca,
                request.tipoPersonas,
                request.tipoAutomovil,
                request.valorTotalPlaca,
                true,
                request.fechaNacimiento,
                placaNumero);

            _placasRepository.Update(plca);

            await _unitOfWork.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
