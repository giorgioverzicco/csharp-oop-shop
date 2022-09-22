namespace csharp_oop_shop;

public readonly record struct Quantity
{
    public int Value { get; }

    public Quantity(int value)
    {
        if (value <= 0)
            throw new ArgumentException(nameof(value));

        Value = value;
    }
}