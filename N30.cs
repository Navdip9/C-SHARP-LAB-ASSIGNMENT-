using System;

class Program
{
    static void Main()
    {
        // Input the string
        Console.Write("Input the string: ");
        string input = Console.ReadLine();

        // Create a new string to store the converted result
        string result = "";

        // Loop through each character in the string
        foreach (char ch in input)
        {
            // Check if the character is a lowercase letter
            if (char.IsLower(ch))
            {
                // Convert to uppercase and add to the result
                result += char.ToUpper(ch);
            }
            // Check if the character is an uppercase letter
            else if (char.IsUpper(ch))
            {
                // Convert to lowercase and add to the result
                result += char.ToLower(ch);
            }
            else
            {
                // If it's neither, just add the character as it is
                result += ch;
            }
        }

        // Output the converted string
        Console.WriteLine("After conversion, the string is: " + result);
    }
}

/*
OUTPUT
Input the string: This is a String 
After conversion, the string is: tHIS IS A sTRING 
*/