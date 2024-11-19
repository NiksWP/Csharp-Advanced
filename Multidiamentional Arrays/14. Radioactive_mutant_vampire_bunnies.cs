using System.Text;

int[] sizes = Console.ReadLine().Split().Select(int.Parse).ToArray();
int rows = sizes[0];
int cols = sizes[1];
char[,] matrix = new char[rows, cols];

int playerRow = 0;
int playerCol = 0;
StringBuilder sb = new StringBuilder();
for (int row = 0; row < rows; row++)
{
	char[] elements = Console.ReadLine().ToArray();
	for (int col = 0; col < cols; col++)
	{
		matrix[row, col] = elements[col];
		sb.Append(matrix[row, col] + " ");
		if (matrix[row, col] == 'P')
		{
			playerRow = row;
			playerCol = col;
		}
	}
	sb.AppendLine();
}

StringBuilder sb2 = new StringBuilder();
bool won = false;
bool died = false;
Queue<char> commands = new Queue<char>(Console.ReadLine().ToArray());
List<(int row, int col)> bunnies = new List<(int row, int col)>();
while (commands.Any())
{
	char command = commands.Dequeue();

	if (command == 'U')
	{
		if (playerRow - 1 < 0)
		{
			won = true;
			matrix[playerRow, playerCol] = '.';
		}
		else
		{
			matrix[playerRow, playerCol] = '.';
			playerRow--;
			if (matrix[playerRow, playerCol] == 'B')
			{
				died = true;
			}
			else
			{
				matrix[playerRow, playerCol] = 'P';
			}
		}
	}
	else if (command == 'D')
	{
		if (playerRow + 1 >= rows)
		{
			won = true;
			matrix[playerRow, playerCol] = '.';
		}
		else
		{
			matrix[playerRow, playerCol] = '.';
			playerRow++;
			if (matrix[playerRow, playerCol] == 'B')
			{
				died = true;
			}
			else
			{
				matrix[playerRow, playerCol] = 'P';
			}
		}
	}
	else if (command == 'L')
	{
		if (playerCol - 1 < 0)
		{
			won = true;
			matrix[playerRow, playerCol] = '.';
		}
		else
		{
			matrix[playerRow, playerCol] = '.';
			playerCol--;
			if (matrix[playerRow, playerCol] == 'B')
			{
				died = true;
			}
			else
			{
				matrix[playerRow, playerCol] = 'P';
			}
		}
	}
	else if (command == 'R')
	{
		if (playerCol + 1 >= cols)
		{
			won = true;
			matrix[playerRow, playerCol] = '.';
		}
		else
		{
			matrix[playerRow, playerCol] = '.';
			playerCol++;
			if (matrix[playerRow, playerCol] == 'B')
			{
				died = true;
			}
			else
			{
				matrix[playerRow, playerCol] = 'P';
			}
		}
	}

	// Start of reproducing

	bunnies.Clear();
	for (int row = 0; row < rows; row++)
	{
		for (int col = 0; col < cols; col++)
		{
			if (matrix[row, col] == 'B')
			{
				bunnies.Add((row, col));
			}
		}
	}

	foreach (var bunny in bunnies)
	{
		int bunnyRow = bunny.row;
		int bunnyCol = bunny.col;

		if (bunnyRow - 1 >= 0)
		{
			if (matrix[bunnyRow - 1, bunnyCol] == 'P')
			{
				died = true;
			}
			matrix[bunnyRow - 1, bunnyCol] = 'B';
		}
		if (bunnyRow + 1 < rows)
		{
			if (matrix[bunnyRow + 1, bunnyCol] == 'P')
			{
				died = true;
			}
			matrix[bunnyRow + 1, bunnyCol] = 'B';
		}
		if (bunnyCol - 1 >= 0)
		{
			if (matrix[bunnyRow, bunnyCol - 1] == 'P')
			{
				died = true;
			}
			matrix[bunnyRow, bunnyCol - 1] = 'B';
		}
		if (bunnyCol + 1 < cols)
		{
			if (matrix[bunnyRow, bunnyCol + 1] == 'P')
			{
				died = true;
			}
			matrix[bunnyRow, bunnyCol + 1] = 'B';
		}
	}

	if (won == true)
	{
		break;
	}
	if (died == true)
	{
		break;
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

if (won == true)
{
	Console.WriteLine($"won: {playerRow} {playerCol}");
}
if (died == true)
{
	Console.WriteLine($"dead: {playerRow} {playerCol}");
}
