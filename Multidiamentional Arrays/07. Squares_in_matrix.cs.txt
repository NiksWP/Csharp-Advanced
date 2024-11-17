int[] sizes = Console.ReadLine().Split().Select(int.Parse).ToArray();
char[,] matrix = new char[sizes[0], sizes[1]];

for (int row = 0; row < sizes[0]; row++)
{
	char[] numbers = Console.ReadLine().Split().Select(char.Parse).ToArray();
	for (int col = 0; col < sizes[1]; col++)
	{
		matrix[row, col] = numbers[col];
	}
}

int sum = 0;
for (int row = 0; row < sizes[0] - 1; row++)
{
	for (int col = 0; col < sizes[1] - 1; col++)
	{
		char currentChar = matrix[row, col];

		if (currentChar == matrix[row, col + 1]
			&& currentChar == matrix[row + 1, col]
			&& currentChar == matrix[row + 1, col + 1])
		{
			sum++;
		}
	}
}

Console.WriteLine(sum);
