using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Equal_Sequence
{
    class EqualSecuenceOfElements
    {
        static void Main(string[] args)
        {

            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            for (int i = 1; i < input.Length; i++)
            {

                if (input[i]!=input[i-1])
                {
                    CheckIfTrue(false);
                    return;
                }
            }
            Console.WriteLine("yes");
        }

        private static void CheckIfTrue(bool equal)
        {
            Console.WriteLine("No");
        }
    }
}
