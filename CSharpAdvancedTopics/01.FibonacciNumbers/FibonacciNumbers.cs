using System;

class FibonacciNumbers
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());

        Console.WriteLine(CalcFibonacci(num));
    }

    private static int CalcFibonacci(int n)
    {
        int num1 = 0;
        int num2 = 1;
        int sum = 0;
        int count = 0;
        
        while (count < n)
        {
            sum = num1 + num2;
            num1 = num2;
            num2 = sum;
            count++;
        }

        return num2;
    }
}
