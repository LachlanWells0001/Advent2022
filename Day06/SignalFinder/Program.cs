using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalFinder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Filepath = @"C:\Users\VexingThoughts\source\repos\LachlanWells0001\Advent2022\Day06\SignalBuffer.txt";

            String text = File.ReadAllText(Filepath);

            for(int i = 0; i <= (text.Length - 3); i++) 
            {
                var characters = text.Substring(i, 4).Distinct();

                if(characters.Count() == 4) 
                {
                    Console.WriteLine(i + 4);
                    break;
                }
            }

            //Part One Compelte

            for (int i = 0; i <= (text.Length - 13); i++)
            {
                var characters = text.Substring(i, 14).Distinct();

                if (characters.Count() == 14)
                {
                    Console.WriteLine(i + 14);
                    break;
                }
            }
        }
    }
}
