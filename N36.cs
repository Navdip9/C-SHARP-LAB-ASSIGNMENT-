using System;

class Program
{
    unsafe static void Main()
    {
        int Amount = 100; 
        int* ptr = &Amount; 

        Console.WriteLine("Value of Amount: " + *ptr);
        
        Console.WriteLine("Address of Amount: " + (IntPtr)ptr);
    }
}

/*
output
Value of Amount: 100
Address of Amount: 0x7ffdec7db6ac
*/
