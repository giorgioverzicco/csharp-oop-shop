using csharp_oop_shop;

Product product = new Product("Mouse", 80m, 0.22f);

Console.WriteLine(product.GetFullName());
Console.WriteLine(product.GetTaxedPrice());

product.SetName("Keyboard");
product.SetDescription("Cool mechanical keyboard");
product.SetPrice(142.99m);
product.SetVat(0.18f);

Console.WriteLine(product.GetFullName());
Console.WriteLine(product.GetTaxedPrice());