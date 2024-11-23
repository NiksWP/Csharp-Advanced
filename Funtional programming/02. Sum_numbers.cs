using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata.Ecma335;

string[] numbers = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();

Func<string[], int[]> parser = x =>
{
    int[] temp = new int[x.Length];
    for (int i = 0; i < temp.Length; i++)
    {
        temp[i] = int.Parse(x[i]);
    }

    return temp;
};

Action<int[]> printCount = x => Console.WriteLine(x.Length);
Action<int[]> printSum = x => Console.WriteLine(x.Sum());

printCount(parser(numbers));
printSum(parser(numbers));
