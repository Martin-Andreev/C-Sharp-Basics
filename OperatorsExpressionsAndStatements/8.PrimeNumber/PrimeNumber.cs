using System;

class PrimeNumber
{
    static void Main()
    {
        Console.Write("Input a number: ");
        int num = int.Parse(Console.ReadLine());
        
        bool isPrime = false;

        if (num == 1)
        {
            Console.WriteLine("Prime?: {0}", isPrime);
        }

        else if (num == 2 || num == 3)
        {
            isPrime = true;
            Console.WriteLine("Prime?: {0}", isPrime);
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

            Console.WriteLine("Prime?: {0}", isPrime);
        }
    }
}