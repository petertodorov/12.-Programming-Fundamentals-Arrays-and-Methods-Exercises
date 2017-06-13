using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class IntegerToBase
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());
        int toBase = int.Parse(Console.ReadLine());
        string result = IntegerConvertedToBase(number, toBase);
        Console.WriteLine(result);
    }

    private static string IntegerConvertedToBase(int number, int toBase)
    {
        string tempResult = "";
        while (number != 0)
        {
            int remainder = number % toBase;
            tempResult = tempResult.Insert(0, Convert.ToString(remainder));
            number = number / toBase;
        }
        return tempResult;
    }
}
