using System.ComponentModel;
using System.Data;

int[] size = Console.ReadLine().Split().Select(int.Parse).ToArray();
int rows = size[0];
int cols = size[1];

string[,] matrix = new string[rows, cols];
for (int row = 0; row < rows; row++)
{
	string[] elements = Console.ReadLine().Split().ToArray();
	for (int col = 0; col < cols; col++)
	{
		matrix[row, col] = elements[col];
	}
}

string input;
while ((input = Console.ReadLine()) != "END")
{
	string[] tokens = input.Split().ToArray();

	if (tokens.Length != 5 || tokens[0] != "swap")
	{
		Console.WriteLine("Invalid input!");
		continue;
	}

	string command = tokens[0];
	int row1 = int.Parse(tokens[1]);
	int col1 = int.Parse(tokens[2]);
	int row2 = int.Parse(tokens[3]);
	int col2 = int.Parse((tokens[4]));

	string midValue = "";
	if (command != "swap" || IsValidCoordinate(matrix, row1, col1) == false || IsValidCoordinate(matrix, row2, col2) == false)
	{
		Console.WriteLine("Invalid input!");
	}
	else
	{
		midValue = matrix[row1, col1];
		matrix[row1, col1] = matrix[row2, col2];
		matrix[row2, col2] = midValue;

		for (int row = 0; row < rows; row++)
		{
			for (int col = 0; col < cols; col++)
			{
				Console.Write(matrix[row, col] + " ");
			}
			Console.WriteLine();
		}
	}
}

static bool IsValidCoordinate(string[,] matrix, int row, int col)
{
	if (row < 0 || row >= matrix.GetLength(0) || col < 0 || col >= matrix.GetLength(1))
	{
		return false;
	}
	return true;
}
