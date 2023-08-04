using Domain.Primitives;
using Domain.ValueObjects;

namespace Domain.Usuario
{

    public sealed class Usuarios : AggregateRoot
    {

        public Usuarios(UsuarioId id, string usuario, string clave)
        {
            Id = id;
            User = usuario;
            Clave = clave;
        }

        private Usuarios()
        {

        }

        public UsuarioId Id { get; private set; }
        public string User { get; private set; } = string.Empty;
        public string Clave { get; set; } = string.Empty;


    }

}
