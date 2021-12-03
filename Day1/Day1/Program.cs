using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = new List<int>();
            input = File.ReadAllLines("Input/input.txt").Select(x => Int32.Parse(x)).ToList();

            Problem1(input);
            Problem2(input);
        }

        private static void Problem1(List<int> input)
        {
            int increaseCount = 0;

            for (int i = 0; i < input.Count; i++)
                increaseCount = i != 0 ? input[i] > input[i - 1] ? increaseCount += 1 : increaseCount : increaseCount;

            Console.WriteLine(increaseCount);
        }

        private static void Problem2(List<int> input)
        {
            int increaseCount = 0;

            for (int i = 0; i < input.Count -3; i++)
                increaseCount = input[i + 1] + input[i + 2] + input[i + 3] > input[i] + input[i + 1] + input[i + 2] ? increaseCount += 1 : increaseCount;

            Console.WriteLine(increaseCount);
        }
    }
}
