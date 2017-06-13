using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CountCapitallettersInArray
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split(' ').ToArray();
        int counter = 0;
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i].Length==1)
            {
                counter++;
            }
        }
        Console.WriteLine(counter);
    }
}

