using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RucksackSorter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Filepath = @"C:\Users\VexingThoughts\source\repos\LachlanWells0001\Advent2022\Day03\Rucksack.txt";

            int score = 0;

            foreach (string line in File.ReadLines(Filepath))
            {
                String first = line.Substring(0, (int)(line.Length / 2));
                String second = line.Substring((int)(line.Length / 2), (int)(line.Length / 2));

                char common = (first.Intersect(second)).FirstOrDefault();

                score += getPriority(common);
            }

            Console.WriteLine(score);
            //Part One Complete

            score = 0;

            var lines = File.ReadAllLines(Filepath);

            for(int i = 0; i < lines.Length; i += 3)
            {
                String first = lines[i];
                String second = lines[i + 1];
                String third = lines[i + 2];

                IEnumerable<char> OneAndTwo = first.Intersect(second);
                IEnumerable<char> TwoAndThree = second.Intersect(third);

                char common = (OneAndTwo.Intersect(TwoAndThree)).FirstOrDefault();

                score += getPriority(common);
            }

            Console.WriteLine(score);
            //Part Two Complete
        }

        static int getPriority(char value)
        {
            int priority = (int)value;

            if(priority >= 65 && priority < 91)
            {
                priority -= 38;
            }
            else
            {
                priority -= 96;
            }

            return priority;
        }
    }
}
