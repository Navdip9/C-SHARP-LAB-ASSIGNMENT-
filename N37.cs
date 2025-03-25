using System;

class Program
{
    public delegate int SumDelegate(int a1, int a2);
    public static int sum(int a1, int a2)
    {
        return a1 + a2;
    }

    static void Main()
    {
        SumDelegate sumDelegate = new SumDelegate(sum);

        int result = sumDelegate(10, 20);

        Console.WriteLine("The sum : " + result);
    }
}
/*
OUTPUT
The sum : 30
*/
