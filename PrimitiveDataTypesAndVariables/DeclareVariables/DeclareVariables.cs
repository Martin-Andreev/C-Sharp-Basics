using System;

class DeclareVariables
{
    static void Main()
    {
        int start = int.Parse(Console.ReadLine());
        DateTime startDate = new DateTime(start, 1, 1);

        string date = startDate.Day.ToString() + startDate.Month.ToString() + startDate.Year.ToString();
        string tempNum = "";
        int num = 0;
        int weight = 1;

        foreach (var ch in date)
        {
            switch (ch)
            {
                case '1': tempNum += '1'; break;
                case '2': tempNum += '2'; break;
                case '3': tempNum += '3'; break;
                case '4': tempNum += '4'; break;
                case '5': tempNum += '5'; break;
                case '6': tempNum += '6'; break;
                case '7': tempNum += '7'; break;
                case '8': tempNum += '8'; break;
                case '9': tempNum += '9'; break;
                case '0': tempNum += '0'; break;
                default: break;
            }
        }

        num = int.Parse(tempNum);

        for (int i = 0; i < tempNum.Length - 1; i++)
        {
            //int j;
            //int tempWeight = 0;

            for (int j = i + 1; j < tempNum.Length; j++)
            {
                weight += i * j;
                //tempWeight = tempWeight + (i * j);
            }

            //weight = weight + tempWeight; ;
        }

        Console.WriteLine(weight);








        //sbyte num1 = -115;
        //byte num2 = 97;
        //short num3 = -10000;
        //ushort num4 = 52130;
        //int num5 = 4825932;

        //Console.WriteLine("{0}, {1}, {2}, {3}, {4}", num1, num2, num3, num4, num5);
    }
}
