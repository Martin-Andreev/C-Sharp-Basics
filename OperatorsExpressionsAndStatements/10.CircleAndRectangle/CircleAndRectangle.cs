using System;

class CircleAndRectangle
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        double x = double.Parse(Console.ReadLine());

        Console.Write("Enter a number: ");
        double y = double.Parse(Console.ReadLine());

        bool inCircle = (Math.Pow(x - 1, 2) + (Math.Pow(y - 1, 2)) <= 1.5 * 1.5);
        bool inRec = (x <= 5 && x >= -1) && (y >= -1 && y <= 1);

        if (inCircle && !inRec)
        {
            Console.WriteLine("Result: Yes");
        }
        else
        {
            Console.WriteLine("Result: No");
        }
    }
}

