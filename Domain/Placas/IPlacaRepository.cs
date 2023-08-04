using Domain.ValueObjects;

namespace Domain.Placas;

public interface IPlacasRepository
{
    Task<List<Placa>> GetAll();
    Task<Placa?> GetByDNIAsync(DNI cedula);
    void Add(Placa placas);
    void Update(Placa placas);
    void Delete(Placa placas);
}