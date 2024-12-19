namespace ExamProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> powers = new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());
            Queue<int> accuracies = new Queue<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());

            int goals = 0;
            while (powers.Any() && accuracies.Any())
            {
                int power = powers.Peek();
                int accuracy = accuracies.Peek();
                int sum = power + accuracy;

                if (sum == 100)
                {
                    powers.Pop();
                    accuracies.Dequeue();
                    goals++;
                    continue;
                }

                if (sum < 100)
                {
                    if (power == accuracy)
                    {
                        int summation = power + accuracy;
                        powers.Pop();
                        powers.Push(summation);
                        accuracies.Dequeue();
                    }
                    else if (power < accuracy)
                    {
                        powers.Pop();
                    }
                    else if (power > accuracy)
                    {
                        accuracies.Dequeue();
                    }
                }
                else
                {
                    power -= 10;
                    powers.Pop();
                    powers.Push(power);
                    accuracies.Enqueue(accuracies.Dequeue());
                }
            }

            if (goals == 3)
            {
                Console.WriteLine($"Paul scored a hat-trick!");
            }
            else if (goals == 0)
            {
                Console.WriteLine($"Paul failed to score a single goal.");
            }
            else if (goals > 3)
            {
                Console.WriteLine("Paul performed remarkably well!");
            }
            else if (goals > 0 && goals < 3)
            {
                Console.WriteLine("Paul failed to make a hat-trick.");
            }

            if (goals != 0)
            {
                Console.WriteLine($"Goals scored: {goals}");
            }

            if (powers.Any())
            {
                Console.WriteLine($"Strength values left: {string.Join(", ", powers)}");
            }
            if (accuracies.Any())
            {
                Console.WriteLine($"Accuracy values left: {string.Join(", ", accuracies)}");
            }
        }
    }
}
