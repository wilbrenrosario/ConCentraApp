using Domain.Placas;
using Domain.Usuario;
using Microsoft.EntityFrameworkCore;

namespace Application.Data
{
    public interface IApplicationDbContext
    {
        DbSet<Placa> Placas { get; set;}
        DbSet<Usuarios> Usuario { get; set;}
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
