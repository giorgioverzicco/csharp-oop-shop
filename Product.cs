namespace csharp_oop_shop;

public class Product
{
    public int Code { get; }
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public float Vat { get; set; }
    
    public decimal TaxedPrice => Price + (Price * (decimal) Vat);
    public string FormattedCode => Code.ToString().PadLeft(8, '0');
    public string FullName => $"{FormattedCode}-{Name}";

    public Product(string name, decimal price, float vat)
    {
        Code = new Random().Next(1, 99999999);
        Name = name;
        Price = price;
        Vat = vat;
        Description = String.Empty;
    }

    public Product(string name, string description, decimal price, float vat)
        : this(name, price, vat)
    {
        Description = description;
    }
}