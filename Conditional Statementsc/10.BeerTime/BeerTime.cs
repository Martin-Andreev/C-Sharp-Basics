using System;

class BeerTime
{
    static void Main()
    {
        Console.Write("Enter time(hh:mm tt): ");
        string now = Console.ReadLine();

        DateTime time = DateTime.Parse(now);

        string designator = time.ToString("tt");

        if (designator == "PM")
        {
            if (time.Hour > 1)
            {
                Console.WriteLine("Beer time!");
            }

            else
            {
                Console.WriteLine("Non-beer time!");
            }
        }

        else
        {
            if (time.Hour < 3)
            {
                Console.WriteLine("Beer time!");
            }

            else
            {
                Console.WriteLine("Non-beer time!");
            }
        }
    }
}
