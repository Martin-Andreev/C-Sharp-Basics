using System;
using System.Collections.Generic;

class NumbersRandomize
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int element = 0;
        int count = 0;

        Random rnd = new Random();
        List<int> numbers = new List<int>();

        while (count < n)
        {
            element = rnd.Next(n + 1);

            if (!numbers.Contains(element) && element != 0)
            {
                numbers.Add(element);
                count++;
            }   
        }
        foreach (var num in numbers)
        {
            Console.Write("{0} ", num);
        }
        
    }
}
