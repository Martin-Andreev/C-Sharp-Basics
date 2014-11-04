using System;

class CountОfLetters
{
    static void Main()
    {
        string userInput = Console.ReadLine();
        int[] characters = new int[65536];
        Console.WriteLine();

        foreach (char currentCharacter in userInput)
        {
            characters[currentCharacter]++;
        }
        for (int i = 0; i < characters.Length; i++)
        {
            char currentCharacter = (char)i;
            if (char.IsLetter(currentCharacter) && characters[i] != 0)
            {
                Console.WriteLine("{0} -> {1} times", currentCharacter, characters[i]);
            }
        }
    }
}

//using System;

//class CountОfLetters
//{
//    static void Main()
//    {
//        string userInput = Console.ReadLine();
//        int[] characters = new int[65536];
//        Console.WriteLine();
//        int count = 0;

//        for (int i = 0; i < characters.Length; i++)
//        {
//            char currentCharacter = (char)i;
//            if (char.IsLetter(currentCharacter) && characters[i] == currentCharacter)
//            {
//                count++;
//            }
//        }

//        Console.WriteLine(count);
//    }
//}