namespace ChickenSnack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int eatenFoods = 0;
            Stack<int> money = new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());

            Queue<int> prices = new Queue<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());

            while (money.Count != 0 && prices.Count != 0)
            {
                int currentMoney = money.Peek();
                int currentPrice = prices.Peek();

                if (currentMoney == currentPrice)
                {
                    money.Pop();
                    prices.Dequeue();
                    eatenFoods++;
                }
                else if (currentMoney > currentPrice)
                {
                    int spare = currentMoney - currentPrice;
                    eatenFoods++;
                    prices.Dequeue();
                    money.Pop();

                    if (money.Any())
                    {
                        money.Push(money.Pop() + spare);
                    }
                }
                else if (currentMoney < currentPrice)
                {
                    prices.Dequeue();
                    money.Pop();
                }
            }

            switch (eatenFoods)
            {
                case >= 4:
                    Console.WriteLine($"Gluttony of the day! Henry ate {eatenFoods} foods.");
                    break;
                case > 1:
                    Console.WriteLine($"Henry ate: {eatenFoods} foods.");
                    break;
                case 1:
                    Console.WriteLine($"Henry ate: 1 food.");
                    break;
                case 0:
                    Console.WriteLine("Henry remained hungry. He will try next weekend again.");
                    break;
                default:
                    break;
            }
        }
    }
}
