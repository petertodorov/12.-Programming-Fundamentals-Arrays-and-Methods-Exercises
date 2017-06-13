using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class TrickyStrings
{
    static void Main(string[] args)
    {
        string delimiter = Console.ReadLine();
        int numberOfStrings = int.Parse(Console.ReadLine());
        string [] currentString = new string[numberOfStrings];
        for (int i = 0; i < numberOfStrings; i++)
        {
            currentString[i] = Console.ReadLine(); ;
        }
        Console.WriteLine(String.Join(delimiter, currentString));

    }
}
