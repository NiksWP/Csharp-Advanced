string[] text = Console.ReadLine().Split().ToArray();
Predicate<string> isUpper = word => char.IsUpper(word[0]);
Console.WriteLine(string.Join(Environment.NewLine), text.Where(x => isUpper(x)));
