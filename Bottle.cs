namespace csharp_oop_shop;

public abstract class Bottle 
    : Product, IDrinkable, IDepletable
{
    private float _capacity;
    public float Capacity
    {
        get => _capacity;
        
        protected set
        {
            if (value > _maxCapacity)
                throw new ArgumentException("You can't exceed the maximum capacity");

            _capacity = value < 0f ? 0f : value;
        } 
    }

    private float _maxCapacity;
    public float MaxCapacity
    {
        get => _maxCapacity;
        
        protected init
        {
            if (value > 1.5f)
                throw new ArgumentException("You can't exceed 1.5L of capacity.");
            
            _maxCapacity = value;
        }
    }

    protected Bottle(string name, decimal price, float vat) 
        : base(name, price, vat)
    {
    }

    protected Bottle(string name, int quantity, decimal price, float vat) 
        : base(name, quantity, price, vat)
    {
    }

    protected Bottle(string name, int quantity, string description, decimal price, float vat) 
        : base(name, quantity, description, price, vat)
    {
    }
    
    protected Bottle(string name, int quantity, decimal price, float vat, float maxCapacity)
        : base(name, quantity, price, vat)
    {
        MaxCapacity = maxCapacity;
    }
    
    protected Bottle(string name, int quantity, string description, decimal price, float vat, float maxCapacity)
        : base(name, quantity, description, price, vat)
    {
        MaxCapacity = maxCapacity;
    }

    public void Drink(float quantity)
    {
        Capacity -= quantity;
    }

    public void Deplete()
    {
        if (Capacity <= 0f)
            throw new InvalidOperationException("You can't deplete an empty bottle.");

        Capacity = 0f;
    }
}