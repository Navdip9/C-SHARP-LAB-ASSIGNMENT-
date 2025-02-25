using System;

class Program
{
    static void Main()
    {
        int count = 1;
        for (int i = 1; i <= 4; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(count + " ");
                count++;
            }
            Console.WriteLine();
        }
    }
}
/*
output
1 
2 3 
4 5 6 
7 8 9 10 
*/
