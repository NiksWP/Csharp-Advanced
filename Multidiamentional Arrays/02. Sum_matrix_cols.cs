int[] sizes = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
int rows = sizes[0];
int cols = sizes[1];

int[,] matrix = new int[rows, cols];
int sum = 0;
List<int> sums = new List<int>();

for (int row = 0; row < rows; row++)
{
    int[] elements = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

	for (int col = 0; col < cols; col++)
	{
		matrix[row, col] = elements[col];
	}
}

for (int col = 0; col < cols; col++)
{
	sum = 0;
	for (int row = 0; row < rows; row++)
	{
		sum += matrix[row, col];
	}
	Console.WriteLine(sum);
}

;
