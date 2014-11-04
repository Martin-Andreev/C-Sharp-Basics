using System;

class Trapezoids
{
    static void Main()
    {
        Console.Write("Input the lenght of the base a: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Input the lenght of the base b: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Input the lenght of the height: ");
        double h = double.Parse(Console.ReadLine());

        double result = ((a + b) / 2.0) * h;

        Console.WriteLine("\nThe area of the trapezoid is: {0}", result);
    }
}
