int[] cupsArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
int[] bottlesArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
Queue<int> cups = new Queue<int>(cupsArray);
Stack<int> bottles = new Stack<int>(bottlesArray);

bool cupsFinished = false;
bool bottlesFinished = false;
int wastedWatter = 0;
while (true)
{
	int cup = cups.Dequeue();

	while (cup > 0)
	{
		int bottle = bottles.Pop();

		if (bottle > cup)
		{
			wastedWatter += bottle - cup;
			break;
		}
		else if (bottle == cup)
		{
			break;
		}
		cup -= bottle;
	}

	if (cups.Count == 0)
	{
		cupsFinished = true;
		break;
	}
	else if (bottles.Count == 0)
	{
		bottlesFinished = true;
		break;
	}
}

if (cupsFinished)
{
	Console.WriteLine($"Bottles: {string.Join(" ", bottles)}");
	Console.WriteLine($"Wasted litters of water: {wastedWatter}");
}
else if (bottlesFinished)
{
	Console.WriteLine($"Cups: {string.Join(" ", cups)}");
	Console.WriteLine($"Wasted litters of water: {wastedWatter}");
}
