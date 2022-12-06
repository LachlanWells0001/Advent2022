using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CrateMover
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Filepath = @"C:\Users\VexingThoughts\source\repos\LachlanWells0001\Advent2022\Day05\Crates.txt";

            String[] lines = File.ReadAllLines(Filepath);

            List<char>[] Columns = new List<char>[9];

            for (int i = 0; i < 9; i++)
            {
                Columns[i] = new List<char>();
            }

            for (int i = 7; i >= 0; i--)
            {
                for(int j = 0; j < 9 ; j++)
                {
                    char crateId = lines[i][(1 + (j * 4))];

                    if(crateId != ' ')
                    {
                        Columns[j].Add(crateId);
                    }
                }
            }

            for(int i = 10; i < lines.Length; i++)
            {
                String command = lines[i];
                String[] relevantInfo = command.Split(' ');

                int numMove = int.Parse(relevantInfo[1]);
                int from = int.Parse(relevantInfo[3]) - 1;
                int to = int.Parse(relevantInfo[5]) - 1;

                for(int j = 0; j < numMove ; j++)
                {
                    Columns[to].Add(Columns[from].Last());
                    Columns[from].RemoveAt((Columns[from].Count - 1));
                }
            }

            String output = "";

            for(int i = 0; i < 9; i++)
            {
                output += Columns[i].Last();
            }

            Console.WriteLine(output);
            //Part One Complete

            for (int i = 0; i < 9; i++)
            {
                Columns[i] = new List<char>();
            }

            for (int i = 7; i >= 0; i--)
            {
                for (int j = 0; j < 9; j++)
                {
                    char crateId = lines[i][(1 + (j * 4))];

                    if (crateId != ' ')
                    {
                        Columns[j].Add(crateId);
                    }
                }
            }

            for (int i = 10; i < lines.Length; i++)
            {
                String command = lines[i];
                String[] relevantInfo = command.Split(' ');

                int numMove = int.Parse(relevantInfo[1]);
                int from = int.Parse(relevantInfo[3]) - 1;
                int to = int.Parse(relevantInfo[5]) - 1;

                int index = (Columns[from].Count) - (numMove);

                for (int j = 0; j < numMove; j++)
                {
                    Columns[to].Add(Columns[from][index]);
                    Columns[from].RemoveAt(index);
                }
            }


            output = "";

            for (int i = 0; i < 9; i++)
            {
                output += Columns[i].Last();
            }

            Console.WriteLine(output);
            //Part Two Complete
        }
    }
}
