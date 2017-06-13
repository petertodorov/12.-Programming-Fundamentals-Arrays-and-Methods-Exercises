using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class IncreasingSequenceOfElements
{
    static void Main(string[] args)
    {
        int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        bool not = true;
        for (int i = 1; i <input.Length; i++)
        {
            not = true;
            if (input[i]<input[i-1])
            {
                not=false;
                break;
            }
        }
        if (!not)
        {
            Console.WriteLine("No");
        }
        else
        {
            Console.WriteLine("Yes");
        }
    }
}

