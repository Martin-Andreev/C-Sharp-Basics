using System;

class MatrixOfPalindromes
{
    static void Main()
    {
        int row = int.Parse(Console.ReadLine());
        int col = int.Parse(Console.ReadLine());
        int count = 0;
        int countMiddle = 0;

        string[] arrLetters = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u",
                       "v", "w", "x", "y", "z"};

        for (int i = 0; i < row; i++)
        {
            countMiddle = count;

            for (int j = 0; j < col; j++)
            {
                Console.Write("{0}{1}{2} ", arrLetters[count], arrLetters[countMiddle], arrLetters[count]);
                countMiddle++;
            }
            Console.WriteLine();
            count++;
        }
    }
}
