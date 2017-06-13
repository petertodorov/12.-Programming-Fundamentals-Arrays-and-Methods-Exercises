using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class BallisticsTraining
{
    static void Main(string[] args)
    {
        int[] coordinates = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int x = coordinates[0];
        int y = coordinates[1];
        int tempX = 0;
        int tempY = 0;

        string[] mixed = Console.ReadLine().Split(' ').ToArray();
        List<string> directions = new List<string>();
        List<int> counts = new List<int>();

        FindCountsAndDirections(mixed, counts, directions);
        SetCoordinatesToFire(directions, counts,tempX,tempY,x,y);
        

    }

    private static void SetCoordinatesToFire(List<string> directions, List<int> counts,int tempX,int tempY, int x, int y)
    {
        for (int i = 0; i < directions.Count; i++)
        {
            switch (directions[i])
            {
                case "up": tempY += counts[i]; break;
                case "down": tempY -= counts[i]; break;
                case "left": tempX -= counts[i]; break;
                case "right": tempX += counts[i]; break;
            }
        }
        Console.WriteLine($"firing at [{tempX}, {tempY}]");
        if (tempX==x && tempY==y)
        {
            Console.WriteLine($"got 'em!");
        }
        else
        {
            Console.WriteLine($"better luck next time...");
        }
    }

    private static void FindCountsAndDirections(string[] mixed, List<int> counts, List<string> directions)
    {
        for (int i = 0; i < mixed.Length; i++)
        {
            if (i % 2 == 1)
            {
                counts.Add(int.Parse(mixed[i]));
            }
            if (i % 2 == 0)
            {
                directions.Add(mixed[i]);
            }
        }
    }
}

