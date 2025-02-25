using System;

class Program
{
    static void Main()
    {
        
        Console.Write("Enter first number: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        int num2 = int.Parse(Console.ReadLine());

      
        int biggest = Math.Max(num1, num2);
        int smallest = Math.Min(num1, num2);

      
        Console.WriteLine($"\nBiggest Number: {biggest}");
        Console.WriteLine($"Smallest Number: {smallest}");
    }
}

OUTPUT

Enter first number: 10
Enter second number: 20

Biggest Number: 20
Smallest Number: 10
