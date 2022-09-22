namespace csharp_oop_shop;

public class Shop : IShop
{
    private List<Product> _products;

    public Shop()
    {
        _products = new List<Product>();
    }
    
    public void Buy(ProductId productId)
    {
        Product product = Get(productId);
        product.Quantity--;
    }

    public void Buy(ProductId productId, Quantity quantity)
    {
        Product product = Get(productId);

        if (product.Quantity - quantity.Value < 0)
            throw new InvalidOperationException("Not enough quantity.");
        
        product.Quantity -= quantity.Value;
    }

    public void Add(Product product)
    {
        if (_products.Contains(product))
            throw new InvalidOperationException("This product is already in the shop.");
        
        _products.Add(product);
    }

    public void Edit(ProductId productId, Product newProduct)
    {
        Product oldProduct = Get(productId);
        newProduct.Id = oldProduct.Id;
        
        int oldProductIdx = _products.IndexOf(oldProduct);
        _products[oldProductIdx] = newProduct;
    }

    public void Remove(Product product)
    {
        if (!_products.Contains(product))
            throw new InvalidOperationException("This product is not in the shop.");
        
        _products.Remove(product);
    }

    public Product Get(ProductId productId)
    {
        Product? product = _products.Find(x => x.FormattedId == productId.ToString());

        if (product is null)
            throw new InvalidOperationException("This product does not exists.");

        return product;
    }
}