int rows = int.Parse(Console.ReadLine());
int[][] matrix = new int[rows][];

for (int row = 0; row < rows; row++)
{
	int[] elements = Console.ReadLine().Split().Select(int.Parse).ToArray();
	matrix[row] = new int[elements.Length];
	for (int col = 0; col < matrix[row].Length; col++)
	{
		matrix[row][col] = elements[col];
	}
}

for (int row = 0; row < rows - 1; row++)
{
	int[] currentRow = matrix[row];
	int[] nextRow = matrix[row + 1];
	if (currentRow.Length == nextRow.Length)
	{
		for (int col = 0; col < currentRow.Length; col++)
		{
			currentRow[col] *= 2;
			nextRow[col] *= 2;
		}
	}
	else
	{
		for (int i = 0; i < currentRow.Length; i++)
		{
			matrix[row][i] /= 2;
		}
		for (int i = 0; i < nextRow.Length; i++)
		{
			matrix[row + 1][i] /= 2;
		}
	}
}

string input;
while ((input = Console.ReadLine()) != "End")
{
	string[] tokens = input.Split();
	if (tokens.Length > 4)
	{
		continue;
	}
	string command = tokens[0];
	int row = int.Parse(tokens[1]);
	int col = int.Parse(tokens[2]);
	int value = int.Parse(tokens[3]);

	if (row < 0 || col < 0 || row > matrix.GetLength(0) - 1 || col > matrix[row].Length - 1)
	{
		continue;
	}
	else if (command != "Add" && command != "Subtract")
	{

	}

	if (command == "Add")
	{
		matrix[row][col] += value;
	}
	else if (command == "Subtract")
	{
		matrix[row][col] -= value;
	}
}

foreach (var col in matrix)
{
	Console.WriteLine(String.Join(" ", col));
}
