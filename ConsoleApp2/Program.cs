using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("=== DCIT 318 - Assignment 2 ===");
            Console.WriteLine("1. Inheritance & Method Overriding (Animal Sounds)");
            Console.WriteLine("2. Abstract Classes & Methods (Shape Areas)");
            Console.WriteLine("3. Interfaces (Movable Vehicles)");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an option (1-4): ");

            string choice = Console.ReadLine();
            Console.Clear();

            switch (choice)
            {
                case "1":
                    RunTask1();
                    break;
                case "2":
                    RunTask2();
                    break;
                case "3":
                    RunTask3();
                    break;
                case "4":
                    Console.WriteLine("Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid option. Press any key to try again...");
                    Console.ReadKey();
                    break;
            }
        }
    }

    static void RunTask1()
    {
        Console.WriteLine("=== Task 1: Inheritance & Method Overriding ===");
        Animal genericAnimal = new Animal();
        Animal dog = new Dog();
        Animal cat = new Cat();

        genericAnimal.MakeSound();
        dog.MakeSound();
        cat.MakeSound();

        Pause();
    }

    static void RunTask2()
    {
        Console.WriteLine("=== Task 2: Abstract Classes & Methods ===");
        Shape circle = new Circle(5);
        Shape rectangle = new Rectangle(4, 6);

        Console.WriteLine($"Circle Area: {circle.GetArea():F2}");
        Console.WriteLine($"Rectangle Area: {rectangle.GetArea():F2}");

        Pause();
    }

    static void RunTask3()
    {
        Console.WriteLine("=== Task 3: Interfaces ===");
        IMovable car = new Car();
        IMovable bicycle = new Bicycle();

        car.Move();
        bicycle.Move();

        Pause();
    }

    static void Pause()
    {
        Console.WriteLine("\nPress any key to return to the menu...");
        Console.ReadKey();
    }
}
