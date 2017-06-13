using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class LargestElementInArray
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int max = int.MinValue;
        for (int i = 0; i < n; i++)
        {
            int temp = int.Parse(Console.ReadLine());
            if (temp > max)
            {
                max = temp;
            }
        }
        Console.WriteLine(max);
    }
}

