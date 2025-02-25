using System;

class Area
{
   

    // Constructor for calculating area of rectangle (length * width)
    public Area(double width, double length)
    {
        double area = width * length;
        Console.WriteLine("Area of rectangle: " + area);
    }

    // Constructor for calculating surface area of box (2 * (length * width + width * height + height * length))
    public Area(double width, double height, double length)
    {
        double surfaceArea = 2 * (length * width + width * height + height * length);
        Console.WriteLine("Surface area of box: " + surfaceArea);
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter length, width, and height:");

        // Accepting user inputs for length, width, and height
        double length = Convert.ToDouble(Console.ReadLine());
        double width = Convert.ToDouble(Console.ReadLine());
        double height = Convert.ToDouble(Console.ReadLine());

        // Using constructor overloading
        
        new Area(width, length);        // Rectangle area
        new Area(width, height, length); // Box surface area
    }
}
/*
OUTPUT
Enter length, width, and height:
5
3
4
Area of rectangle: 15
Surface area of box: 94
*/
