using Application.Placas.Common;
using Domain.Placas;
using Domain.Usuario;
using Domain.ValueObjects;
using ErrorOr;
using MediatR;

namespace Application.Usuario.Get
{
    public sealed class GetCommandHandler : IRequestHandler<GetCommand, ErrorOr<Unit>>
    {

        private readonly IUsuarioRepository _usuarioRepository;
        public GetCommandHandler(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository ?? throw new ArgumentNullException(nameof(usuarioRepository));
        }

        public async Task<ErrorOr<Unit>> Handle(GetCommand request, CancellationToken cancellationToken)
        {
            var pla = await _usuarioRepository.GetByUserAsync(request.usuario, request.clave);

            if (pla != null)
            {
                return Unit.Value;
            }
            else
            {
                throw new ArgumentException(nameof(pla));
            }
        }
    }
}
