using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the value of n: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int sum = 0;
        Console.WriteLine("The first {0} natural numbers are:", n);
        for (int i = 1; i <= n; i++)
        {
            Console.Write(i + " ");
            sum += i;
        }
        Console.WriteLine("\nThe Sum of Natural Numbers up to {0} terms: {1}", n, sum);
    }
}

/*
output
Enter the value of n: 7
The first 7 natural numbers are:
1 2 3 4 5 6 7 
The Sum of Natural Numbers up to 7 terms: 28
*/
