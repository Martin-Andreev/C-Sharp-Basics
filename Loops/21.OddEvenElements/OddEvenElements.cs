using System;

class OddEvenElements
{
    static void Main()
    {
        string inputLine = Console.ReadLine();
        string[] numbers = inputLine.Split(' ');

        if (inputLine == "")
        {
            numbers = new string[0];
        }

        decimal sumOdd = 0;
        decimal minOdd = decimal.MaxValue;
        decimal maxOdd = decimal.MinValue;

        decimal sumEven = 0;
        decimal minEven = decimal.MaxValue;
        decimal maxEven = decimal.MinValue;

        for (int i = 1; i <= numbers.Length; i++)
        {
            decimal element = decimal.Parse(numbers[i - 1]);

            if (i % 2 == 0)
            {
                sumEven = sumEven + element;

                if (element > maxEven)
                {
                    maxEven = element;
                }

                if (element < minEven)
                {
                    minEven = element;
                }
            }

            else
            {
                sumOdd = sumOdd + element;

                if (element > maxOdd)
                {
                    maxOdd = element;
                }

                if (element < minOdd)
                {
                    minOdd = element;
                }
            }
        }

        if (numbers.Length == 0)
        {
            Console.WriteLine("OddSum=No, OddMin=No, OddMax=No, EvenSum=No, EvenMin=No, EvenMax=No");
        }
        else if (numbers.Length == 1)
        {
            Console.WriteLine("OddSum={0}, OddMin={1}, OddMax={2}, EvenSum=No, EvenMin=No, EvenMax=No",
                (double)sumOdd, (double)minOdd, (double)maxOdd);
        }
        else
        {
            Console.WriteLine("OddSum={0}, OddMin={1}, OddMax={2}, EvenSum={3}, EvenMin={4}, EvenMax={5}",
                (double)sumOdd, (double)minOdd, (double)maxOdd, (double)sumEven, (double)minEven, (double)maxEven);
        }
    }
}

