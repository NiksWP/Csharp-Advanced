namespace C__Advanced_Rewind
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int foodAmount = int.Parse(Console.ReadLine());
			Queue<int> orders = new(Console.ReadLine().Split().Select(int.Parse).ToArray());
			Console.WriteLine(orders.OrderByDescending(x => x).First());

			while (true)
			{
				if (foodAmount >= orders.Peek())
				{
					int currentOrder = orders.Dequeue();
					foodAmount -= currentOrder;
				}

				if (orders.Count > 0 && foodAmount < orders.Peek())
				{
					Console.WriteLine($"Orders left: {string.Join(" ", orders)}");
					break;
				}
				if (orders.Count == 0)
				{
					Console.WriteLine("Orders complete");
					break;
				}
			}
		}
	}
}
