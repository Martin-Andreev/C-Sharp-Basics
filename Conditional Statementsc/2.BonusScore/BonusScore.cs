using System;

class BonusScore
{
    static void Main()
    {
        double num = double.Parse(Console.ReadLine());

        if ((num >= 1) && (num <= 3))
        {
            Console.WriteLine(num * 10);
        }

        else if ((num >= 4) && (num <= 6))
        {
            Console.WriteLine(num * 100);
        }

        else if ((num >= 7) && (num <= 9))
        {
            Console.WriteLine(num * 1000);
        }

        else
        {
            Console.WriteLine("Invalid score!");
        }
    }
}
