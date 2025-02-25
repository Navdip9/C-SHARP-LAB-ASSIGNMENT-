using System;

class Program
{
    static void Main()
    {
       
        Console.Write("Enter a single character: ");
        char character = char.ToLower(Console.ReadKey().KeyChar); // Read character and convert to lowercase
        Console.WriteLine();

  
        switch (character)
        {
            case 'a':
            case 'e':
            case 'i':
            case 'o':
            case 'u':
                Console.WriteLine("The entered character is a vowel.");
                break;
            default:
                Console.WriteLine("The entered character is not a vowel.");
                break;
        }
    }
}

OUTPUT

Enter a single character: A
The entered character is a vowel.


