using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CalorieCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Filepath = @"C:\Users\VexingThoughts\source\repos\LachlanWells0001\Advent2022\Day01\Elves.txt";
            List<int> list = new List<int>();
            int val = 0;

            foreach (string line in System.IO.File.ReadLines(Filepath))
            {
                if (line.Equals(""))
                {
                    list.Add(val);
                    val = 0;
                }
                else
                {
                    val += int.Parse(line);
                }
            }

            list.Sort();
            list.Reverse();
            Console.WriteLine(list.First());

            //Part Two

            int answer = list.ElementAt(0);
            answer += list.ElementAt(1);
            answer += list.ElementAt(2);
            Console.WriteLine(answer);
        }
    }
}
