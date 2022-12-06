using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOCSolutions
{
    public static class Solutions
    {
        #region Day 1
        public static int Day1a(string path)
        {
            int maxFood = 0;
            int tempFood = 0;

            
            foreach (string line in File.ReadLines(path))
            {
                if(String.IsNullOrEmpty(line))
                {
                    tempFood = 0;
                }
                else
                {
                    int food;
                    if (Int32.TryParse(line, out food))
                    {
                        tempFood += food;
                        if(tempFood > maxFood)
                            maxFood = tempFood;
                    }                  
                }
            }
            return maxFood;
        }

        public static int Day1b(string path)
        {
            ArrayList stashes = new ArrayList();
            int tempFood = 0;
            int maxFood = 0;

            foreach (string line in File.ReadLines(path))
            {
                if (String.IsNullOrEmpty(line))
                {
                    stashes.Add(tempFood);
                    tempFood = 0;
                }
                else
                {
                    int food;
                    if (Int32.TryParse(line, out food))
                    {
                        tempFood += food;
                    }
                }
            }
            
            stashes.Add(tempFood);
            stashes.Sort();

            for(int i = stashes.Count - 1; i > stashes.Count - 4; i--)
            {
                maxFood += (int) stashes[i];
            }

            return maxFood;
        }
        #endregion

        #region Day 2
        public static int Day2a(string path)
        {
            int totalScore = 0;

            foreach (string line in File.ReadLines(path))
            {
                string[] plays = line.Split(" ");
                int shapeScore = scoreShape(plays[1]);
                int outcomeScore = scoreOutcome(String.Concat(plays[0], plays[1]));
                totalScore += shapeScore + outcomeScore;
            }
            
            return totalScore;
        }

        public static int Day2b(string path)
        {
            int totalScore = 0;

            foreach (string line in File.ReadLines(path))
            {
                string[] plays = line.Split(" ");

                //get what my play should be
                string myPlay;

                //X means you need to lose, Y means you need to end the round in a draw, and Z means you need to win.
                switch (String.Concat(plays[0], plays[1]))
                {
                    //rock
                    case "AY":  //rock rock tie
                    case "BX":   //paper rock lose 
                    case "CZ":   //sissors rock win
                        myPlay = "A";
                        break;
                    //paper
                    case "AZ":  //rock paper win
                    case "BY":   //paper paper tie 
                    case "CX":   //sissors paper lose
                        myPlay = "B";
                        break;
                    //sissors
                    case "AX":  //rock sissors lose
                    case "BZ":   //paper sissors win 
                    case "CY":   //sissors sissors tie
                        myPlay = "C";
                        break;
                    default:
                        myPlay = "K";
                        break;
                }


                int shapeScore = scoreShape(myPlay);

                //get score
                int outcomeScore = scoreOutcome(String.Concat(plays[0], myPlay));
                totalScore += shapeScore + outcomeScore;
            }

            return totalScore;
        }

        private static int scoreShape(string letter)
        {
            switch (letter)
            {
                case "X":
                case "A":
                    return 1;
                    break;

                case "Y":
                case "B":
                    return 2;
                    break;

                case "Z":
                case "C":   
                    return 3;
                    break;
                default:
                    return -10000;
                    break;
            }
        }

        private static int scoreOutcome(string round)
        {
            switch (round)
            {
                case "AZ": //rock sissors
                case "AC":
                case "BX": //paper rock
                case "BA":
                case "CY": //sissors paper
                case "CB":
                    return 0;
                    break;

                case "AX": //rock rock
                case "AA":
                case "BY": //paper paper
                case "BB": 
                case "CZ": //sissors sissors
                case "CC":
                    return 3;
                    break;

                case "AY": //rock paper
                case "AB":
                case "BZ": //paper sissors
                case "BC":
                case "CX": //sissors rock
                case "CA":
                    return 6;
                    break;

                default:
                    return -10000;
                    break;
            }
        }
        #endregion

    }
}
