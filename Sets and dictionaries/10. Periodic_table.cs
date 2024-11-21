int n = int.Parse(Console.ReadLine());
HashSet<string> elements = new HashSet<string>();

for (int i = 0; i < n; i++)
{
	string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
	foreach (var element in input)
	{
		elements.Add(element);
	}
}

Console.WriteLine(string.Join(" ", elements.OrderBy(x => x)));
