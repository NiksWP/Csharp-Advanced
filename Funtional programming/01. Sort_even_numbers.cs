int[] sortedNumbers = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
	.Where(n => n % 2 == 0).OrderBy(n => n).ToArray();

Console.WriteLine(String.Join(", ", sortedNumbers));
