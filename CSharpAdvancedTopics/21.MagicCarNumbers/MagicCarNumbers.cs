using System;

class MagicCarNumbers
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        int count = 0;

        char[] numbers = { 'A', 'B', 'C', 'E', 'H', 'K', 'M', 'P', 'T', 'X' };

        for (int num1 = 0; num1 <= 9; num1++)
        {
            for (int num2 = 0; num2 <= 9; num2++)
            {
                for (int num3 = 0; num3 <= 9; num3++)
                {
                    for (int num4 = 0; num4 <= 9; num4++)
                    {
                        if (((num1 == num2) && (num1 == num3) && (num1 == num4)) || ((num2 == num3) && (num2 == num4)) ||
                                    ((num1 == num2) && (num1 == num3)) || ((num1 == num2) && (num3 == num4)) ||
                                    ((num1 == num3) && (num2 == num4)) || ((num1 == num4) && (num2 == num3)))
                        {
                            for (int x = 0; x < numbers.Length; x++)
                            {
                                for (int y = 0; y < numbers.Length; y++)
                                {
                                    string number = "CA" + num1.ToString() + num2.ToString() + num3.ToString() + num4.ToString() +
                                        numbers[x].ToString() + numbers[y].ToString();
                                    int weight = CalcWeight(number);

                                    if (weight == num)
                                    {
                                        count++;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        Console.WriteLine(count);
    }

    private static int CalcWeight(string word)
    {
        int weight = 0;

        foreach (var ch in word)
        {
            switch (ch)
            {
                case 'A': weight += 10; break;
                case 'B': weight += 20; break;
                case 'C': weight += 30; break;
                case 'E': weight += 50; break;
                case 'H': weight += 80; break;
                case 'K': weight += 110; break;
                case 'M': weight += 130; break;
                case 'P': weight += 160; break;
                case 'T': weight += 200; break;
                case 'X': weight += 240; break;
                case '1': weight += 1; break;
                case '2': weight += 2; break;
                case '3': weight += 3; break;
                case '4': weight += 4; break;
                case '5': weight += 5; break;
                case '6': weight += 6; break;
                case '7': weight += 7; break;
                case '8': weight += 8; break;
                case '9': weight += 9; break;
                case '0': weight += 0; break;
            }
        }

        return weight;
    }
}
