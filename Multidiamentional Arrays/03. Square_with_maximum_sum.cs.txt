int[] sizes = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
int rows = sizes[0];
int cols = sizes[1];

int[,]  matrix = new int[rows, cols];

for (int row = 0; row  < rows; row ++)
{
    int[] numbers = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
	for (int col = 0; col < cols; col++)
	{
		matrix[row, col] = numbers[col];
	}
}

int largestSquare = int.MinValue;
(int rowIndex, int colIndex) largestSquareIndex = (0, 0);
int squareSum = 0;

for (int row = 0; row < rows - 1; row ++)
{
	for (int col = 0; col < cols - 1; col++)
	{
		squareSum = 0;
		int currentNum = matrix[row, col];
		squareSum = currentNum + matrix[row, col + 1]
			+ matrix[row + 1, col]
			+ matrix[row+ 1, col + 1];

		if (squareSum > largestSquare)
		{
			largestSquare = squareSum;
			largestSquareIndex = (row, col); 
		}
	}
}

for (int row = largestSquareIndex.rowIndex; row < largestSquareIndex.rowIndex + 2; row++)
{
	for (int col = largestSquareIndex.colIndex; col < largestSquareIndex.colIndex + 2; col++)
	{
		Console.Write(matrix[row, col] + " ");
	}
	Console.WriteLine();
}
Console.WriteLine(largestSquare);
