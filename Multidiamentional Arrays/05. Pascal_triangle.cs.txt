int rows = int.Parse(Console.ReadLine());
long[][] jagged = new long[rows][];

for (int row = 0; row < rows; row++)
{
	jagged[row] = new long[row + 1];
	for (int col = 0; col <= row; col++)
	{
		if (col - 1 < 0 || row - 1 < col)
		{
			jagged[row][col] = 1;
			continue;
		}
		jagged[row][col] = jagged[row - 1][col] + jagged[row - 1][col - 1];
	}
}

foreach (var col in jagged)
{
	Console.WriteLine(String.Join(" ", col));
}
