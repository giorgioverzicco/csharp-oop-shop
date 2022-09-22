namespace csharp_oop_shop;

public class WineBottle : Bottle
{
    public WineBottle(string name, decimal price, float vat)
        : base(name, price, vat)
    {
    }

    public WineBottle(string name, int quantity, decimal price, float vat)
        : base(name, quantity, price, vat)
    {
    }

    public WineBottle(string name, int quantity, string description, decimal price, float vat)
        : base(name, quantity, description, price, vat)
    {
    }

    public WineBottle(string name, int quantity, decimal price, float vat, float maxCapacity)
        : base(name, quantity, price, vat, maxCapacity)
    {
    }
}