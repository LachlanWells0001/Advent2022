using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RockPaperScissor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Filepath = @"C:\Users\VexingThoughts\source\repos\LachlanWells0001\Advent2022\Day02\Strat.txt";

            int score = 0;

            foreach (string line in System.IO.File.ReadLines(Filepath)) 
            {
                char opponent;
                char you;

                opponent = line.ElementAt(0);
                you = line.ElementAt(2);

                switch(opponent )
                {
                    case 'A':
                        switch (you)
                        {
                            case 'X':
                                score += 4;
                                break;

                            case 'Y':
                                score += 8;
                                break;

                            case 'Z':
                                score += 3;
                                break;
                        }
                        break;

                    case 'B':
                        switch (you)
                        {
                            case 'X':
                                score += 1;
                                break;

                            case 'Y':
                                score += 5;
                                break;

                            case 'Z':
                                score += 9;
                                break;
                        }
                        break;

                    case 'C':
                        switch (you)
                        {
                            case 'X':
                                score += 7;
                                break;

                            case 'Y':
                                score += 2;
                                break;

                            case 'Z':
                                score += 6;
                                break;
                        }
                        break;
                }
            }
            Console.WriteLine(score);
            //Part One Complete

            //Part Two Simply Change Values in the 3 nested switch cases
            score = 0;
            foreach (string line in System.IO.File.ReadLines(Filepath))
            {
                char opponent;
                char you;

                opponent = line.ElementAt(0);
                you = line.ElementAt(2);

                switch (opponent)
                {
                    case 'A':
                        switch (you)
                        {
                            case 'X':
                                score += 3;
                                break;

                            case 'Y':
                                score += 4;
                                break;

                            case 'Z':
                                score += 8;
                                break;
                        }
                        break;

                    case 'B':
                        switch (you)
                        {
                            case 'X':
                                score += 1;
                                break;

                            case 'Y':
                                score += 5;
                                break;

                            case 'Z':
                                score += 9;
                                break;
                        }
                        break;

                    case 'C':
                        switch (you)
                        {
                            case 'X':
                                score += 2;
                                break;

                            case 'Y':
                                score += 6;
                                break;

                            case 'Z':
                                score += 7;
                                break;
                        }
                        break;
                }
            }
            Console.WriteLine(score);
        }
    }
}
