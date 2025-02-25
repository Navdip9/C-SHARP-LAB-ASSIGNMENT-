using System;

class College
{
    public int RollNo;
    public string StudentName;
    public string BirthDate;
    public int Age;

    // Method to input college details
    public void InputCollegeData()
    {
        Console.Write("Enter Roll No: ");
        RollNo = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Enter Student Name: ");
        StudentName = Console.ReadLine();
        
        Console.Write("Enter Birth Date (DD/MM/YYYY): ");
        BirthDate = Console.ReadLine();
        
        Console.Write("Enter Age: ");
        Age = Convert.ToInt32(Console.ReadLine());
    }

    // Method to display college details
    public void DisplayCollegeData()
    {
        Console.WriteLine("\n--- College Details ---");
        Console.WriteLine("Roll No: " + RollNo);
        Console.WriteLine("Student Name: " + StudentName);
        Console.WriteLine("Birth Date: " + BirthDate);
        Console.WriteLine("Age: " + Age);
    }
}

// Child class inheriting College class
class Student : College
{
    public string Subject1, Subject2, Subject3;
    public int Mark1, Mark2, Mark3;

    // Method to input student-specific data
    public void InputData()
    {
        InputCollegeData(); // Calling parent class method

        Console.Write("Enter Subject 1 Name: ");
        Subject1 = Console.ReadLine();
        Console.Write("Enter Marks for Subject 1: ");
        Mark1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Subject 2 Name: ");
        Subject2 = Console.ReadLine();
        Console.Write("Enter Marks for Subject 2: ");
        Mark2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Subject 3 Name: ");
        Subject3 = Console.ReadLine();
        Console.Write("Enter Marks for Subject 3: ");
        Mark3 = Convert.ToInt32(Console.ReadLine());
    }

    // Method to display student-specific data
    public void DisplayData()
    {
        DisplayCollegeData(); // Calling parent class method

        Console.WriteLine("\n--- Student Marks ---");
        Console.WriteLine(Subject1 + " - Marks: " + Mark1);
        Console.WriteLine(Subject2 + " - Marks: " + Mark2);
        Console.WriteLine(Subject3 + " - Marks: " + Mark3);
    }
}

// Main Class
class Program
{
    static void Main()
    {
        Student s = new Student();
        s.InputData();
        
        Console.WriteLine("\n=== Student Details ===");
        s.DisplayData();
    }
}
/*
output
Enter Roll No: 35
Enter Student Name: Navdip
Enter Birth Date (DD/MM/YYYY): 09/04/2004
Enter Age: 21
Enter Subject 1 Name: c#
Enter Marks for Subject 1: 90
Enter Subject 2 Name: java
Enter Marks for Subject 2: 90
Enter Subject 3 Name: os
Enter Marks for Subject 3: 90

=== Student Details ===

--- College Details ---
Roll No: 35
Student Name: Navdip
Birth Date: 09/04/2004
Age: 21

--- Student Marks ---
c# - Marks: 90
java - Marks: 90
os - Marks: 90
*/