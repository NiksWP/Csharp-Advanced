using System.Security.Cryptography;

int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
Stack<int> stack = new Stack<int>(nums);

string input;
while ((input = Console.ReadLine().ToLower()) != "end")
{
	string[] tokens = input.Split();
	string command = tokens[0];

	if (command == "add")
	{
		int firstNum = int.Parse(tokens[1]);
		int secondNum = int.Parse(tokens[2]);
		for (int i = 1; i < tokens.Length; i++)
		{
			stack.Push(int.Parse(tokens[i]));
		}
	}
	else
	{
		if (stack.Count >= int.Parse(tokens[1]))
		{
			for (int i = 0; i < int.Parse(tokens[1]); i++)
			{
				stack.Pop();
			}
		}
	}
}

Console.WriteLine($"Sum: {stack.Sum()}");
