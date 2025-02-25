using System;

class DecimalToBinary
{
    static void Main()
    {
        Console.Write("Enter a number to convert: ");
        int num = int.Parse(Console.ReadLine());
        string binary = "";

        while (num > 0)
        {
            binary = (num % 2) + binary;  // Append remainder at the beginning
            num /= 2;  // Divide by 2
        }

        Console.WriteLine("The Binary of the given number is: " + binary);
    }
}

/*
OUTPUT
Enter a number to convert: 25  
The Binary of the given number is: 11001  
*/
