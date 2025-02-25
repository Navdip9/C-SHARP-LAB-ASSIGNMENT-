using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= num; i++)
        {
            Console.WriteLine("Number is: {0} and cube of {0} is: {1}", i, i * i * i);
        }
    }
}

/*
output
Enter a number: 4
Number is: 1 and cube of 1 is: 1
Number is: 2 and cube of 2 is: 8
Number is: 3 and cube of 3 is: 27
Number is: 4 and cube of 4 is: 64
*/
