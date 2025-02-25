using System;

class ReverseNumber
{
    static void Main()
    {
        Console.Write("Input a number: ");
        int num = int.Parse(Console.ReadLine());
        int reverse = 0;

        while (num > 0)
        {
            int digit = num % 10;  // Extract the last digit
            reverse = reverse * 10 + digit;  // Append digit to reverse
            num /= 10;  // Remove last digit
        }

        Console.WriteLine("The number in reverse order is: " + reverse);
    }
}

/*
OUTPUT
Input a number: 12345  
The number in reverse order is : 54321 
*/

