using System;
using System.Collections.Generic;

class LongestWordInAText
{
    static void Main()
    {
        string input = Console.ReadLine();
        string longestWord = "";

        List<string> listElements = new List<string>(input.Split(' '));

        foreach (var word in listElements)
        {
            if (word.Length > longestWord.Length)
            {
                longestWord = word;
            }
        }

        Console.WriteLine("The longest word is: {0}", longestWord);
    }
}
