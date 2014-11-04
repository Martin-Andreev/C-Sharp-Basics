using System;
using System.Collections.Generic;

class PlayCardChecker
{
    static void Main()
    {
        string inputCard = Console.ReadLine();

        List<string> card = new List<string>();

        card.Add("2");
        card.Add("3");
        card.Add("4");
        card.Add("5");
        card.Add("6");
        card.Add("7");
        card.Add("8");
        card.Add("9");
        card.Add("10");
        card.Add("J");
        card.Add("Q");
        card.Add("K");
        card.Add("A");

        foreach (var item in card)
        {
            if (card.Contains(inputCard.ToString()))
            {
                Console.WriteLine("Yes");
                break;
            }

            else
            {
                Console.WriteLine("No");
                break;
            }
        }
    }
}
