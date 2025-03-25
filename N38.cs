using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> studentNames = new List<string>();

        studentNames.Add("Ajay");
        studentNames.Add("Deepa");
        studentNames.Add("Yash");
        studentNames.Add("Priya");
        studentNames.Add("Ravi");

        studentNames.Sort();  
        studentNames.Reverse(); 

        Console.WriteLine("Student names in reverse order:");
        foreach (string name in studentNames)
        {
            Console.WriteLine(name);
        }
    }
}
/*
OUTPUT
Student names in reverse order:
Yash
Ravi
Priya
Deepa
Ajay
*/
