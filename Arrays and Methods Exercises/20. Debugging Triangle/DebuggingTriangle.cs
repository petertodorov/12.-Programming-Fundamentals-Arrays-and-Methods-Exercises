using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class TriangleFormations
{
    static void Main(string[] args)
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        bool hasRigthAngle = false;

        bool isValidTriangle = Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2) || Math.Pow(b, 2) + Math.Pow(c, 2) == Math.Pow(a, 2) || Math.Pow(a, 2) + Math.Pow(c, 2) == Math.Pow(b, 2);

        if (isValidTriangle)
        {
            Console.WriteLine("Triangle is valid.");
            hasRigthAngle = true;
        }
        bool valid = false;
        if (a + b > c && b + c > a && a + c > b)
        {
            valid = true;
        }
        if (valid)
        {
            if (Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2))
            {
                Console.WriteLine("Triangle has a right angle between sides a and b");

            }
            else if (Math.Pow(b, 2) + Math.Pow(c, 2) == Math.Pow(a, 2))
            {
                Console.WriteLine("Triangle has a right angle between sides b and c");
            }
            else if (Math.Pow(a, 2) + Math.Pow(c, 2) == Math.Pow(b, 2))
            {
                Console.WriteLine("Triangle has a right angle between sides a and c");
            }
        }
        else
        {
            Console.WriteLine("Triangle has no right angles.");
        }
    
        else
        {
            Console.WriteLine("Invalid Triangle.");
        }

    }
}

