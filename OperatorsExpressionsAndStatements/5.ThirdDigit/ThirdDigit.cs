using System;

class ThirdDigit
{
    static void Main()
    {
        Console.Write("Input a number: ");
        int num = Math.Abs(int.Parse(Console.ReadLine()));
        bool isCorrect = false;

        num = num / 100;

        if (num % 10 == 7)
        {
            isCorrect = true;
            Console.WriteLine("Third digit 7? {0}", isCorrect);
        }

        else
        {
            Console.WriteLine("Third digit 7? {0}", isCorrect);
        }
    }
}
