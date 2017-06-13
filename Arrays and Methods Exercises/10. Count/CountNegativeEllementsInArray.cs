using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CountNegativeEllementsInArray
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] input = new int[n];
    
        for (int i = 0; i < n; i++)
        {
            input[i] = int.Parse(Console.ReadLine());
        }
        
        Console.WriteLine(input.Count(x => x < 0));
    }
}

