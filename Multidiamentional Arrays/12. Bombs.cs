using System.Text;

int size = int.Parse(Console.ReadLine());
int[,] matrix = new int[size, size];

for (int row = 0; row < size; row++)
{
	int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
	for (int col = 0; col < size; col++)
	{
		matrix[row, col] = numbers[col];
	}
}
int[] bombs = Console.ReadLine().Split(' ', ',').Select(int.Parse).ToArray();

for (int i = 0; i < bombs.Length - 1; i += 2)
{
	int targetRow = bombs[i];
	int targetCol = bombs[i + 1];
	int value = matrix[targetRow, targetCol];

	if (matrix[targetRow, targetCol] <= 0)
	{
		continue;
	}

	for (int row = targetRow - 1; row <= targetRow + 1; row++)
	{
		for (int col = targetCol - 1; col <= targetCol + 1; col++)
		{
			if (IsInside(matrix, row, col) && matrix[row, col] > 0)
			{
				matrix[row, col] -= value;
			}
		}
	}
}

int aliveCells = 0;
int sum = 0;

StringBuilder sb = new StringBuilder();
for (int row = 0; row < size; row++)
{
	for (int col = 0; col < size; col++)
	{
		if (matrix[row, col] > 0)
		{
			aliveCells++;
			sum += matrix[row, col];
		}
		sb.Append(matrix[row, col] + " ");
	}
	sb.AppendLine();
}

Console.WriteLine($"Alive cells: {aliveCells}");
Console.WriteLine($"Sum: {sum}");
Console.WriteLine(sb);

bool IsInside(int[,] matrix, int row, int col)
{
	return row >= 0 && row < matrix.GetLength(0)
		&& col >= 0 && col < matrix.GetLength(1);
}
