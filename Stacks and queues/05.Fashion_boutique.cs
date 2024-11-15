Stack<int> stack = new Stack<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
int capacity = int.Parse(Console.ReadLine());
int count = 0;
int length = stack.Count;
while (stack.Any())
{
	int currentClothing = stack.Pop();
	for (int i = 0; i < length; i++)
	{
		if (stack.Any() && currentClothing + stack.Peek() <= capacity)
		{
			int nextClothing = stack.Pop();
			currentClothing += nextClothing;
		}
	}
	count++;
}

Console.WriteLine(count);
