using System;

class MinMaxSumAndAverage
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int min = int.MaxValue;
        int max = int.MinValue;
        int sum = 0;
        double avg = 0;

        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(Console.ReadLine());

            if (num > max)
            {
                max = num;
            }

            if (num < min)
            {
                min = num;
            }

            sum = sum + num;

            avg = (double)sum / n;
        }

        Console.WriteLine("min = {0} \nmax = {1} \nsum = {2} \navg = {3:F2}", min, max, sum, avg);
    }
}
