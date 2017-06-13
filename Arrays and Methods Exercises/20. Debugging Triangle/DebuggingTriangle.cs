using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class TriangleFormations
{
    static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        double Condition1 = Mat.Pow(a) + Math.Pow(b) > Math.Pow(c);
        double Condition2 = Mat.Pow(b) + Math.Pow(c) > Math.Pow(a);
        double Condition3 = Mat.Pow(a) + Math.Pow(c) > Math.Pow(b);

        bool isValidTriangle = triangleValidityCondition1 || triangleValidityCondition2 || triangleValidityCondition3;

        if (isValidTriangle)
        {
            Console.WriteLine("Triangle is valid.");
        }
        else
        {
            Console.WriteLine("Invalid Triangle.");
        }


        if (Condition1)
        {
            Console.WriteLine(" Triangle has a right angle between sides a and b.");

        }
        else if (Condition2)
        {
            Console.WriteLine("Triangle has a right angle between sides b and c");

        }
        else if (Condition3)
        {
            Console.WriteLine("Triangle has a right angle between sides a and c");
        }
        else
        {
            Console.WriteLine("Triangle has no right angles.");
        }
    }
}

