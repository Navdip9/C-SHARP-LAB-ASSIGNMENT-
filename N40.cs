using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Stack<string> employeeStack = new Stack<string>();
        
        employeeStack.Push("Ajay");
        employeeStack.Push("Deepa");
        employeeStack.Push("Yash");
        employeeStack.Push("Priya");
        employeeStack.Push("Ravi");

        Console.WriteLine("Employee List:");
        foreach (string employee in employeeStack)
        {
            Console.WriteLine(employee);
        }

    }
}
/*
OUTPUT
Employee List:
Ravi
Priya
Yash
Deepa
Ajay
*/
