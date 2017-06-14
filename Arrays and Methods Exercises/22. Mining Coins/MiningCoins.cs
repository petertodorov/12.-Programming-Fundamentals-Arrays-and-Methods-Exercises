﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MiningCoins
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        string decrypted = "";
        float totalValue = 0;
        int ASCIIcode = 0;
        for (int i = 1; i <=n; i++)
        {
            int number = int.Parse(Console.ReadLine());
            int digit1 = number / 100;
            int digit2 = (number / 10) % 10;
            int digit3 = number % 10;

            if (i % 2 == 1)
            {
                ASCIIcode = ((digit1 * 10) + digit3) - digit2;
            }
            else
            {
                ASCIIcode = (digit1*10 + digit3) + digit2;
            }
            if ((ASCIIcode >= 65 && ASCIIcode <= 90)
                || (ASCIIcode >=97 && ASCIIcode <= 122))
            {
                decrypted += (char)ASCIIcode;
            }
            totalValue += (digit1 + digit2 + digit3) / (float)n;
        }
        Console.WriteLine("Message: {0}", decrypted);
        Console.WriteLine("Value: {0:F7}", totalValue);
    }
}

