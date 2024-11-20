Dictionary<string, Dictionary<string, double>> shopProducts = new Dictionary<string, Dictionary<string, double>>();
string input;
while ((input = Console.ReadLine()) != "Revision")
{
	string[] tokens = input.Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();

	string shopName = tokens[0];
	string product = tokens[1];
	double productPrice = double.Parse(tokens[2]);
	AddProducts(shopProducts, shopName, product, productPrice);
}

shopProducts = shopProducts.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

foreach (var shop in shopProducts)
{
	Console.WriteLine($"{shop.Key}->");
	foreach (var product in shop.Value)
	{
		Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
	}
}
void AddProducts(Dictionary<string, Dictionary<string, double>> shopProducts, string shop, string product, double price)
{
	if (!shopProducts.ContainsKey(shop))
	{
		shopProducts.Add(shop, new Dictionary<string, double>());
		shopProducts[shop].Add(product, price);
		return;
	}
	if (!shopProducts[shop].ContainsKey(product))
	{
		shopProducts[shop].Add(product, price);
	}
}
