int n = int.Parse(Console.ReadLine());
Dictionary<string, Dictionary<string, int>> clothes = new Dictionary<string, Dictionary<string, int>>();

for (int i = 0; i < n; i++)
{
	string[] input = Console.ReadLine().Split(" -> ", StringSplitOptions.RemoveEmptyEntries).ToArray();
	string color = input[0];
	string[] cloths = input[1].Split(",", StringSplitOptions.RemoveEmptyEntries).ToArray();

	if (!clothes.ContainsKey(color))
	{
		clothes[color] = new Dictionary<string, int>();
	}

	foreach (var item in cloths)
	{
		if (!clothes[color].ContainsKey(item))
		{
			clothes[color][item] = 0;
		}
		clothes[color][item]++;
	}
}

string[] wantedClothing = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

foreach (var color in clothes)
{
	Console.WriteLine($"{color.Key} clothes:");
	foreach (var clothing in color.Value)
	{
		if (wantedClothing[0] == color.Key && wantedClothing[1] == clothing.Key)
		{
			Console.WriteLine($"* {clothing.Key} - {clothing.Value} (found!)");
			continue;
		}
		Console.WriteLine($"* {clothing.Key} - {clothing.Value}");
	}
}
