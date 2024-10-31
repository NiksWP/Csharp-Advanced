string[] participants = Console.ReadLine().Split();
Queue<string> queue = new Queue<string>(participants);
int n = int.Parse(Console.ReadLine());

while (queue.Count > 1)
{
	for (int i = 1; i < n; i++)
	{
		queue.Enqueue(queue.Dequeue());
	}
	Console.WriteLine($"Removed {queue.Dequeue()}");
}
Console.WriteLine($"Last is {queue.Dequeue()}");
