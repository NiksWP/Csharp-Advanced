using System.Text;

namespace ChickenSnack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            char[,] matrix = new char[size, size];
            int enemiesCount = 0;
            int armor = 300;

            int jetRow = 0;
            int jetCol = 0;
            for (int row = 0; row < size; row++)
            {
                char[] elements = Console.ReadLine().ToCharArray();
                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = elements[col];
                    if (elements[col] == 'E')
                    {
                        enemiesCount++;
                    }
                    if (elements[col] == 'J')
                    {
                        jetRow = row;
                        jetCol = col;
                    }
                }
            }

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "up" && IsInside(matrix, jetRow - 1, jetCol))
                {
                    matrix[jetRow, jetCol] = '-';
                    jetRow -= 1;
                    if (matrix[jetRow, jetCol] == 'R')
                    {
                        armor = 300;
                        matrix[jetRow, jetCol] = 'J';
                    }
                    else if (matrix[jetRow, jetCol] == 'E')
                    {
                        if (enemiesCount - 1 == 0)
                        {
                            Console.WriteLine("Mission accomplished, you neutralized the aerial threat!");
                            matrix[jetRow, jetCol] = 'J';
                            PrintMatrix(matrix);
                            break;
                        }
                        if (armor - 100 == 0)
                        {
                            Console.WriteLine($"Mission failed, your jetfighter was shot down! Last coordinates [{jetRow}, {jetCol}]!");
                            matrix[jetRow, jetCol] = 'J';
                            PrintMatrix(matrix);
                            break;
                        }
                        enemiesCount--;
                        armor -= 100;
                    }
                    matrix[jetRow, jetCol] = 'J';
                }
                if (command == "down" && IsInside(matrix, jetRow + 1, jetCol))
                {
                    matrix[jetRow, jetCol] = '-';
                    jetRow += 1;
                    if (matrix[jetRow, jetCol] == 'R')
                    {
                        armor = 300;
                        matrix[jetRow, jetCol] = 'J';
                    }
                    else if (matrix[jetRow, jetCol] == 'E')
                    {
                        if (enemiesCount - 1 == 0)
                        {
                            Console.WriteLine("Mission accomplished, you neutralized the aerial threat!");
                            matrix[jetRow, jetCol] = 'J';
                            PrintMatrix(matrix);
                            break;
                        }
                        if (armor - 100 == 0)
                        {
                            Console.WriteLine($"Mission failed, your jetfighter was shot down! Last coordinates [{jetRow}, {jetCol}]!");
                            matrix[jetRow, jetCol] = 'J';
                            PrintMatrix(matrix);
                            break;
                        }
                        enemiesCount--;
                        armor -= 100;
                    }
                    matrix[jetRow, jetCol] = 'J';
                }
                if (command == "left" && IsInside(matrix, jetRow, jetCol - 1))
                {
                    matrix[jetRow, jetCol] = '-';
                    jetCol -= 1;
                    if (matrix[jetRow, jetCol] == 'R')
                    {
                        armor = 300;
                        matrix[jetRow, jetCol] = 'J';
                    }
                    else if (matrix[jetRow, jetCol] == 'E')
                    {
                        if (enemiesCount - 1 == 0)
                        {
                            Console.WriteLine("Mission accomplished, you neutralized the aerial threat!");
                            matrix[jetRow, jetCol] = 'J';
                            PrintMatrix(matrix);
                            break;
                        }
                        if (armor - 100 == 0)
                        {
                            Console.WriteLine($"Mission failed, your jetfighter was shot down! Last coordinates [{jetRow}, {jetCol}]!");
                            matrix[jetRow, jetCol] = 'J';
                            PrintMatrix(matrix);
                            break;
                        }
                        enemiesCount--;
                        armor -= 100;
                    }
                    matrix[jetRow, jetCol] = 'J';
                }
                if (command == "right" && IsInside(matrix, jetRow, jetCol + 1))
                {
                    matrix[jetRow, jetCol] = '-';
                    jetCol += 1;
                    if (matrix[jetRow, jetCol] == 'R')
                    {
                        armor = 300;
                        matrix[jetRow, jetCol] = 'J';
                    }
                    else if (matrix[jetRow, jetCol] == 'E')
                    {
                        if (enemiesCount - 1 == 0)
                        {
                            Console.WriteLine("Mission accomplished, you neutralized the aerial threat!");
                            matrix[jetRow, jetCol] = 'J';
                            PrintMatrix(matrix);
                            break;
                        }
                        if (armor - 100 == 0)
                        {
                            Console.WriteLine($"Mission failed, your jetfighter was shot down! Last coordinates [{jetRow}, {jetCol}]!");
                            matrix[jetRow, jetCol] = 'J';
                            PrintMatrix(matrix);
                            break;
                        }
                        enemiesCount--;
                        armor -= 100;
                    }
                    matrix[jetRow, jetCol] = 'J';
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
        public static void PrintMatrix(char[,] matrix)
        {
            StringBuilder sb = new StringBuilder();
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    sb.Append(matrix[row, col]);
                }
                sb.AppendLine();
            }
            Console.WriteLine(sb.ToString().TrimEnd());
        }
    }
}
