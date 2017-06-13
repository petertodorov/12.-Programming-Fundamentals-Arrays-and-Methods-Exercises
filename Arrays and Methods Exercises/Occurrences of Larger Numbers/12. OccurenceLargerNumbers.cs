using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class OccurenceLargerNumbers
{
    static void Main(string[] args)
    {
        double[] input = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
        double check = double.Parse(Console.ReadLine());
        int counter = 0;
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i]>check)
            {
                counter++; 
            }
        }
        Console.WriteLine(counter);
    }
}

