using Domain.Usuario;

namespace Infrastructure.Persistence.Repositories
{
    public class UsuariosRepository : IUsuarioRepository
    {

        private readonly ApplicationDbContext _context;

        public UsuariosRepository(ApplicationDbContext applicationDbContext)
        {
            _context = applicationDbContext ?? throw new ArgumentNullException(nameof(applicationDbContext));
        }

        public async void Add(Usuarios usuario) =>  _context.Usuario.Add(usuario);

        public async Task<Usuarios?> GetByUserAsync(string usuario, string clave) => _context.Usuario.SingleOrDefault(x => x.User == usuario && x.Clave == clave);
    }
}