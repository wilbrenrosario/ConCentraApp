namespace Domain.Usuario;

public interface IUsuarioRepository
{
    Task<Usuarios?> GetByUserAsync(string usuario, string clave);
    void Add(Usuarios usuario);
}