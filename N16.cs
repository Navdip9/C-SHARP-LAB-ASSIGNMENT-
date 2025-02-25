using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the number of terms: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int sum = 0;
        Console.Write("The odd numbers are: ");
        for (int i = 1; i <= n * 2; i += 2)
        {
            Console.Write(i + " ");
            sum += i;
        }
        Console.WriteLine("\nThe Sum of Odd Natural Numbers up to {0} terms: {1}", n, sum);
    }
}

/*
output
Enter the number of terms: 10
The odd numbers are: 1 3 5 7 9 11 13 15 17 19 
The Sum of Odd Natural Numbers up to 10 terms: 100
*/