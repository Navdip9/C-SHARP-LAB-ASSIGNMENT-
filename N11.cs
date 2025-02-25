using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter temperature in Celsius: ");
        int temp = Convert.ToInt32(Console.ReadLine());

        if (temp < 0)
            Console.WriteLine("Freezing weather");
        else if (temp <= 10)
            Console.WriteLine("Very Cold weather");
        else if (temp <= 20)
            Console.WriteLine("Cold weather");
        else if (temp <= 30)
            Console.WriteLine("Normal temperature");
        else if (temp <= 40)
            Console.WriteLine("It's Hot");
        else
            Console.WriteLine("It's Very Hot");
    }
}

/*
OUTPUT
Enter temperature in Celsius: 10
Very Cold weather 
*/