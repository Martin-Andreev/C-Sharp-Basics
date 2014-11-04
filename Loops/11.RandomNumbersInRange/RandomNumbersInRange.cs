using System;

class RandomNumbersInRange
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int min = int.Parse(Console.ReadLine());
        int max = int.Parse(Console.ReadLine());

        Random rnd = new Random();
        Console.WriteLine();

        for (int i = 0; i < n; i++)
        {
            Console.Write("{0} ", rnd.Next(min, max + 1));
        }
    }
}

