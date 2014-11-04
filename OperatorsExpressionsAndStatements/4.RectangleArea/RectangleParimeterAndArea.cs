using System;

class RectangleParimeterAndArea
{
    static void Main()
    {
        Console.Write("Width: ");
        double width = double.Parse(Console.ReadLine());
        Console.Write("Height: ");
        double height = double.Parse(Console.ReadLine());

        double perimeter = 2 * (width + height);
        double area = width * height;

        Console.WriteLine("The perimeter of the rectangle is: {0}", perimeter);
        Console.WriteLine("The area of the rectangle is: {0}", area);
    }
}
