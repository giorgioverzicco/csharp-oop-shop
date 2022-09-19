namespace csharp_oop_shop;

public class Product
{
    private int _code;
    private string _name;
    private string _description;
    private decimal _price;
    private float _vat;

    public Product(string name, decimal price, float vat)
    {
        // _code = new Random().Next(1, 99999999);
        _code = 12;
        _name = name;
        _price = price;
        _vat = vat;
        _description = String.Empty;
    }
    
    public Product(string name, string description, decimal price, float vat)
        : this(name, price, vat)
    {
        _description = description;
    }

    public decimal GetTaxedPrice()
    {
        return _price + (_price * (decimal) _vat);
    }

    public string GetFormattedCode()
    {
        string codeAsString = _code.ToString();
        string formattedCode = String.Empty;
        int padding = 8;

        while (formattedCode.Length < padding - codeAsString.Length)
        {
            formattedCode += '0';
        }

        formattedCode += codeAsString;

        return formattedCode;
    }

    public string GetFullName()
    {
        string paddedCode = GetFormattedCode();
        return $"{paddedCode} - {_name}";
    }

    public int GetCode()
    {
        return _code;
    }

    public string GetName()
    {
        return _name;
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public string GetDescription()
    {
        return _description;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    public decimal GetPrice()
    {
        return _price;
    }

    public void SetPrice(decimal price)
    {
        _price = price;
    }

    public float GetVat()
    {
        return _vat;
    }

    public void SetVat(float vat)
    {
        _vat = vat;
    }

    /*
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
    */
}