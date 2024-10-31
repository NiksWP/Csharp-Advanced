string input = Console.ReadLine();
Stack<int> openingIndex = new Stack<int>();
Stack<int> closingIndex = new Stack<int>();
List<string> brackets = new List<string>();

for (int i = 0; i < input.Length; i++)
{
	char currentElement = input[i];
	if (currentElement == '(')
	{
		openingIndex.Push(i);
	}

	if (currentElement == ')')
	{
		string currentBracket = "";
		for (int j = openingIndex.Pop(); j <= i; j++)
		{
			currentBracket += input[j];
		}
		brackets.Add(currentBracket);
	}
}

foreach (var item in brackets)
{
	Console.WriteLine(item);
}
