namespace Domain.ValueObjects;

public partial record DNI
{
    private DNI(string value) => Value = value;

    public static DNI? Create(string value)
    {
        if (string.IsNullOrEmpty(value))
        {
            return null;
        }

        return new DNI(value);
    }

    public string Value { get; init; }
}