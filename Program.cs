using csharp_oop_shop;

Product product = new Product("Mouse", 80m, 0.22f);

Console.WriteLine(product.FullName);
Console.WriteLine(product.TaxedPrice);

product.Name = "Keyboard";
product.Description = "Cool mechanical keyboard";
product.Price = 142.99m;
product.Vat = 0.18f;

Console.WriteLine(product.FullName);
Console.WriteLine(product.TaxedPrice);