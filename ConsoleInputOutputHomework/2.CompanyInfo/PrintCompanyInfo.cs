using System;

class PrintCompanyInfo
{
    static void Main()
    {
        Console.Write("Company Name: ");
        string companyName = Console.ReadLine();

        Console.Write("Company Address: ");
        string companyAddress = Console.ReadLine();

        Console.Write("Phone Number: ");
        string phoneNum = Console.ReadLine();

        Console.Write("Fax: ");
        string fax = Console.ReadLine();

        Console.Write("Web Site: ");
        string webSite = Console.ReadLine();

        Console.Write("Manager First Name: ");
        string managerFName = Console.ReadLine();

        Console.Write("Manager Last Name: ");
        string managerLName = Console.ReadLine();

        Console.Write("Manager Age: ");
        byte managerAge = byte.Parse(Console.ReadLine());

        Console.Write("Manager Phone: ");
        string managerPNum = Console.ReadLine();

        if (fax == "")
        {
            fax = "No fax";
        }

        Console.WriteLine("\n{0} \n{1} \n{2} \n{3} \n{4} \nManager: {5} {6} (age: {7}, {8})", companyName, companyAddress, phoneNum, fax,
            webSite, managerFName, managerLName, managerAge, managerPNum);
    }
}
