double[] nums = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
Console.WriteLine(string.Join(Environment.NewLine, nums.Select(n => n += 0.2 * n)
    .Select(x => x.ToString("f2")).ToArray()));