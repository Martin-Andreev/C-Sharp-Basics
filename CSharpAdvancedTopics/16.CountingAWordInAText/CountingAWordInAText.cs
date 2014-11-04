using System;
using System.Collections.Generic;

class CountingAWordInAText
{
    static void Main()
    {
        string givenWord = Console.ReadLine();
        givenWord = givenWord.ToUpper();
        string text = Console.ReadLine();
        text = text.ToUpper();
        List<string> listElements = new List<string>(text.Split(' ', '.', '!', '?',':',';'));
        int count = 0;

        foreach (var word in listElements)
        {
          if (word.Contains(givenWord))
          {
              count++;
          }
        }

        Console.WriteLine(count);
    }
}
