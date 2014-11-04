using System;

class WorkHours
{
    static void Main(string[] args)
    {
        int requiredHours = int.Parse(Console.ReadLine());
        int daysAvailable = int.Parse(Console.ReadLine());
        double productivity = double.Parse(Console.ReadLine());

        double biking = (double)daysAvailable / 10;

        double daysWork = daysAvailable - biking;

        double result = (int)((daysWork * 12) * (productivity / 100));

        if (result >= requiredHours)
        {
            Console.WriteLine("Yes");
        }

        else
        {
            Console.WriteLine("No");
        }
        Console.WriteLine(result - requiredHours);
    }
}

