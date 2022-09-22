namespace csharp_oop_shop;

public readonly record struct ProductId
{
    private string Value { get; }

    public ProductId(string value)
    {
        if (string.IsNullOrEmpty(value))
            throw new ArgumentException(nameof(value));

        Value = value;
    }
    
    public override string ToString()
    {
        return Value;
    }
}