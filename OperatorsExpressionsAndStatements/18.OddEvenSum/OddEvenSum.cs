using System;

class OddEvenSum
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        int oddSum = 0;
        int evenSum = 0;
        int diff = 0;

        for (int i = 1; i <= 2 * num; i++)
        {
            int p = int.Parse(Console.ReadLine());

            if (i % 2 == 0)
            {
                evenSum += p;
            }

            else
            {
                oddSum += p;
            }
        }

        if (oddSum > evenSum)
        {
            diff = oddSum - evenSum;
        }

        if (evenSum > oddSum)
        {
            diff = evenSum - oddSum;
        }

        if (oddSum == evenSum)
        {
            Console.WriteLine("Yes, sum={0}", oddSum);
        }

        else
        {
            Console.WriteLine("No, diff={0}", diff);
        }
    }
}
