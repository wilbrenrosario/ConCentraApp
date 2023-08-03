using Domain.ValueObjects;

namespace Domain.Placas;

public interface IPlacasRepository
{
    Task<List<Placas>> GetAll();
    Task<Placas?> GetByDNIAsync(DNI cedula);
    void Add(Placas placas);
    void Update(Placas placas);
    void Delete(Placas placas);
}