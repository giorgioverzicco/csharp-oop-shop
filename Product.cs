namespace csharp_oop_shop;

public abstract class Product
{
    public int Id { get; set; }
    public string Name { get; }
    public string Description { get; }
    public decimal Price { get; }
    public float Vat { get; }
    public int Quantity { get; set; }
    
    public decimal TaxedPrice => Price + (Price * (decimal) Vat);
    public string FormattedId => Id.ToString("D8");
    public string FormattedName => $"{FormattedId} - {Name}";
    
    public Product(string name, decimal price, float vat)
    {
        Id = new Random().Next(1, 99999999);
        Name = name;
        Price = price;
        Vat = vat;
        Description = String.Empty;
        Quantity = 0;
    }
    
    public Product(string name, int quantity, decimal price, float vat)
        : this(name, price, vat)
    {
        Quantity = quantity;
    }

    public Product(string name, int quantity, string description, decimal price, float vat)
        : this(name, quantity, price, vat)
    {
        Description = description;
    }
}