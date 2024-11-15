int count = int.Parse(Console.ReadLine());
Stack<char> stack = new Stack<char>();
Stack<char> backUpStack = new Stack<char>();
Stack<Stack<char>> libr = new Stack<Stack<char>>();

int lastCommand = 0;

while (count >= 0)
{
	string[] tokens = Console.ReadLine().Split().ToArray();
	int command = int.Parse(tokens[0]);
	if (command == 1)
	{
		string text = tokens[1];
		backUpStack = new Stack<char>(stack);
		foreach (var item in text)
		{
			stack.Push(item);
		}
	}
	else if (command == 2)
	{
		int numsToDelete = int.Parse(tokens[1]);
		backUpStack = new Stack<char>(stack);
		for (int i = 0; i < numsToDelete; i++)
		{
			stack.Pop();
		}
	}
	else if (command == 3)
	{
		int index = int.Parse(tokens[1]);
		index = stack.Count - index;
		Console.WriteLine(String.Join("", stack)[index]);
	}
	else if (command == 4)
	{
		stack = new Stack<char>(libr.Pop());
	}
	if (command == 1 || command == 2)
	{
		libr.Push(new Stack<char>(backUpStack.Reverse()));
	}

	count--;
}
