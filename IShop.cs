namespace csharp_oop_shop;

public interface IShop
{
    public void Buy(ProductId productId);
    public void Buy(ProductId productId, Quantity quantity);

    public void Add(Product product);
    
    public void Edit(ProductId productId, Product newProduct);
    
    public void Remove(Product product);

    public Product Get(ProductId productId);
}