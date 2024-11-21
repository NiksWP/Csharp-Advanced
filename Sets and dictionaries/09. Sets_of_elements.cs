int[] size = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
int n = size[0];
int m = size[1];

HashSet<int> setN = new HashSet<int>();
HashSet<int> setM = new HashSet<int>();
HashSet<int> repeated = new HashSet<int>();
for (int i = 0; i < n; i++)
{
	int currentNum = int.Parse(Console.ReadLine());
	setN.Add(currentNum);
}

for (int i = 0; i < m; i++)
{
	int currentNum = int.Parse(Console.ReadLine());
	setM.Add(currentNum);
}

if (n >= m)
{
	foreach (var num in setN)
	{
		if (setM.Contains(num))
		{
			repeated.Add(num);
		}
	}
}
else
{
	foreach (var num in setM)
	{
		if (setN.Contains(num))
		{
			repeated.Add(num);
		}
	}
}

Console.WriteLine(String.Join(" ", repeated));
