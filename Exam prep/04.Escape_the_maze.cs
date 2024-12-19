using System.Numerics;
using System.Text;

namespace Demost
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int size = int.Parse(Console.ReadLine());
			char[,] matrix = new char[size, size];

			int tRow = 0;
			int tCol = 0;
			for (int row = 0; row < size; row++)
			{
				char[] elements = Console.ReadLine().ToCharArray();
				for (int col = 0; col < size; col++)
				{
					matrix[row, col] = elements[col];
					if (matrix[row, col] == 'P')
					{
						tRow = row;
						tCol = col;
					}
				}
			}

			int health = 100;
			while (true)
			{
				string command = Console.ReadLine();
				if (command == "up" && IsInside(matrix, tRow - 1, tCol))
				{
					matrix[tRow, tCol] = '-';
					tRow--;

					if (matrix[tRow, tCol] == '-')
					{
						matrix[tRow, tCol] = 'P';
					}
					else if (matrix[tRow, tCol] == 'H')
					{
						if (health + 15 <= 100)
						{
							health += 15;
						}
						else
						{
							health = 100;
						}
						matrix[tRow, tCol] = 'P';
					}
					else if (matrix[tRow, tCol] == 'M')
					{
						health -= 40;
						matrix[tRow, tCol] = 'P';
						if (health <= 0)
						{
							Console.WriteLine("Player is dead. Maze over!");
							Console.WriteLine($"Player's health: 0 units");
							PrintMaze(matrix);
							break;
						}
					}
					else if (matrix[tRow, tCol] == 'X')
					{
						matrix[tRow, tCol] = 'P';
						Console.WriteLine("Player escaped the maze. Danger passed!");
						Console.WriteLine($"Player's health: {health} units");
						PrintMaze(matrix);
						break;
					}

				}
				else if (command == "down" && IsInside(matrix, tRow + 1, tCol))
				{
					matrix[tRow, tCol] = '-';
					tRow++;

					if (matrix[tRow, tCol] == '-')
					{
						matrix[tRow, tCol] = 'P';
					}
					else if (matrix[tRow, tCol] == 'H')
					{
						if (health + 15 <= 100)
						{
							health += 15;
						}
						else
						{
							health = 100;
						}
						matrix[tRow, tCol] = 'P';
					}
					else if (matrix[tRow, tCol] == 'M')
					{
						health -= 40;
						matrix[tRow, tCol] = 'P';
						if (health <= 0)
						{
							Console.WriteLine("Player is dead. Maze over!");
							Console.WriteLine($"Player's health: 0 units");
							PrintMaze(matrix);
							break;
						}
					}
					else if (matrix[tRow, tCol] == 'X')
					{
						matrix[tRow, tCol] = 'P';
						Console.WriteLine("Player escaped the maze. Danger passed!");
						Console.WriteLine($"Player's health: {health} units");
						PrintMaze(matrix);
						break;
					}

				}
				else if (command == "left" && IsInside(matrix, tRow, tCol - 1))
				{
					matrix[tRow, tCol] = '-';
					tCol--;

					if (matrix[tRow, tCol] == '-')
					{
						matrix[tRow, tCol] = 'P';
					}
					else if (matrix[tRow, tCol] == 'H')
					{
						if (health + 15 <= 100)
						{
							health += 15;
						}
						else
						{
							health = 100;
						}
						matrix[tRow, tCol] = 'P';
					}
					else if (matrix[tRow, tCol] == 'M')
					{
						health -= 40;
						matrix[tRow, tCol] = 'P';
						if (health <= 0)
						{
							Console.WriteLine("Player is dead. Maze over!");
							Console.WriteLine($"Player's health: 0 units");
							PrintMaze(matrix);
							break;
						}
					}
					else if (matrix[tRow, tCol] == 'X')
					{
						matrix[tRow, tCol] = 'P';
						Console.WriteLine("Player escaped the maze. Danger passed!");
						Console.WriteLine($"Player's health: {health} units");
						PrintMaze(matrix);
						break;
					}

				}
				else if (command == "right" && IsInside(matrix, tRow, tCol + 1))
				{
					matrix[tRow, tCol] = '-';
					tCol++;

					if (matrix[tRow, tCol] == '-')
					{
						matrix[tRow, tCol] = 'P';
					}
					else if (matrix[tRow, tCol] == 'H')
					{
						if (health + 15 <= 100)
						{
							health += 15;
						}
						else
						{
							health = 100;
						}
						matrix[tRow, tCol] = 'P';
					}
					else if (matrix[tRow, tCol] == 'M')
					{
						health -= 40;
						matrix[tRow, tCol] = 'P';
						if (health <= 0)
						{
							Console.WriteLine("Player is dead. Maze over!");
							Console.WriteLine($"Player's health: 0 units");
							PrintMaze(matrix);
							break;
						}
					}
					else if (matrix[tRow, tCol] == 'X')
					{
						matrix[tRow, tCol] = 'P';
						Console.WriteLine("Player escaped the maze. Danger passed!");
						Console.WriteLine($"Player's health: {health} units");
						PrintMaze(matrix);
						break;
					}

				}
			}
		}

		public static bool IsInside(char[,] matrix, int row, int col)
		{
			if (row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix.GetLength(1))
			{
				return true;
			}
			return false;
		}

		public static void PrintMaze(char[,] matrix)
		{
			StringBuilder sb = new StringBuilder();

			for (int row = 0; row < matrix.GetLength(0); row++)
			{
				for (int col = 0; col < matrix.GetLength(1); col++)
				{
					sb.Append(matrix[row, col]);
				}
				sb.Append(Environment.NewLine);
			}
			Console.WriteLine(sb.ToString());
		}
	}
}
