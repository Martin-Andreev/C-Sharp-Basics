using System;

class Pairs
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] numbers = input.Split(' ');

        int bestSum = int.MinValue;
        int currentSum = 0;
        int worstSum = int.MaxValue;
        int worstCurr = int.MaxValue;
        int maxdiff = 0;
        int previousSum = 0;
        bool equal = false;

        for (int i = 0; i < numbers.Length - 1; i += 2)
        {
            int firstNum = int.Parse(numbers[i]);
            int secondNum = int.Parse(numbers[i + 1]);

            currentSum = firstNum + secondNum;
            worstCurr = currentSum - previousSum;

            if (currentSum > bestSum)
            {
                bestSum = currentSum;
            }

            if (worstCurr < worstSum)
            {
                worstSum = currentSum;
            }

            if ((currentSum == bestSum) && (currentSum == previousSum))
            {
                equal = true;
            }

            if (numbers.Length == 2)
            {
                equal = true;
            }

            previousSum = currentSum;
            maxdiff = bestSum - worstSum;
        }

        if (equal)
        {
            Console.WriteLine("Yes, value={0}", bestSum);
        }

        else
        {
            Console.WriteLine("No, maxdiff={0}", maxdiff);
        }
    }
}
