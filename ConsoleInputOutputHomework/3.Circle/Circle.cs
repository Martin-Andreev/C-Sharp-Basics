using System;

class Circle
{
    static void Main()
    {
        Console.Write("Enter circle's radius: ");
        double radius = double.Parse(Console.ReadLine());

        double area = Math.PI * radius * radius;
        double perimeter = 2 * (Math.PI * radius);

        Console.WriteLine("Perimeter: {0:F2} \nRadius: {1:F2}", perimeter, area);
    }
}
