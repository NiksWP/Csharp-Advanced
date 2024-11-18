using System.Security;

int[] sizes = Console.ReadLine().Split().Select(int.Parse).ToArray();
int rows = sizes[0];
int cols = sizes[1];
int[,] matrix = new int[rows, cols];

for (int row = 0; row < rows; row++)
{
    int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
	for (int col = 0; col < cols; col++)
	{
		matrix[row, col] = numbers[col];
	}
}

int largestSquare = int.MinValue;
(int rowIndex, int colIndex) largestSquareIndex = (0, 0);
for (int row = 0; row < rows - 2; row++)
{
	for (int col = 0; col < cols - 2; col++)
	{
		int currentNum = matrix[row, col];
		int currentMax = 0;

        for (int row1 = row; row1 < row + 3; row1++)
        {
            for (int col1 = col; col1 < col + 3; col1++)
            {
                currentMax += matrix[row1, col1];
            }
        }

		if (currentMax > largestSquare)
		{
			largestSquare = currentMax;
            largestSquareIndex = (row, col);
        }
	}
}

Console.WriteLine($"Sum = {largestSquare}");
for (int row = largestSquareIndex.rowIndex; row < largestSquareIndex.rowIndex + 3; row++)
{
	for (int col = largestSquareIndex.colIndex; col < largestSquareIndex.colIndex + 3; col++)
	{
		Console.Write(matrix[row, col] + " ");
	}
	Console.WriteLine();
}
