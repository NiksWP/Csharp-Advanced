using System.Text;

int size = int.Parse(Console.ReadLine());
char[,] matrix = new char[size, size];
StringBuilder sb = new StringBuilder();

string[] commands = Console.ReadLine().Split().ToArray(); // up down down

int minerRow = 0;
int minerCol = 0;
int totalCoal = 0;
int initialCoal = 0;
for (int row = 0; row < size; row++)
{
	char[] elements = Console.ReadLine().Split().Select(char.Parse).ToArray();
	for (int col = 0; col < size; col++)
	{
		matrix[row, col] = elements[col];
		sb.Append(matrix[row, col] + " ");
		if (matrix[row, col] == 's')
		{
			minerRow = row;
			minerCol = col;
		}
		else if (matrix[row, col] == 'c')
		{
			totalCoal++;
		}
	}
	sb.AppendLine();
}

initialCoal = totalCoal;
int s = 0;
int coalSum = 0;
for (int i = 0; i < commands.Length; i++)
{
	string command = commands[i];
	if (command == "up")          
	{
		if (minerRow - 1 < 0)
		{
			s++;
			continue;
		}
		matrix[minerRow, minerCol] = '*';
		minerRow--;
		if (matrix[minerRow, minerCol] == 'c')
		{
			totalCoal--;
		}
		else if (matrix[minerRow, minerCol] == 'e')
		{
			Console.WriteLine($"Game over!" + $" ({minerRow}, {minerCol})");
			break;
		}
		matrix[minerRow, minerCol] = 's';
	}
	else if (command == "down")
	{
		if (minerRow + 1 >= size)
		{
			s++;
			continue;
		}
		matrix[minerRow, minerCol] = '*';
		minerRow++;
		if (matrix[minerRow, minerCol] == 'c')
		{
			totalCoal--;
		}
		else if (matrix[minerRow, minerCol] == 'e')
		{
			Console.WriteLine($"Game over!" + $" ({minerRow}, {minerCol})");
			break;
		}
		matrix[minerRow, minerCol] = 's';
	}
	else if (command == "left")
	{
		if (minerCol - 1 < 0)
		{
			s++;
			continue;
		}
		matrix[minerRow, minerCol] = '*';
		minerCol--;
		if (matrix[minerRow, minerCol] == 'c')
		{
			totalCoal--;
		}
		else if (matrix[minerRow, minerCol] == 'e')
		{
			Console.WriteLine($"Game over!" + $" ({minerRow}, {minerCol})");
			break;
		}
		matrix[minerRow, minerCol] = 's';
	}
	else if (command == "right")
	{
		if (minerCol + 1 >= size)
		{
			s++;
			continue;
		}
		matrix[minerRow, minerCol] = '*';
		minerCol++;
		if (matrix[minerRow, minerCol] == 'c')
		{
			totalCoal--;
		}
		else if (matrix[minerRow, minerCol] == 'e')
		{
			Console.WriteLine($"Game over!" + $" ({minerRow}, {minerCol})");
			break;
		}
		matrix[minerRow, minerCol] = 's';
	}
	if (command != "up" && command != "down" && command != "left" && command != "right")
	{
		s++;
		continue;
	}

	if (totalCoal == 0 && initialCoal > 0)
	{
		Console.WriteLine($"You collected all coals!" + $" ({minerRow}, {minerCol})");
		break;
	}
	s++;
}

if (s == commands.Length)
{
	Console.WriteLine($"{totalCoal} coals left. ({minerRow}, {minerCol})");
}
