using System;

class LongestAreaInArray
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        string bestWord = "";
        int bestLenght = 1;
        int lenght = 1;
        string[] arrElements = new string[n];

        for (int i = 0; i < arrElements.Length; i++)
        {
            Console.Write("Елемент[{0}]: ", i + 1);
            arrElements[i] = Console.ReadLine();
        }

        bestWord = arrElements[0];

        for (int i = 1; i < arrElements.Length; i++)
        {
            if (arrElements[i - 1] == arrElements[i])
            {
                lenght++;
                if (lenght > bestLenght)
                {
                    bestLenght = lenght;
                    bestWord = arrElements[i];
                }
            }

            else
            {
                lenght = 1;
            }
        }

        Console.WriteLine("\nThe longest sequence of equal elements: {0}", bestLenght);

        for (int i = 0; i < bestLenght; i++)
        {
            Console.WriteLine(bestWord);
        }


    }
}
