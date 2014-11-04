using System;

class Volleyball
{
    static void Main()
    {
        string yearType = Console.ReadLine();
        int holidays = int.Parse(Console.ReadLine()); ;
        int hometownWeekends = int.Parse(Console.ReadLine()); ;
        bool leap;
        double result = 0;

        double playWeekends = (48 - hometownWeekends) * 3.0 / 4.0;

        double playHolidays = holidays * 2.0 / 3.0;

        result = hometownWeekends + playHolidays + playWeekends;

        if (yearType == "leap")
        {
            result = result + (result * 0.15);
        }

        Console.WriteLine((int)result);
    }
}
