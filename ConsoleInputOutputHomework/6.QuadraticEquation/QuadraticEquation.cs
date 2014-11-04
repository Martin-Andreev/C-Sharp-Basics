using System;

class QuadraticEquation
{
    static void Main()
    {
        Console.Write("First number: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Second number: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Third number: ");
        double c = double.Parse(Console.ReadLine());

        double D = b * b - 4 * a * c;

        if (D == 0)
        {
            Console.WriteLine("x1 = x2 = {0}", (-b + Math.Sqrt(D)) / (2 * a));
        }
        else if (D < 0 && a > 0)
        {
            Console.WriteLine("no real roots");
        }
        else
        {
            Console.WriteLine("x1 = {0}", (-b - Math.Sqrt(D)) / (2 * a));
            Console.WriteLine("x2 = {0}", (-b + Math.Sqrt(D)) / (2 * a));
        }
    }
}
