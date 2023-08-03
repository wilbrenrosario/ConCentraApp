using Domain.Primitives;
using Domain.Usuario;
using MediatR;

namespace Application.Usuario.Create
{
    public sealed class CreateUsuarioCommandHandler : IRequestHandler<CreateUsuarioCommand, Unit>
    {

        private readonly IUsuarioRepository _usuarioRepository;
        private readonly IUnitOfWork _unitOfWork;

        public CreateUsuarioCommandHandler(IUsuarioRepository usuarioRepository, IUnitOfWork unitOfWork)
        {
            _usuarioRepository = usuarioRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<Unit> Handle(CreateUsuarioCommand request, CancellationToken cancellationToken)
        {
            if (request.clave.Length <= 3)
            {
                throw new ArgumentException(nameof(request.clave));
            }

            var usuario = new Domain.Usuario.Usuarios(
                new UsuarioId(Guid.NewGuid()),
                request.user,
                request.clave
                );

            _usuarioRepository.Add(usuario);

            await _unitOfWork.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
