using System;
using System.Globalization;

class DifferenceBetweenDates
{
    static void Main()
    {
        CultureInfo bgBG = new CultureInfo("bg-BG");

        Console.Write("Input the first date: ");
        DateTime firstDate = DateTime.Parse(Console.ReadLine());
        Console.WriteLine();

        Console.Write("Input the second date: ");
        DateTime secondDate = DateTime.Parse(Console.ReadLine());
        Console.WriteLine();

        double days = (secondDate - firstDate).TotalDays;
        Console.WriteLine("Day difference: {0}", days);
    }
}
