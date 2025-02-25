using System;

class Employee
{
    public int Emp_ID;
    public string Emp_Name;
    public string Designation;
    public double Salary;
    public double Bonus;
 
    // Constructor to initialize employee details
    public Employee(int id, string name, string designation, double salary)
    {
        Emp_ID = id;
        Emp_Name = name;
        Designation = designation;
        Salary = salary;
        Bonus = 0; // Initializing Bonus to 0
    }

    // Method to calculate bonus using ref for salary
    public void CalculateBonus(ref double salary, out double bonus)
    {
        if (salary < 5000)
        {
            bonus = salary * 0.05; // 5% bonus for salary less than 5000
        }
        else if (salary >= 5000 && salary <= 10000)
        {
            bonus = salary * 0.10; // 10% bonus for salary between 5000 and 10000
        }
        else
        {
            bonus = salary * 0.15; // 15% bonus for salary above 10000
        }

        // Adding bonus to the salary
        salary += bonus;
    }

    // Method to display employee details
    public void DisplayEmployeeDetails()
    {
        Console.WriteLine("\n--- Employee Details ---");
        Console.WriteLine("Employee ID: " + Emp_ID);
        Console.WriteLine("Employee Name: " + Emp_Name);
        Console.WriteLine("Designation: " + Designation);
        Console.WriteLine("Salary (after bonus): " + Salary);
        Console.WriteLine("Bonus: " + Bonus);
    }
}

class Program
{
    static void Main()
    {
        // Accepting employee details from the user
        Console.Write("Enter Employee ID: ");
        int empId = int.Parse(Console.ReadLine());

        Console.Write("Enter Employee Name: ");
        string empName = Console.ReadLine();

        Console.Write("Enter Designation: ");
        string designation = Console.ReadLine();

        Console.Write("Enter Salary: ");
        double salary = double.Parse(Console.ReadLine());

        // Creating employee object
        Employee emp = new Employee(empId, empName, designation, salary);

        // Calculate bonus and update salary
        double bonus;
        emp.CalculateBonus(ref salary, out bonus);
    
        emp.Bonus = bonus;
        emp.Salary = salary;

        // Display employee details
        emp.DisplayEmployeeDetails();
    }
}

/*
Enter Employee ID: 35
Enter Employee Name: NAVDIP
Enter Designation: MANAGER
Enter Salary: 12000

--- Employee Details ---
Employee ID: 35
Employee Name: NAVDIP
Designation: MANAGER
Salary (after bonus): 13800
Bonus: 1800
*/
