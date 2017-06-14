using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class StringEncryption
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        char letter = new char();
        int letterToInt = new int();
        int first = new int();
        int last = new int();
        string encryptedResult = "";
        for (int i = 0; i < n; i++)
        {
            letter =char.Parse(Console.ReadLine());
            letterToInt = Convert.ToInt32(letter);
            string temp = Convert.ToString(letterToInt);
            char firstTemp = temp.First();
            char lastTemp = temp.Last();
            first =(int) Char.GetNumericValue(firstTemp);
            last = (int)Char.GetNumericValue(lastTemp);
            int firstPlusLast = (first * 10) + last;
            string encoded = Convert.ToString(firstPlusLast);
            char toApendStart = Convert.ToChar(letterToInt+last);
            char toApendEnd = Convert.ToChar(letterToInt - first);
            encoded = encoded.Insert(0, Convert.ToString(toApendStart))+toApendEnd;
            encryptedResult += encoded;
        }
        Console.WriteLine(encryptedResult);
    }
}

