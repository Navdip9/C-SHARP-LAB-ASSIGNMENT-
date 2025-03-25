using System;
using System.Collections;

class Program
{
    static void Main()
    {
        Hashtable studentData = new Hashtable();

        studentData.Add(101, "Ajay");
        studentData.Add(102, "Deepa");
        studentData.Add(103, "Yash");
        studentData.Add(104, "Priya");
        studentData.Add(105, "Ravi");

        Console.WriteLine("Student Data (ID and Name):");
        foreach (DictionaryEntry entry in studentData)
        {
            Console.WriteLine("ID: " + entry.Key + ", Name: " + entry.Value);
        }
    }
}
/*
OUTPUT
Student Data (ID and Name):
ID: 101, Name: Ajay
ID: 102, Name: Deepa
ID: 103, Name: Yash
ID: 104, Name: Priya
ID: 105, Name: Ravi
*/
