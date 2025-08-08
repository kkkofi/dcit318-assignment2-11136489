using System;

class Program
{
    static void Main()
    {
        Animal genericAnimal = new Animal();
        Animal dog = new Dog();
        Animal cat = new Cat();

        genericAnimal.MakeSound(); 
        dog.MakeSound();           
        cat.MakeSound();           

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
