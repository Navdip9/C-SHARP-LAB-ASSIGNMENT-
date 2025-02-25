using System;

class SumArrayElements
{
    static void Main()
    {
        Console.Write("Input the number of elements to be stored in the array: ");
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];
        int sum = 0;

        Console.WriteLine($"Input {n} elements in the array:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"element - {i} : ");
            arr[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < n; i++)
        {
            sum += arr[i];  // Add each element to sum
        }

        Console.WriteLine("Sum of all elements stored in the array is: " + sum);
    }
}

/*
OUTPUT
Input the number of elements to be stored in the array: 3  
Input 3 elements in the array:  
element - 0 : 2  
element - 1 : 5  
element - 2 : 8  

Sum of all elements stored in the array is: 15
*/
