using Domain.Placas;
using Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.Repositories
{
    public class PlacasRepository : IPlacasRepository
    {

        private readonly ApplicationDbContext _context;

        public PlacasRepository(ApplicationDbContext applicationDbContext)
        {
            _context = applicationDbContext ?? throw new ArgumentNullException(nameof(applicationDbContext));
        }

        public async void Add(Placa placas) => await _context.Placas.AddAsync(placas);

        public async Task<Placa?> GetByDNIAsync(DNI cedula) => _context.Placas.SingleOrDefault(x => x.Cedula == cedula);

        public async Task<List<Placa>> GetAll() => _context.Placas.ToList();

        public void Delete(Placa placas)
        {
            throw new NotImplementedException();
        }
      
        public void Update(Placa placas)
        {
            throw new NotImplementedException();
        }
    }
}