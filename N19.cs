using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the number of terms: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int sum = 0;
        string series = "";
        int currentTerm = 1;
        for (int i = 1; i <= n; i++)
        {
            series += currentTerm;
            sum += currentTerm;
            currentTerm = currentTerm * 10 + 1;
            if (i < n) series += " + ";
        }
        Console.WriteLine(series);
        Console.WriteLine("The Sum is: " + sum);
    }
}

/*
output
Enter the number of terms: 5
1 + 11 + 111 + 1111 + 11111
The Sum is: 12345
*/
