string text = Console.ReadLine();
Dictionary<char, int> elements = new Dictionary<char, int>();

for (int i = 0; i < text.Length; i++)
{
	char currentElement = text[i];
	if (!elements.ContainsKey(currentElement))
	{
		elements.Add(currentElement, 0);
	}
	elements[currentElement]++;
}

elements = elements.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
foreach (var element in elements)
{
	Console.WriteLine($"{element.Key}: {element.Value} time/s");
}
