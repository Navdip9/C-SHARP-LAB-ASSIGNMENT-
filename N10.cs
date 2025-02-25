using System;

class Program
{
    static void Main()
    {
        
        Console.Write("Enter Customer ID: ");
        string customerId = Console.ReadLine();

        Console.Write("Enter Customer Name: ");
        string customerName = Console.ReadLine();

        Console.Write("Enter Units Consumed: ");
        double unitsConsumed = double.Parse(Console.ReadLine());

        
        double totalAmount = 0;

     
        if (unitsConsumed <= 199)
        {
            totalAmount = unitsConsumed * 1.20;
        }
        else if (unitsConsumed >= 200 && unitsConsumed < 400)
        {
            totalAmount = unitsConsumed * 1.50;
        }
        else if (unitsConsumed >= 400 && unitsConsumed < 600)
        {
            totalAmount = unitsConsumed * 1.80;
        }
        else if (unitsConsumed >= 600)
        {
            totalAmount = unitsConsumed * 2.00;
        }


        if (totalAmount > 400)
        {
            totalAmount += totalAmount * 0.15; 
        }

        
        if (totalAmount < 100)
        {
            totalAmount = 100;
        }

        
        Console.WriteLine("\nELECTRICITY BILL");
        Console.WriteLine("--------------------------------");
        Console.WriteLine($"Customer ID       : {customerId}");
        Console.WriteLine($"Customer Name     : {customerName}");
        Console.WriteLine($"Units Consumed    : {unitsConsumed}");
        Console.WriteLine($"Total Amount      : Rs. {totalAmount:F2}");
        Console. WriteLine("--------------------------------");
    }
}

OUTPUT

Enter Customer ID: 1
Enter Customer Name: NAVDIP
Enter Units Consumed: 600

ELECTRICITY BILL
--------------------------------
Customer ID       : 1
Customer Name     : NAVDIP
Units Consumed    : 600
Total Amount      : Rs. 1380.00
--------------------------------

