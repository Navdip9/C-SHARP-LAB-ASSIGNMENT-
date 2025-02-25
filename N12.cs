using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter month number: ");
        int month = Convert.ToInt32(Console.ReadLine());

        switch (month)
        {
            case 1: case 3: case 5: case 7: case 8: case 10: case 12:
                Console.WriteLine("Month has 31 days");
                break;
            case 4: case 6: case 9: case 11:
                Console.WriteLine("Month has 30 days");
                break;
            case 2:
                Console.WriteLine("Month has 28 or 29 days (Leap year)");
                break;
            default:
                Console.WriteLine("Invalid month number");
                break;
        }
    }
}

/*
output

Enter month number: 7
Month has 31 days
*/
