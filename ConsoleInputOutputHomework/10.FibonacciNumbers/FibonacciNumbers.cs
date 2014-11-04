using System;

class FibonacciNumbers
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int num = int.Parse(Console.ReadLine());

        int lastNum = 0;
        int nextNum = 1;

        for (int i = 0; i < num; i++)
        {
            int temp = nextNum;
            nextNum += lastNum;

            Console.WriteLine(lastNum);

            lastNum = temp;
        }
    }
}
