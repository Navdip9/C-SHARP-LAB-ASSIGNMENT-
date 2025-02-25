using System;

class Program
{
    static void Main()
    {
        // Input the string
        Console.Write("Input the string: ");
        string input = Console.ReadLine();

        // Initialize counters for alphabets, digits, and special characters
        int alphabetCount = 0;
        int digitCount = 0;
        int specialCharCount = 0;

        // Loop through each character in the string
        foreach (char ch in input)
        {
            // Check if the character is an alphabet
            if (char.IsLetter(ch))
            {
                alphabetCount++;
            }
            // Check if the character is a digit
            else if (char.IsDigit(ch))
            {
                digitCount++;
            }
            // If it's neither an alphabet nor a digit, it is a special character
            else
            {
                specialCharCount++;
            }
        }

        // Output the results
        Console.WriteLine("Number of Alphabets in the string is : " + alphabetCount);
        Console.WriteLine("Number of Digits in the string is : " + digitCount);
        Console.WriteLine("Number of Special characters in the string is : " + specialCharCount);
    }
}
/*
OUTPUT
Input the string:Roll No. is : #31
Number of Alphabets in the string is : 8
Number of Digits in the string is : 2
Number of Special characters in the string is : 7
*/
