using System;

class PrimeChecker
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());

        Console.WriteLine(IsPrime(num));
    }

    private static bool IsPrime(int num)
    {

        bool isPrime = false;

        if (num == 1)
        {
            return isPrime;
        }

        else if (num == 2 || num == 3)
        {
            isPrime = true;
            return isPrime;
        }

        else
        {
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    isPrime = false;
                    break;
                }

                else
                {
                    isPrime = true;
                }
            }

            return isPrime;
        }
    }
}
