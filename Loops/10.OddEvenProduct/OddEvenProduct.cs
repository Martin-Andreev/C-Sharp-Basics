using System;

class OddEvenProduct
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] numbers = input.Split(' ');

        int sumOdd = 1;
        int sumEven = 1;

        for (int i = 1; i <= numbers.Length; i++)
        {
            int element = int.Parse(numbers[i - 1]);

            if (i % 2 == 0)
            {
                sumEven *= element; 
            }

            else
            {
                sumOdd *= element;
            }
        }

        if (sumOdd == sumEven)
        {
            Console.WriteLine("yes \nproduct = {0}", sumEven);
        }

        else
        {
            Console.WriteLine("no \nodd_product = {0} \neven_product = {1}", sumOdd, sumEven);
        }
    }
}
