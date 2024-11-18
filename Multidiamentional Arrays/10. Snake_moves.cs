int[] sizes = Console.ReadLine().Split().Select(int.Parse).ToArray();
int rows = sizes[0];
int cols = sizes[1];
string word = Console.ReadLine();
Queue<char> queue = new Queue<char>(word);

char[,] matrix = new char[rows, cols];
for (int row = 0; row < rows; row++)
{
	if (row % 2 == 0)
	{
		for (int col = 0; col < cols; col++)
		{
			char current = queue.Dequeue();
			matrix[row, col] = current;
			queue.Enqueue(current);
		}
	}
	else
	{
		for (int col = cols - 1; col >= 0; col--)
		{
			char current = queue.Dequeue();
			matrix[row, col] = current;
			queue.Enqueue(current);
		}
	}
}

for (int row = 0; row < rows; row++)
{
	for (int col = 0; col < cols; col++)
	{
		Console.Write(matrix[row, col]);
	}
	Console.WriteLine();
}
