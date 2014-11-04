using System;

class PrimesInRange
{
    static void Main()
    {
        int startNum = int.Parse(Console.ReadLine());
        int endNum = int.Parse(Console.ReadLine());

        Console.WriteLine(CalcPrimesInRange(startNum, endNum));
    }

    private static string CalcPrimesInRange(int startNum, int endNum)
    {
        string result = "";

        if ((startNum > 1) && (endNum >= startNum))
        {
            for (int num = startNum; num <= endNum; num++)
            {
                bool prime = true;
                int divider = 2;
                int maxDivider = (int)Math.Sqrt(num);
                while (divider <= maxDivider)
                {
                    if (num % divider == 0)
                    {
                        prime = false;
                        break;
                    }
                    divider++;
                }
                if (prime)
                {
                    result += num;
                    return result;
                }
            }
        }
        else
        {
            result = "Not range!";
            return result;
        }
    }
}
