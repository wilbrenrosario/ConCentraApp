namespace Domain.ValueObjects;

public partial record DNI
{
    public DNI(string dNi)
    {
        Cedula = dNi;
    }

    public string Cedula { get; init; }

    public static DNI? Create(string value)
    {
        if (string.IsNullOrEmpty(value))
        {
            return null;
        }

        return new DNI(value);
    }
}