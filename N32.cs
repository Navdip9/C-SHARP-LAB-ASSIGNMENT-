using System;

class SumCalculator
{
    private int sum;

    // Constructor for two integers
    public SumCalculator(int a, int b)
    {
        sum = a + b;
    }

    // Constructor for three integers
    public SumCalculator(int a, int b, int c)
    {
        sum = a + b + c;
    }

    // Method to display the sum
    public void DisplaySum()
    {
        Console.WriteLine("Sum of entered numbers: " + sum);
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        int num2 = int.Parse(Console.ReadLine());

        Console.Write("Do you want to enter a third number? (yes/no): ");
        string choice = Console.ReadLine().ToLower();

        if (choice == "yes")
        {
            Console.Write("Enter third number: ");
            int num3 = int.Parse(Console.ReadLine());

            SumCalculator obj = new SumCalculator(num1, num2, num3);
            obj.DisplaySum();
        }
        else
        {
            SumCalculator obj = new SumCalculator(num1, num2);
            obj.DisplaySum();
        }
    }
}

/*
OUTPUT
Enter first number: 10
Enter second number: 20
Do you want to enter a third number? (yes/no): YES
Enter third number: 30
Sum of entered numbers: 60
*/
