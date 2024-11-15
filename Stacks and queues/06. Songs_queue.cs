string[] songs = Console.ReadLine().Split(", ").ToArray();
Queue<string> queue = new Queue<string>(songs);

while (queue.Any())
{
	string[] input = Console.ReadLine().Split().ToArray();
	string command = input[0];
	string name = String.Join(" ", input.Skip(1));

	if (command == "Play")
	{
		queue.Dequeue();
	}
	else if (command == "Add")
	{
		if (queue.Contains(name))
		{
			Console.WriteLine($"{name} is already contained!");
		}
		else
		{
			queue.Enqueue(name);
		}
	}
	else if (command == "Show")
	{
		Console.WriteLine(String.Join(", ", queue));
	}
}

Console.WriteLine("No more songs!");
