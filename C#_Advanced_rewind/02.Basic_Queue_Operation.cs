namespace C__Advanced_Rewind
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] elements = Console.ReadLine().Split().Select(int.Parse).ToArray();
			int toAdd = elements[0];
			int toRemove = elements[1];
			int wanted = elements[2];
			Queue<int> queue = new();

			int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
			for (int i = 0; i < toAdd; i++)
			{
				queue.Enqueue(numbers[i]);
			}

			for (int i = 0; i < toRemove; i++)
			{
				queue.Dequeue();
			}

			if (queue.Contains(wanted))
			{
				Console.WriteLine("true");
			}
			else if (queue.Count == 0)
			{
				Console.WriteLine('0');
			}
			else
			{
				Console.WriteLine(queue.OrderBy(x => x).First());
			}

		}
	}
}
