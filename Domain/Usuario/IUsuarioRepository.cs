namespace Domain.Usuario;

public interface IUsuarioRepository
{
    Task<Usuarios?> GetByUserAsync(string value);
    void Add(Usuarios usuario);
}