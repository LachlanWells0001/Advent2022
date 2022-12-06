using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CampOverlapDetector
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Filepath = @"C:\Users\VexingThoughts\source\repos\LachlanWells0001\Advent2022\Day04\CampPairs.txt";

            int score = 0;

            foreach (string line in File.ReadLines(Filepath))
            {
                String[] pair = line.Split(',');
                String[] elf1 = pair[0].Split('-');
                String[] elf2 = pair[1].Split('-');
                int elf1Low = int.Parse(elf1[0]);
                int elf1High = int.Parse(elf1[1]);
                int elf2Low = int.Parse(elf2[0]);
                int elf2High = int.Parse(elf2[1]);

                if ((elf1Low >= elf2Low && elf1High <= elf2High) || (elf2Low >= elf1Low && elf2High <= elf1High))
                {
                    score++;
                }
            }

            Console.WriteLine(score);
            //Part One Complete

            score = 0;

            foreach (string line in File.ReadLines(Filepath))
            {
                String[] pair = line.Split(',');
                String[] elf1 = pair[0].Split('-');
                String[] elf2 = pair[1].Split('-');
                int elf1Low = int.Parse(elf1[0]);
                int elf1High = int.Parse(elf1[1]);
                int elf2Low = int.Parse(elf2[0]);
                int elf2High = int.Parse(elf2[1]);

                if ((elf1Low >= elf2Low && elf1Low <= elf2High) || ((elf2Low >= elf1Low && elf2Low <= elf1High)) || (elf1High <= elf2High && elf1High >= elf2Low) || (elf2High <= elf1High && elf2High >= elf1Low))
                {
                    score++;
                }
            }

            Console.WriteLine(score);
            //Part Two Complete
        }
    }
}
