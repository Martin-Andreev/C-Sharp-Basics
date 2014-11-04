using System;

class PlayWIthVars
{
    static void Main()
    {
        Console.WriteLine("Please choose a type: \n1 --> int \n2 --> double \n3 --> string");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1: Console.Write("Please enter an int: ");
                int intNum = int.Parse(Console.ReadLine());
                Console.WriteLine(intNum + 1);
                break;
            case 2: Console.Write("Please enter a double: ");
                double doubleNum = double.Parse(Console.ReadLine());
                Console.WriteLine(doubleNum + 1);
                break;
            case 3: Console.Write("Please enter a string: ");
                string world = Console.ReadLine();
                Console.WriteLine("{0}*", world);
                break;
        }
    }
}
