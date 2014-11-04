using System;
using System.Collections.Generic;

class RemoveNames
{
    static void Main()
    {
        string firstInput = Console.ReadLine();
        string[] firstList = firstInput.Split(' ');

        string secondInput = Console.ReadLine();
        string[] secondList = secondInput.Split(' ');

        List<string> result = new List<string>();
        bool correct = false;

        for (int i = 0; i < firstList.Length; i++)
        {
            for (int j = 0; j < secondList.Length; j++)
            {
                if (firstList[i] == secondList[j])
                {
                    correct = false;
                    break;
                }

                correct = true;
            }

            if (correct)
            {
                result.Add(firstList[i]);
            }
        }

        foreach (var word in result)
        {
            Console.Write("{0} ", word);
        }

        Console.WriteLine();
    }
}
