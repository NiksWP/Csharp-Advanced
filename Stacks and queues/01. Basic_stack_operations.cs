int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
int numsToPush = input[0];
int numsToPop = input[1];
int wanted = input[2];

int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
Stack<int> stack = new Stack<int>(nums);

for (int i = 0; i < numsToPop; i++)
{
	stack.Pop();
}

if (stack.Contains(wanted))
{
	Console.WriteLine("true");
}
else if (!stack.Contains(wanted) && stack.Count > 0)
{
	Console.WriteLine(stack.Min());
}
else
{
	Console.WriteLine("0");
}
