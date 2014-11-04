using System;

class EmployeeData
{
    static void Main()
    {
        Console.Write("Enter first name: ");
        string fName = Console.ReadLine();

        Console.Write("Enter last name: ");
        string lName = Console.ReadLine();

        Console.Write("Enter age: ");
        int age;
        string gander;
        uint id;
        uint uniqueNumber;

        age = int.Parse(Console.ReadLine());

        if ((age < 0) || (age > 100))
        {
            Console.WriteLine("Incorrect age! Please, enter correct age: ");
            age = int.Parse(Console.ReadLine());
        }

        Console.Write("Enter gander(m/f): ");
        gander = Console.ReadLine();

        if ((gander != "m") && (gander != "f"))
        {
            Console.WriteLine("Incorrect gander! Please, enter correct gander(m/f): ");
            gander = Console.ReadLine();
            if (gander == "m")
            {
                gander = "Male";
            }
            else
            {
                gander = "Female";
            }
        }

        if (gander == "m")
        {
            gander = "Male";
        }
        else
        {
            gander = "Female";
        }

        Console.Write("Enter personal ID number: ");
        id = uint.Parse(Console.ReadLine());

        Console.Write("Enter unique employee number(from: 27560000 … to: 27569999): ");
        uniqueNumber = uint.Parse(Console.ReadLine());

        if ((uniqueNumber < 27560000) || (uniqueNumber > 27569999))
        {
            Console.WriteLine("Incorrect unique employee number! Please, enter correct unique employee number:");
            uniqueNumber = uint.Parse(Console.ReadLine());
        }

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Details:\n");
        Console.WriteLine("Name: {0} {1}", fName, lName);
        Console.WriteLine("Age: {0}", age);
        Console.WriteLine("Gander: {0}", gander);
        Console.WriteLine("Personal ID number: {0}", id);
        Console.WriteLine("Unique employee number: {0}", uniqueNumber);
    }
}
