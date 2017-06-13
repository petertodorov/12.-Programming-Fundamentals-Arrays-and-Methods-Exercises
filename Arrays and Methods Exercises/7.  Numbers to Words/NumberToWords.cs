using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class NumberToWords
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        Letterize(n);
    }
    private static void Letterize(int n)
    {
        int number = new int();
        for (int i = 0; i < n; i++)
        {
            number = int.Parse(Console.ReadLine());
            TooBigTooLarge(number);
            string numberToString = Convert.ToString(number);
            if (numberToString.First() == '-')
            {
                string temp = numberToString.Remove(0, 1);
                int tempNum = int.Parse(temp);
                if (temp.Length == 3)
                {
                    Console.Write("minus ");
                    SizeOfNumber(tempNum);
                }
                else
                {
                    continue;
                }
            }
            else if (numberToString.Length == 3)
            {
                SizeOfNumber(number);
            }
            else
            {
                continue;
            }
        }
    }
    private static void TooBigTooLarge(int number)
    {
        if (number > 999)
        {
            Console.WriteLine("too large");
        }
        else if (number < -999)
        {
            Console.WriteLine("too small");
        }
    }
    private static void SizeOfNumber(int number)
    {
        string word = Convert.ToString(number);
        WriteNumberInWords(word);
    }
    private static void WriteNumberInWords(string word)
    {
        char[] digits = word.ToCharArray();
        string ones = "";
        string tens = "";
        string hundreds = "";
        bool specialCase = false;

        switch (digits[2])
        {
            case '1': ones = "one"; break;
            case '2': ones = "two"; break;
            case '3': ones = "three"; break;
            case '4': ones = "four"; break;
            case '5': ones = "five"; break;
            case '6': ones = "six"; break;
            case '7': ones = "seven"; break;
            case '8': ones = "eight"; break;
            case '9': ones = "nine"; break;
            default: ones = ""; break;
        }
        switch (digits[1])
        {
            case '1': specialCase = true; tens= SpecialCases(digits, tens); break;
            case '2': tens = "twenty"; break;
            case '3': tens = "thirty"; break;
            case '4': tens = "fourty"; break;
            case '5': tens = "fifty"; break;
            case '6': tens = "sixty"; break;
            case '7': tens = "seventy"; break;
            case '8': tens = "eighty"; break;
            case '9': tens = "ninety"; break;
            default: tens = ""; break;
        }
        switch (digits[0])
        {
            case '1': hundreds = "one"; break;
            case '2': hundreds = "two"; break;
            case '3': hundreds = "three"; break;
            case '4': hundreds = "four"; break;
            case '5': hundreds = "five"; break;
            case '6': hundreds = "six"; break;
            case '7': hundreds = "seven"; break;
            case '8': hundreds = "eight"; break;
            case '9': hundreds = "nine"; break;
            default: hundreds = ""; break;
        }
        if (ones == "" && tens == "")
        {
            Console.WriteLine($"{hundreds}-hundred");
        }
        else if (specialCase == true)
        {
            Console.WriteLine($"{hundreds}-hundred and {tens}");
        }
        else if (specialCase == false)

        {
            Console.WriteLine($"{hundreds}-hundred and {tens} {ones}");
        }
    }

    private static string SpecialCases(char[] digits, string tens)
    {
        switch (digits[2])
        {
            case '1': tens = "eleven"; break;
            case '2': tens = "twelve"; break;
            case '3': tens = "thirteen"; break;
            case '4': tens = "fourteen"; break;
            case '5': tens = "fivteen"; break;
            case '6': tens = "sixteen"; break;
            case '7': tens = "seventeen"; break;
            case '8': tens = "eighteen"; break;
            case '9': tens = "nineteen"; break;
            default: tens = ""; break;
        }
        return tens;
    }
}

