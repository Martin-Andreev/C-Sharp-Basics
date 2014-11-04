using System;

class DivideNumbers
{
    static void Main()
    {
        Console.Write("Input a number: ");
        int num = int.Parse(Console.ReadLine());

        bool isCorrect = false;

        if ((num % 5 == 0) && (num % 7 == 0) && (num != 0))
        {
            isCorrect = true;
            Console.WriteLine("Divided by 7 and 5? {0}", isCorrect);
        }

        else
        {
            Console.WriteLine("Divided by 7 and 5? {0}", isCorrect);
        }
    }
}

