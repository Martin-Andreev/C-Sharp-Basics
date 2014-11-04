using System;

class NumbersInInterval
{
    static void Main()
    {
        Console.Write("Start: ");
        int start = int.Parse(Console.ReadLine());

        Console.Write("End: ");
        int end = int.Parse(Console.ReadLine());

        int temp = 0;

        for (int i = start; i <= end; i++)
        {
            if (i % 5 == 0)
            {
                temp++;
            }
        }

        Console.WriteLine("Result: {0}", temp);
    }
}
