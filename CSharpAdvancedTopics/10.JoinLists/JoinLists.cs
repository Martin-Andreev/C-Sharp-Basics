using System;
using System.Collections.Generic;

class JoinLists
{
    static void Main()
    {
        string firstInput = Console.ReadLine();
        string[] arrFirstList = firstInput.Split(' ');

        string secondInput = Console.ReadLine();
        string[] arrSecondList = secondInput.Split(' ');

        List<int> result = new List<int>();
        int count = 0;

        foreach (var num in arrFirstList)
        {
            if (arrFirstList[count] == "")
            {
                continue;
            }

            int element = int.Parse(arrFirstList[count]);
            result.Add(element);
            count++;
        }

        count = 0;

        foreach (var num in arrSecondList)
        {
            if (arrSecondList[count] == "")
            {
                continue;
            }

            int element = int.Parse(arrSecondList[count]);
            result.Add(element);
            count++;
        }

        result.Sort();

        for (int i = 1; i < result.Count; i++)
        {
            if (result[i] == result[i - 1])
            {
                result.Remove(result[i - 1]);
                i--;
            }
        }

        foreach (var num in result)
        {
            Console.Write("{0} ", num);
        }

        Console.WriteLine();
    }
}
