using System.Linq;

int querie = int.Parse(Console.ReadLine());
Stack<int> stack = new Stack<int>();

for (int i = 0; i < queries; i++)
{
	string[] tokens = Console.ReadLine().Split().ToArray();
	int command = int.Parse(tokens[0]);

	if (tokens.Length > 1)
	{
		int num = int.Parse(tokens[1]);
		stack.Push(num);
	}
	else if (command == 2)
	{
		stack.Pop();
	}
	else if (command == 3 && stack.Any())
	{
		Console.WriteLine(stack.Max());
	}
	else if (command == 4 && stack.Any())
	{
		Console.WriteLine(stack.Min());
	}
}

Console.WriteLine(String.Join(", ", stack));
