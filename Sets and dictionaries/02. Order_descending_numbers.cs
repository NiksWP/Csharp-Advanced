List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

if (numbers.Count < 3)
{
	Console.WriteLine(String.Join(" ", numbers.OrderByDescending(x => x).ToList()));
}
else
{
	Console.WriteLine(String.Join(" ", numbers = numbers.OrderByDescending(x => x).Take(3).ToList()));
}
