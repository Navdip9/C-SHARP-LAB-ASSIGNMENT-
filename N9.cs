using System;

class Program
{
    static void Main()
    {
        
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        Console.Write("Enter your age: ");
        int age = int.Parse(Console.ReadLine());

        
        if (age >= 0 && age <= 1)
        {
            Console.WriteLine($"{name}, You are a Baby.");
        }
        else if (age > 1 && age <= 3)
        {
            Console.WriteLine($"{name}, You are a Toddler.");
        }
        else if (age > 3 && age <= 12)
        {
            Console.WriteLine($"{name}, You are a Child.");
        }
        else if (age > 12 && age <= 18)
        {
            Console.WriteLine($"{name}, You are a Teen.");
        }
        else if (age > 18 && age <= 21)
        {
            Console.WriteLine($"{name}, You are Young.");
        }
        else if (age > 21)
        {
            Console.WriteLine($"{name}, You are an Adult.");
        }
        else
        {
            Console.WriteLine("Invalid age input.");
        }
    }
}

OUTPUT
Enter your name: NAVDIP
Enter your age: 21
NAVDIP, You are Young.

