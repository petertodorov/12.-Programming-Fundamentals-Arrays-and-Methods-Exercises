using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class NthDigit
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());
        int index = int.Parse(Console.ReadLine());
        string temp = number.ToString();
      char a =   temp.ElementAt(temp.Length - index);
        Console.WriteLine(a);

    } 
}

