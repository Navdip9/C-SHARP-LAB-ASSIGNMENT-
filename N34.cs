using System;

static class Book
{
    // Static fields to store book details
    public static int Book_ID;
    public static string Book_Name;
    public static string Author_Name;
    public static string Issue_Date;

    // Static method to accept book details
    public static void AcceptBookDetails()
    {
        Console.Write("Enter Book ID: ");
        Book_ID = int.Parse(Console.ReadLine());

        Console.Write("Enter Book Name: ");
        Book_Name = Console.ReadLine();

        Console.Write("Enter Author Name: ");
        Author_Name = Console.ReadLine();

        Console.Write("Enter Issue Date (DD/MM/YYYY): ");
        Issue_Date = Console.ReadLine();
    }

    // Static method to display book details
    public static void DisplayBookDetails()
    {
        Console.WriteLine("\n--- Book Details ---");
        Console.WriteLine("Book ID: " + Book_ID);
        Console.WriteLine("Book Name: " + Book_Name);
        Console.WriteLine("Author Name: " + Author_Name);
        Console.WriteLine("Issue Date: " + Issue_Date);
    }
}

class Program
{
    static void Main()
    {
        // Accept book details using the static method
        Book.AcceptBookDetails();

        // Display book details using the static method
        Book.DisplayBookDetails();
    }
}

/*  
OUTPUT
Enter Book ID: 1
Enter Book Name: bhagavad gita
Enter Author Name: Veda Vyasa
Enter Issue Date (DD/MM/YYYY): 22/02/2025

--- Book Details ---
Book ID: 1
Book Name: bhagavad gita
Author Name: Veda Vyasa
Issue Date: 22/02/2025
*/
