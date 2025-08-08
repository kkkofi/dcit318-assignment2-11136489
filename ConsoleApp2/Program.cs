using System;

class Program
{
    static void Main()
    {
        IMovable car = new Car();
        IMovable bicycle = new Bicycle();

        car.Move();
        bicycle.Move();

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
