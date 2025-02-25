using System;

class Program
{
    static void Main()
    {
        
        Console.Write("Enter Student Name: ");
        string studentName = Console.ReadLine();

        Console.Write("Enter Roll No.: ");
        string rollNo = Console.ReadLine();

        Console.Write("Enter Course: ");
        string course = Console.ReadLine();

        
        Console.Write("Enter marks for Fundamental of Computers: ");
        int mark1 = int.Parse(Console.ReadLine());

        Console.Write("Enter marks for Introduction to C Programming: ");
        int mark2 = int.Parse(Console.ReadLine());

        Console.Write("Enter marks for Programming using Java: ");
        int mark3 = int.Parse(Console.ReadLine());

        Console.Write("Enter marks for System Analysis and Designing: ");
        int mark4 = int.Parse(Console.ReadLine());

    
        int totalMarks = mark1 + mark2 + mark3 + mark4;
        float percentage = totalMarks / 4.0f;

       
        string result = percentage >= 40 ? "Pass" : "Fail";

        Console.WriteLine("\nM A R K - S H E E T");
        Console.WriteLine("-----------------------------------------------------");
        Console.WriteLine($"Student Name : {studentName}");
        Console.WriteLine($"Roll No.     : {rollNo}");
        Console.WriteLine($"Course       : {course}");
        Console.WriteLine("-----------------------------------------------------");
        Console.WriteLine("Subjects                        Marks");
        Console.WriteLine("-----------------------------------------------------");
        Console.WriteLine($"Fundamental of Computers       {mark1}");
        Console.WriteLine($"Introduction to C Programming   {mark2}");
        Console.WriteLine($"Programming using Java          {mark3}");
        Console.WriteLine($"System Analysis and Designing   {mark4}");
        Console.WriteLine("-----------------------------------------------------");
        Console.WriteLine($"Total Marks                    {totalMarks}");
        Console.WriteLine("-----------------------------------------------------");
        Console.WriteLine($"Result                         {result}");
        Console.WriteLine($"Percentage                     {percentage:F2}%");
        Console.WriteLine("-----------------------------------------------------");
    }
}

output

Enter Student Name: navdip
Enter Roll No.: 35
Enter Course: bca
Enter marks for Fundamental of Computers: 80
Enter marks for Introduction to C Programming: 95
Enter marks for Programming using Java: 70
Enter marks for System Analysis and Designing: 90

M A R K - S H E E T
-----------------------------------------------------
Student Name : navdip
Roll No.     : 35
Course       : bca
-----------------------------------------------------
Subjects                        Marks
-----------------------------------------------------
Fundamental of Computers       80
Introduction to C Programming   95
Programming using Java          70
System Analysis and Designing   90
-----------------------------------------------------
Total Marks                    335
-----------------------------------------------------
Result                         Pass
Percentage                     83.75%
-----------------------------------------------------
