double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();
Dictionary<double, int> numbersMet = new Dictionary<double, int>();

for (int i = 0; i < numbers.Length; i++)
{
	double currentNumber = numbers[i];
	if (!numbersMet.ContainsKey(currentNumber))
	{
		numbersMet.Add(currentNumber, 1);
		continue;
	}
	numbersMet[currentNumber]++;
}

foreach (var number in numbersMet)
{
	Console.WriteLine($"{number.Key} - {number.Value} times");
}
