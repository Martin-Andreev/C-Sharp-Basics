using System;

class ProgrammerDNA
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string letter = Console.ReadLine();
        int count = 0;
        bool ascending = false;

        switch (letter)
        {
            case "A": count = 0;
                break;
            case "B": count = 1;
                break;
            case "C": count = 2;
                break;
            case "D": count = 3;
                break;
            case "E": count = 4;
                break;
            case "F": count = 5;
                break;
            case "G": count = 6;
                break;
        }

        int dots = 3;

        string[] letters = new string[] { "A", "B", "C", "D", "E", "F", "G" };

        for (int i = 0; i < n; i++)
        {
            if (ascending == false)
            {
                do
                {
                    Console.Write(new string('.', dots));
                    for (int j = 0; j < 7 - (dots * 2); j++)
                    {
                        Console.Write(letters[count]);
                        count++;

                        if (count > 6)
                        {
                            count = 0;
                        }
                    }

                    Console.WriteLine(new string('.', dots));

                    i++;
                    dots--;

                    if (i == n)
                    {
                        return;
                    }

                } while (dots != 0);

                for (int j = 0; j < 7; j++)
                {
                    Console.Write(letters[count]);
                    count++;

                    if (count > 6)
                    {
                        count = 0;
                    }
                }

                Console.WriteLine();

                if (dots == 0)
                {
                    ascending = true;
                    dots = 1;
                }
            }

            else if (ascending == true)
            {
                do
                {
                    Console.Write(new string('.', dots));
                    for (int j = 0; j < 7 - (dots * 2); j++)
                    {
                        Console.Write(letters[count]);
                        count++;

                        if (count > 6)
                        {
                            count = 0;
                        }
                    }

                    Console.WriteLine(new string('.', dots));

                    i++;
                    dots++;

                    if (i == n)
                    {
                        return;
                    }

                } while (dots < 4);

                if (dots == 4)
                {
                    ascending = false;
                    i--;
                    dots = 3;
                }
            }
        }
    }
}
