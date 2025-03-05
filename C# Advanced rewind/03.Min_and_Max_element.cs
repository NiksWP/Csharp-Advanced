namespace C__Advanced_Rewind
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			Stack<int> stack = new Stack<int>();

			while (n > 0)
			{
				int[] elements = Console.ReadLine().Split().Select(int.Parse).ToArray();
				int command = elements[0];

				if (command == 1)
				{
					int number = elements[1];
					stack.Push(number);
				}
				else if (command == 2)
				{
					stack.Pop();
				}
				else if (command == 3 && stack.Any())
				{
					int maxElement = stack.OrderByDescending(x => x).First();
					Console.WriteLine(maxElement);
				}
				else if (command == 4 && stack.Any())
				{
					int minElement = stack.OrderBy(x => x).First();
					Console.WriteLine(minElement);
				}
				n--;
			}

			Console.WriteLine(string.Join(", ", stack));
		}
	}
}
