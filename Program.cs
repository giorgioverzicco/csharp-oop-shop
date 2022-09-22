using csharp_oop_shop;

Shop shop = new Shop();

var sveva = new WaterBottle("Sveva", 5, 0.30m, 0.22f);
var lete = new WaterBottle("Lete", 10, 0.50m, 0.22f);
var neroDiTroia = new WineBottle("Nero di Troia", 3, 25m, 0.22f);
var barollo = new WineBottle("Barollo", 2, 250m, 0.22f);

shop.Add(sveva);
shop.Add(lete);
shop.Add(neroDiTroia);
shop.Add(barollo);

Console.WriteLine($"Initial Quantity: {barollo.Quantity}");
shop.Buy(new ProductId(barollo.FormattedId));
Console.WriteLine($"After Bought Quantity: {barollo.Quantity}");
Console.WriteLine(barollo.Quantity);

Console.WriteLine($"Initial Capacity: {barollo.Capacity}");
barollo.Drink(0.7f);
Console.WriteLine($"After Drink Capacity: {barollo.Capacity}");