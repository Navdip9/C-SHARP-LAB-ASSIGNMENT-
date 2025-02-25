using System;

class ReverseString
{
    static void Main()
    {
        Console.Write("Input a string to reverse: ");
        string input = Console.ReadLine();
        string reversed = "";

        for (int i = input.Length - 1; i >= 0; i--)
        {
            reversed += input[i];  // Append characters in reverse order
        }

        Console.WriteLine("Reversed string is: " + reversed);
    }
}

/*
OUTPUT
Input a string to reverse: Welcome  
Reversed string is: emocleW  
*/
