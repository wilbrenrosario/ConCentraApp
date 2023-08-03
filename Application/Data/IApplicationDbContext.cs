using Domain.Placas;
using Microsoft.EntityFrameworkCore;

namespace Application.Data
{
    public interface IApplicationDbContext
    {
        DbSet<Placa> Placas { get; set;}

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
