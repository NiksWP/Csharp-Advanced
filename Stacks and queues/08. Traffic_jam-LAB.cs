int n = int.Parse(Console.ReadLine());
Queue<string> queue = new Queue<string>();
int counter = 0;

string input;
while ((input = Console.ReadLine()) != "end")
{
	if (input != "green")
	{
		queue.Enqueue(input);
	}
	else
	{
		if (queue.Count >= n)
		{
			for (int i = 0; i < n; i++)
			{
				Console.WriteLine($"{queue.Dequeue()} passed!");
				counter++;
			}
		}
		else
		{
			int count = queue.Count;
			for (int i = 0; i < count; i++)
			{
				Console.WriteLine($"{queue.Dequeue()} passed!");
				counter++;
			}
		}
	}
}

Console.WriteLine($"{counter} cars passed the crossroads.");
