using System;

class Circle
{
    static void Main()
    {
        Console.Write("Input X coordinate: ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Input Y coordinate: ");
        double y = double.Parse(Console.ReadLine());

        bool isCorrect = ((x * x) + (y * y) <= 4);
        Console.WriteLine("Inside? {0}", isCorrect);

        //bool isCorrect = false;

        //if ((x >= -2) && (x <= 2) && (y >= -2) && (y <= 2))
        //{
        //    isCorrect = true;
        //    Console.WriteLine(isCorrect);
        //}
        //else
        //{
        //    Console.WriteLine(isCorrect);
        //}
    }
}
