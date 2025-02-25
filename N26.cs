using System;

class Program
{
    static void Main()
    {
        Console.Write("Input the string: ");
        string str = Console.ReadLine();
        
        int length = 0;
        foreach (char c in str)
        {
            length++; // Increment counter for each character
        }
        
        Console.WriteLine("Length of the string is: " + length);
    }
}

/*
output
Input the string: TnraoCollege
Length of the string is: 12
*/