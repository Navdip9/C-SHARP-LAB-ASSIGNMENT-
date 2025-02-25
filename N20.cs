using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        int sum = 0;
        Console.Write("The positive divisors are: ");
        for (int i = 1; i <= num / 2; i++)
        {
            if (num % i == 0)
            {
                Console.Write(i + " ");
                sum += i;
            }
        }
        Console.WriteLine();
        Console.WriteLine("The sum of the divisors is: " + sum);

        if (sum == num)
            Console.WriteLine("The number is perfect.");
        else
            Console.WriteLine("The number is not perfect.");
    }
}
/*
output
Enter the number: 56
The positive divisors are: 1 2 4 7 8 14 28 
The sum of the divisors is: 64
The number is not perfect.
*/
