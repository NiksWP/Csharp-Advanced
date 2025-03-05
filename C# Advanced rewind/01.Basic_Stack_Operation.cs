namespace C__Advanced_review
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] elements = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int toPush = elements[0];
            int toPop = elements[1];
            int wanted = elements[2];
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < toPush; i++)
            {
                stack.Push(numbers[i]);
            }

            for (int i = 0; i < toPop; i++)
            {
                stack.Pop();
            }

            if (stack.Contains(wanted))
            {
                Console.WriteLine("true");
            }
            else if (stack.Count() == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(stack.OrderBy(x => x).First());
            }
            //Console.WriteLine(String.Join(", ", stack));
        }
    }
}
