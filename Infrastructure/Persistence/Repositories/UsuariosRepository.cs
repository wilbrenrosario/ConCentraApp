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

        public async void Add(Usuarios usuario)
        {
            throw new NotImplementedException();
        }

        public Task<Usuarios?> GetByUserAsync(string value)
        {
            throw new NotImplementedException();
        }
    }
}