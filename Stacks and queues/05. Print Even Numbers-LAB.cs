int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
Queue<int> queue = new Queue<int>(input.Where(x => x % 2 == 0));
Console.WriteLine(String.Join(", ", queue));
