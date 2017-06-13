using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CountOfGivenElementInArray
{
    static void Main(string[] args)
    {
        int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(input.Count(x => x == n));
    }
}

