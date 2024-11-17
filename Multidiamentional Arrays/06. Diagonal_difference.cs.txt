using System.Diagnostics.CodeAnalysis;

int size = int.Parse(Console.ReadLine());
int[,] matrix = new int[size, size];

for (int row = 0; row < size; row++)
{
    int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
    for (int col = 0; col < size; col++)
    {
        matrix[row, col] = numbers[col];
    }
}

int firstDiagonal = 0;
int secondDiagonal = 0;

for (int row = 0; row < size; row++)
{
    for (int col = row; col <= row; col++)
    {
        firstDiagonal += matrix[row, col];
    }
}

for (int i = 0; i < size; i++)
{
    secondDiagonal += matrix[i, size - 1 - i];
}

Console.WriteLine(Math.Abs(firstDiagonal - secondDiagonal));
