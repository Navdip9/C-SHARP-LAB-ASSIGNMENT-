using System;

class Program
{
    static void Main()
    {
    
        Console.Write("Enter the first number: ");
        int num1 = int.Parse(Console.ReadLine());


        Console.Write("Enter the second number: ");
        int num2 = int.Parse(Console.ReadLine());

       
        Console.WriteLine("\nFirst Number:");
        if (num1 == 0)
        {
            Console.WriteLine("The number is Zero.");
        }
        else if (num1 % 2 == 0)
        {
            Console.WriteLine("The number is Even.");
        }
        else
        {
            Console.WriteLine("The number is Odd.");
        }

       
        Console.WriteLine("\nSecond Number:");
        if (num2 == 0)
        {
            Console.WriteLine("The number is Zero.");
        }
        else if (num2 % 2 == 0)
        {
            Console.WriteLine("The number is Even.");
        }
        else
        {
            Console.WriteLine("The number is Odd.");
        }
    }
}

OUTPUT

Enter the first number: 10
Enter the second number: 15

First Number:
The number is Even.

Second Number:
The number is Odd.


