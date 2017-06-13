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
        int tobBase = int.Parse(Console.ReadLine());
        string result = "";
        while (number!=0)
        {
            int remainder = number % tobBase;
            result = result.Insert(0, Convert.ToString(remainder));
            number = number / tobBase;
        }
        Console.WriteLine(result);
    }
}
