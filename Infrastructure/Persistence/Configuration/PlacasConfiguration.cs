using Domain.Placas;
using Domain.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configuration
{
    public class PlacasConfiguration : IEntityTypeConfiguration<Placa>
    {
        public void Configure(EntityTypeBuilder<Placa> builder)
        {

           //builder.ToTable("Placas");

           builder.HasKey(c => c.Id);
           builder.Property(c => c.Id).HasConversion(
                placasId => placasId.Value,
                value => new PlacasId(value));


            builder.Property(c => c.Nombres).HasMaxLength(50);

            builder.Property(c => c.Apellidos).HasMaxLength(50);

            builder.Ignore(c => c.NombreCompleto);

            builder.Property(c => c.Cedula).HasConversion(
                cedula => cedula.Value,
                value => DNI.Create(value)!)
                .HasMaxLength(12);

            builder.Property(c => c.FechaNacimiento);
            builder.Property(c => c.TipoPlaca);
            builder.Property(c => c.TipoPersonas);
            builder.Property(c => c.TipoAutomovil);
            builder.Property(c => c.ValorTotalPlaca);

            builder.Property(c => c.Active);

        }
    }
}
