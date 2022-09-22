namespace csharp_oop_shop;

public class WaterBottle : Bottle, IRefillable
{
    public WaterBottle(string name, decimal price, float vat) 
        : base(name, price, vat)
    {
    }

    public WaterBottle(string name, int quantity, decimal price, float vat) 
        : base(name, quantity, price, vat)
    {
    }

    public WaterBottle(string name, int quantity, string description, decimal price, float vat) 
        : base(name, quantity, description, price, vat)
    {
    }

    public WaterBottle(string name, int quantity, decimal price, float vat, float maxCapacity) 
        : base(name, quantity, price, vat, maxCapacity)
    {
    }

    public void Refill(float quantity)
    {
        if (Capacity >= MaxCapacity)
            throw new InvalidOperationException("The bottle is already filled.");

        if (Capacity + quantity > MaxCapacity)
            throw new InvalidOperationException("You can't exceed the maximum capacity.");

        Capacity += quantity;
    }
}