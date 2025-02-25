using System;

class ReverseArray
{
    static void Main()
    {
        Console.Write("Input the number of elements to store in the array: ");
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];

        Console.WriteLine($"Input {n} number of elements in the array:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"element - {i} : ");
            arr[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\nThe values stored into the array are:");
        for (int i = 0; i < n; i++)
        {
            Console.Write(arr[i] + " ");
        }

        Console.WriteLine("\nThe values stored into the array in reverse are:");
        for (int i = n - 1; i >= 0; i--)
        {
            Console.Write(arr[i] + " ");
        }
    }
}

/*
OUTPUT
Input the number of elements to store in the array: 3  
Input 3 number of elements in the array:  
element - 0 : 2  
element - 1 : 5  
element - 2 : 7  

The values stored into the array are:  
2 5 7  

The values stored into the array in reverse are:  
7 5 2  
*/
