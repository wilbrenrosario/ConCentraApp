using Domain.Primitives;
using Domain.ValueObjects;

namespace Domain.Placas;

public sealed class Placas : AggregateRoot
{
    public Placas(PlacasId id, string nombres, string apellidos, DNI cedula, string fechaNacimiento, string tipoPlaca, string tipoPersonas, string tipoAutomovil, double valorTotalPlaca, bool active)
    {
        Id = id;
        Nombres = nombres;
        Apellidos = apellidos;
        Cedula = cedula;
        FechaNacimiento = fechaNacimiento;
        TipoPlaca = tipoPlaca;
        TipoPersonas = tipoPersonas;
        TipoAutomovil = tipoAutomovil;
        ValorTotalPlaca = valorTotalPlaca;
        Active = active;
    }

    private Placas()
    {

    }

    public PlacasId Id { get; private set; }
    public string Nombres { get; private set; } = string.Empty;
    public string Apellidos { get; set; } = string.Empty;
    public string NombreCompleto => $"{Nombres} {Apellidos}";
    public DNI Cedula { get; private set; }
    public string FechaNacimiento { get; private set; } = string.Empty;
    public string TipoPlaca { get; private set; } = string.Empty;
    public string TipoPersonas { get; private set; } = string.Empty; // Fisica o Juridica
    public string TipoAutomovil { get; private set; } = string.Empty; // Publico, Privado, Transporte y Pesado
    public double ValorTotalPlaca { get; private set; } = 0;
    public bool Active { get; private set; }

    public static Placas UpdatePlaca(Guid id, string Nombres, string Apellidos,
    DNI Cedula, string TipoPlaca, string TipoPersonas
        , string TipoAutomovil, double ValorTotalPlaca, bool active, string fechaNacimiento)
    {
        return new Placas(new PlacasId(id), Nombres, Apellidos, Cedula, fechaNacimiento, TipoPlaca, TipoPersonas, TipoAutomovil, ValorTotalPlaca, active);
    }
}