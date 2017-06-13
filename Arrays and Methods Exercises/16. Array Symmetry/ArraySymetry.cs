using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ArraySymetry
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split(' ').ToArray();
        bool isSymetrical = false;

        for (int i = 0; i < input.Length / 2; i++)
        {
            isSymetrical = false;
            while (input[i] == input[input.Length - 1-i])
            {
                isSymetrical = true;
                break;
            }
        }
        if (isSymetrical)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");

        }
    }
}

