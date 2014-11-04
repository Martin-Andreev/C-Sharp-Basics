using System;
using System.Collections.Generic;

class CountOfNames
{
    static void Main()
    {
        string input = Console.ReadLine();
        int count = 1;

        List<string> listElements = new List<string>(input.Split(' '));

        listElements.Sort();
        Console.WriteLine();

        for (int i = 0; i < listElements.Count; i++)
        {
            count = 1;

            for (int j = i + 1; j < listElements.Count; j++)
            {
                if (listElements[i] == listElements[j])
                {
                    count++;
                    listElements.Remove(listElements[j]);
                    j--;
                }
            }

            Console.WriteLine("{0} -> {1}", listElements[i], count);
        }

        Console.WriteLine();
    }
}
