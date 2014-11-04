using System;

class OddOrEven
{
    static void Main()
    {
        Console.WriteLine("Enter number: ");
        int num = int.Parse(Console.ReadLine());

        int count = 0;
        int mask = 1;

        while (num > 0)
        {
            if (num >> num - 1 == 1)
            {
                count++;
            }
            num = num / 10;
        }

        Console.WriteLine(count);
        //Console.Write("Input a number: ");
        //int num = int.Parse(Console.ReadLine());

        //bool isOdd = false;

        //if (num % 2 == 0)
        //{
        //    Console.Write("Odd? {0}", isOdd);
        //}

        //else
        //{
        //    isOdd = true;
        //    Console.Write("Odd? {0}", isOdd);
        //}
        //Console.WriteLine();
    }
}
