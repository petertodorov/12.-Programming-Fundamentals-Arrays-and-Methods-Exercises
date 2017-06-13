using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Altitude
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split(' ').ToArray();
        int altitude = int.Parse(input[0]);
        List<string> comands = new List<string>();
        List<int> changeMeters = new List<int>();

        for (int i = 1; i < input.Length; i++)
        {
            if (i % 2 == 1)
            {
                comands.Add(input[i]);
            }
            else
            {
                changeMeters.Add(int.Parse(input[i]));
            }
        }
        for (int i = 0; i < comands.Count; i++)
        {

            if (altitude > 0)
            {
                switch (comands[i])
                {
                    case "up": altitude += changeMeters[i]; break;
                    case "down": altitude -= changeMeters[i]; break;
                }
                if (altitude <= 0)
                {
                    Console.WriteLine("crashed");
                    return;
                }
            }
            
        }
            Console.WriteLine($"got through safely. current altitude: {altitude}m");
    }
}

