int food = int.Parse(Console.ReadLine());
Queue<int> queue = new Queue<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());

int biggestOrder = int.MinValue;
Console.WriteLine(queue.Max());
while (queue.Any())
{
	if (food < queue.Peek())
	{
		Console.WriteLine($"Orders left: {string.Join(" ", queue)}");
		break;
	}
	else
	{
		int order = queue.Dequeue();
		if (order > biggestOrder)
		{
			biggestOrder = order;
		}
		food -= order;
	}
}

if (queue.Count == 0)
{
	Console.WriteLine("Orders complete");
}
