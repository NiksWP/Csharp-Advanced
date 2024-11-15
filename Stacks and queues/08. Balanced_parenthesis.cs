using System.Collections.Generic;

while (true)
{
	string input = Console.ReadLine();
	int length = input.Length;

	string firstHalf = String.Empty;
	string secondHalf = String.Empty;
	if (length % 2 == 0)
	{
		firstHalf = input.Substring(0, length / 2);
		secondHalf = input.Substring(length / 2);
	}

	Stack<char> first = new Stack<char>(firstHalf);
	Queue<char> second = new Queue<char>(secondHalf);

	if (IsMatchingPair(first, second))
	{
		Console.WriteLine("YES");
	}
	else
	{
		Console.WriteLine("NO");
	}
}

static bool IsMatchingPair(Stack<char> firstPair, Queue<char> secondPair)
{
	bool perfect = true;
	while (firstPair.Any())
	{
		if (!(firstPair.Peek() == '(' && secondPair.Peek() == ')' ||
			firstPair.Peek() == '{' && secondPair.Peek() == '}' ||
			firstPair.Peek() == '[' && secondPair.Peek() == ']'))
		{
			return false;
		}
		else
		{
			firstPair.Pop();
			secondPair.Dequeue();
		}
	}
	return perfect;
}
