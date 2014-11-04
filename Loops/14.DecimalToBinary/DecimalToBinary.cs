using System;
using System.Collections.Generic;

class DecimalToBinary
{
    static void Main()
    {
        Console.Write("Enter decimal number: ");
        int value = int.Parse(Console.ReadLine());

        int numberBase = 2;

        List<int> outputNumber = new List<int>();

        if (value == 0)
        {
            Console.WriteLine(0);
        }

        else
        {
            while (value > 0)
            {
                outputNumber.Add(value % numberBase);
                value = value / numberBase;
            }
            outputNumber.Reverse();

            foreach (var digit in outputNumber)
            {
                Console.Write(digit);
            }
            Console.WriteLine();
        }
    }
}
