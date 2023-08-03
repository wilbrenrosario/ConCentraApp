using Domain.Usuario;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configuration
{
    public class UsuariosConfiguration : IEntityTypeConfiguration<Usuarios>
    {
        public void Configure(EntityTypeBuilder<Usuarios> builder)
        {

           builder.HasKey(c => c.Id);
           builder.Property(c => c.Id).HasConversion(
                placasId => placasId.Value,
                value => new UsuarioId(value));


            builder.Property(c => c.User).HasMaxLength(50);

            builder.Property(c => c.Clave).HasMaxLength(50);

        }
    }
}
