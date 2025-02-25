using System;

class Program
{
    static void Main()
    {
        
        Console.Write("Enter First Name: ");
        string firstName = Console.ReadLine();

        Console.Write("Enter Father Name: ");
        string fatherName = Console.ReadLine();

        Console.Write("Enter Surname: ");
        string surname = Console.ReadLine();

        string fullName = firstName + " " + fatherName + " " + surname;

        Console.WriteLine("\nFull Name: " + fullName);
    }
}

OUTPUT
Enter First Name: NAVDIP
Enter Father Name: ABC
Enter Surname: TALASANIYA

Full Name: NAVDIP ABC TALASANIYA

