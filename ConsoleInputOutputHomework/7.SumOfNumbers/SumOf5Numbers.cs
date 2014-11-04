using System;

class SumOf5Numbers
{
    static void Main()
    {
        string numbers = Console.ReadLine();

        string[] arr = numbers.Split(' ');

        double sumOfNumbers = 0;

        foreach (var num in arr)
        {
            sumOfNumbers += double.Parse(num);
        }

        Console.WriteLine("Result: {0}", sumOfNumbers);
    }
}
