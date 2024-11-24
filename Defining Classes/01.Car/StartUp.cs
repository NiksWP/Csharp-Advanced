namespace CarManufacturer;

public class StartUp
{
    static void Main()
    {
        Car myCar = new();
        myCar.Make = "BMW";
        myCar.Model = "730d";
        myCar.Year = 2015;
        Console.WriteLine(myCar.Model);
        Console.WriteLine(myCar.Make);
        Console.WriteLine(myCar.Year);
    }
}
