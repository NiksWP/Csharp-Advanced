Dictionary<string, Dictionary<string, List<string>>> townsByCountries = new Dictionary<string, Dictionary<string, List<string>>>();
int commands = int.Parse(Console.ReadLine());
for (int i = 0; i < commands; i++)
{
	string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
	string continent = input[0];
	string country = input[1];
	string city = input[2];
	AddCity(townsByCountries, continent, country, city);
}

foreach (var continent in townsByCountries)
{
	Console.WriteLine($"{continent.Key}:");
	foreach (var country in continent.Value)
	{
		Console.WriteLine($"{country.Key} -> {string.Join(", ", country.Value)}");
	}
}
void AddCity(Dictionary<string, Dictionary<string, List<string>>> townsByCountries, string continent, string country, string city)
{
	if (!townsByCountries.ContainsKey(continent))
	{
		townsByCountries[continent] = new Dictionary<string, List<string>>();
		townsByCountries[continent][country] = new List<string> { city };
		return;
	}
	else if (!townsByCountries[continent].ContainsKey(country))
	{
		townsByCountries[continent][country] = new List<string> { city };
		return;
	}
	townsByCountries[continent][country].Add(city);
}
