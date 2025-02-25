using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        int num2 = int.Parse(Console.ReadLine());

        Console.WriteLine($"Sum: {num1 + num2}");
        Console.WriteLine($"Subtraction: {num1 - num2}");
        Console.WriteLine($"Multiplication: {num1 * num2}");
        
        Console.WriteLine($"Division: {num1 / num2}");
    
    }
}

/* OUTPUT

Enter first number: 10
Enter second number: 10
Sum: 20
Subtraction: 0
Multiplication: 100
Division: 1

