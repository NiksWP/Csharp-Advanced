int n = int.Parse(Console.ReadLine());
Dictionary<int, int> timesMet = new Dictionary<int, int>();

for (int i = 0; i < n; i++)
{
	int currentNum = int.Parse(Console.ReadLine());
	if (!timesMet.ContainsKey(currentNum))
	{
		timesMet.Add(currentNum, 0);
	}
	timesMet[currentNum]++;
}

Console.WriteLine(timesMet.FirstOrDefault(x => x.Value % 2 == 0).Key);
