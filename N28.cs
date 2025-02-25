using System;

class Program
{
    static void Main()
    {
        Console.Write("Input the string: ");
        string str = Console.ReadLine();
        
        
        // Count words in the string
        string[] words = str.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
        Console.WriteLine("Total number of words in the string is: " + words.Length);
    }
}

/*
OUTPUT
Input the string: WelCome to TNRao College
Total number of words in the string is: 4
*/
