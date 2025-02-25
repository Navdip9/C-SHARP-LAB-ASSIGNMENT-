using System;

class Program
{
    static void Main()
    {
       
        Console.Write("Enter a decimal number: ");
        float number = float.Parse(Console.ReadLine());

       
        int integerPart = (int)number;

       
        Console.WriteLine($"The integer part of the number is: {integerPart}");
    }
}

OUTPUT

Enter a decimal number: 10.20
The integer part of the number is: 10
