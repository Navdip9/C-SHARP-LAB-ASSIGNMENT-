using System;

class Program
{
    static void Main()
    {
        Console.Write("Input the string: ");
        string str = Console.ReadLine();
        
        Console.Write("Separated characters: ");
        foreach (char c in str)
        {
            Console.Write(c + " ");
        }
        Console.WriteLine();
    }
}
/*
OUTPUT
Input the string: TnraoCollege 
Separated characters: T n r a o C o l l e g e   
*/