int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
int numsToEnque = input[0];
int numsToDeque = input[1];
int wanted = input[2];

int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
Queue<int> queue = new Queue<int>(nums);

for (int i = 0; i < numsToDeque; i++)
{
	queue.Dequeue();
}

if (queue.Contains(wanted))
{
	Console.WriteLine("true");
}
else if (!queue.Contains(wanted) && queue.Count > 0)
{
	Console.WriteLine(queue.Min());
}
else
{
	Console.WriteLine("0");
}
