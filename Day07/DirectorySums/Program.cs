using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectorySums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Filepath = @"C:\Users\VexingThoughts\source\repos\LachlanWells0001\Advent2022\Day07\unixmemes.txt";

            Stack<String> currentPath = new Stack<String>();
            Dictionary<String, int> directorySizes = new Dictionary<String, int>();
            List<int> sizes;

            foreach(String line in File.ReadLines(Filepath))
            {
                if(line == "$ cd ..")
                {
                    currentPath.Pop();
                }
                else if(line.StartsWith("$ cd"))
                {
                    String directoryPath = String.Join("", currentPath) + line.Split(' ')[2];
                    currentPath.Push(directoryPath);

                    if (!directorySizes.ContainsKey(directoryPath))
                    {
                        directorySizes.Add(directoryPath, 0);
                    }
                }
                else if(line.Any(char.IsDigit))
                {
                    int size = int.Parse(line.Split(' ')[0]);

                    foreach (String directoryPath in currentPath)
                    {
                        directorySizes[directoryPath] += size;
                    }
                }
            }

            sizes = directorySizes.Values.ToList();

            Console.WriteLine(sizes.Where(size => size < 100000).Sum());
            //Part 1 Complete

            int remainingSpace = 70000000 - sizes.Max(); //Gets value for root directory
            Console.WriteLine(sizes.Where(size => size + remainingSpace >= 30000000).Min());

            //Part 2 Complete
        }
    }
}
