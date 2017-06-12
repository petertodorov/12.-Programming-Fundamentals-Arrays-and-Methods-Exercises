using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MinMethod
{
    static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        int second = int.Parse(Console.ReadLine());
        int third = int.Parse(Console.ReadLine());
        int b = Math.Min(second, third);
        int smallest = GetMin(a, b);
        Console.WriteLine(smallest);
    }

    private static int GetMin(int a, int b)
    {
        int result = Math.Min(a, b);
        return result;
    }
}

