using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = File.ReadAllLines("Input/input.txt").ToList();

            List<DirectionData> data = new List<DirectionData>();
            lines.ForEach(x => data.Add(new DirectionData { Direction = x.Split(" ")[0], Distance = int.Parse(x.Split(" ")[1]) }));

            Problem1(data);
            Problem2(data);
        }

        private static void Problem1(List<DirectionData> data)
        {
            int forwardTotal = data.Where(x => x.Direction == "forward").Select(x => x.Distance).Sum();
            int upTotal = data.Where(x => x.Direction == "up").Select(x => x.Distance).Sum();
            int downTotal = data.Where(x => x.Direction == "down").Select(x => x.Distance).Sum();

            int depthTotal = downTotal - upTotal;

            Console.WriteLine(depthTotal * forwardTotal);
        }

        private static void Problem2(List<DirectionData> data)
        {
            int depth = 0;
            int aim = 0;
            int horizontal = 0;

            foreach (var item in data)
            {
                if (item.Direction == "forward")
                {
                    horizontal += item.Distance;
                    depth = depth + (aim * item.Distance);
                }
                else if (item.Direction == "up")
                    aim -= item.Distance;
                else
                    aim += item.Distance;
            }

            Console.WriteLine(depth * horizontal);
        }
    }
}
