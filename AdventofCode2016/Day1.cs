using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventofCode2016
{
    class Day1
    {
        string dayOneAnswerOne;
        string[] input;
        char turnDir;
        int howFar;
        List<string> locations = new List<string>();
        string loc;
        bool stopChecking = false;

        string faceDir = "north";
        int curX = 0;
        int curY = 0;

        public string DayOne() {
            using (StreamReader sr = new StreamReader(@"C:\Users\Me\documents\visual studio 2015\Projects\AdventofCode2016\AdventofCode2016\Day1\part1_input.txt"))
            {
                input = sr.ReadToEnd().Split(',');
            }

            foreach(string x in input)
            {
                turnDir = x[0];
                howFar = Int32.Parse(x.Substring(1));
                //Console.WriteLine("Facing " + faceDir + ", turning " + turnDir.ToString() + ", to move " + howFar + " spaces.");
                TurnAndGo(faceDir, turnDir, howFar);
            }

            return dayOneAnswerOne = "You ended at " + curX + ", " + curY + " for a distance of " + (Math.Abs(curX)+ Math.Abs(curY)) + ".";
        }

        void TurnAndGo(string facing, char turnDir, int howFar)
        {
            switch (facing)
            {
                case "north":
                    if (turnDir == 'L')
                    {
                        for (int i = 1; i <= howFar; i++)
                        {
                            curX--;
                            loc = (curX + "," + curY);
                            if (locations.Contains(loc) && stopChecking == false)
                            {
                                Console.WriteLine("Day 1 Part 2: You have visited " + loc + " before, a distance of " + (Math.Abs(curX)+ Math.Abs(curY)) + " from the start");
                                stopChecking = true;
                            }
                            locations.Add(loc);
                        }
                        faceDir = "west";
                    }
                    else
                    {
                        for (int i = 1; i <= howFar; i++)
                        {
                            curX++;
                            loc = (curX + "," + curY);
                            if (locations.Contains(loc) && stopChecking == false)
                            {
                                Console.WriteLine("Day 1 Part 2: You have visited " + loc + " before, a distance of " + (Math.Abs(curX)+ Math.Abs(curY)) + " from the start");
                                stopChecking = true;
                            }
                            locations.Add(loc);
                        }
                        faceDir = "east";
                    }
                    break;

                case "east":
                    if (turnDir == 'L')
                    {
                        for (int i = 1; i <= howFar; i++)
                        {
                            curY++;
                            loc = (curX + "," + curY);
                            if (locations.Contains(loc) && stopChecking == false)
                            {
                                Console.WriteLine("Day 1 Part 2: You have visited " + loc + " before, a distance of " + (Math.Abs(curX)+ Math.Abs(curY)) + " from the start");
                                stopChecking = true;
                            }
                            locations.Add(loc);
                        }
                        faceDir = "north";
                    }
                    else
                    {
                        for (int i = 1; i <= howFar; i++)
                        {
                            curY--;
                            loc = (curX + "," + curY);
                            if (locations.Contains(loc) && stopChecking == false)
                            {
                                Console.WriteLine("Day 1 Part 2: You have visited " + loc + " before, a distance of " + (Math.Abs(curX)+ Math.Abs(curY)) + " from the start");
                                stopChecking = true;
                            }
                            locations.Add(loc);
                        }
                        faceDir = "south";
                    }
                    break;

                case "south":
                    if (turnDir == 'L')
                    {
                        for (int i = 1; i <= howFar; i++)
                        {
                            curX++;
                            loc = (curX + "," + curY);
                            if (locations.Contains(loc) && stopChecking == false)
                            {
                                Console.WriteLine("Day 1 Part 2: You have visited " + loc + " before, a distance of " + (Math.Abs(curX)+ Math.Abs(curY)) + " from the start");
                                stopChecking = true;
                            }
                            locations.Add(loc);
                        }
                        faceDir = "east";
                    }
                    else
                    {
                        for (int i = 1; i <= howFar; i++)
                        {
                            curX--;
                            loc = (curX + "," + curY);
                            if (locations.Contains(loc) && stopChecking == false)
                            {
                                Console.WriteLine("Day 1 Part 2: You have visited " + loc + " before, a distance of " + (Math.Abs(curX)+ Math.Abs(curY)) + " from the start");
                                stopChecking = true;
                            }
                            locations.Add(loc);
                        }
                        faceDir = "west";
                    }
                    break;

                case "west":
                    if (turnDir == 'L')
                    {
                        for (int i = 1; i <= howFar; i++)
                        {
                            curY--;
                            loc = (curX + "," + curY);
                            if (locations.Contains(loc) && stopChecking == false)
                            {
                                Console.WriteLine("Day 1 Part 2: You have visited " + loc + " before, a distance of " + (Math.Abs(curX)+ Math.Abs(curY)) + " from the start");
                                stopChecking = true;
                            }
                            locations.Add(loc);
                        }
                        faceDir = "south";
                    }
                    else
                    {
                        for (int i = 1; i <= howFar; i++)
                        {
                            curY++;
                            loc = (curX + "," + curY);
                            if (locations.Contains(loc) && stopChecking == false)
                            {
                                Console.WriteLine("Day 1 Part 2: You have visited " + loc + " before, a distance of " + (Math.Abs(curX)+ Math.Abs(curY)) + " from the start");
                                stopChecking = true;
                            }
                            locations.Add(loc);
                        }
                        faceDir = "north";
                    }
                    break;
            }
        }
    }
}
