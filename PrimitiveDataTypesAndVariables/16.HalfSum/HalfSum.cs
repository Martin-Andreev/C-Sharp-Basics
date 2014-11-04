using System;

class HalfSum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine()); ;
        int firstHalf = 0;
        int secondHalf = 0;
        int diff = 0;

        for (int i = 1; i <= 2 * n; i++)
        {
            int number = int.Parse(Console.ReadLine());

            if (i <= n)
            {
                firstHalf += number;
            }

            else
            {
                secondHalf += number;
            }
        }

        if (firstHalf > secondHalf)
        {
            diff = firstHalf - secondHalf;
        }

        if (secondHalf > firstHalf)
        {
            diff = secondHalf - firstHalf;
        }

        if (firstHalf == secondHalf)
        {
            Console.WriteLine("Yes, sum={0}", firstHalf);
        }

        else
        {
            Console.WriteLine("No, diff={0}", diff);
        }
    }
}
