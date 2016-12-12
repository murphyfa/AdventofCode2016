using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AdventofCode2016
{
    class Day2
    {
        string dayTwoAnswer;
        string[] input;
        List<string> outputOne = new List<string>();
        List<char> outputTwo = new List<char>();
        int newKey = 5;
        char newKeyTwo = '5';

        string startupPath = System.IO.Path.GetFullPath(@"..\..\");
        int curKey = 5;
        char curKeyTwo = '5';

        public string DayTwo()
        {
            using (StreamReader sr = new StreamReader(startupPath + @"\Day2\day2_input.txt"))
            {
                input = sr.ReadToEnd().Split('\r');
            }

            for(int x = 0; x < input.Length; x++)
            {

                foreach (char y in input[x])
                {
                    curKey = PartOne(y, curKey);
                    curKeyTwo = PartTwo(y, curKeyTwo);
                }

                outputOne.Add(curKey.ToString());
                outputTwo.Add(curKeyTwo);
            }
            dayTwoAnswer = "Part 1: Bathroom Code: " + string.Join(",", outputOne.ToArray()) + "\nDay 2: Part 2: Bathroom Code: " + string.Join(",", outputTwo.ToArray());
            return dayTwoAnswer;
        }

        public int PartOne(char move, int current)
        {
            switch (current)
            {
                case 1:
                    if (move == 'D')
                    {
                        newKey = 4;
                    } else if (move == 'R')
                    {
                        newKey = 2;
                    }
                    break;

                case 2:
                    if (move == 'D')
                    {
                        newKey = 5;
                    } else if (move == 'L')
                    {
                        newKey = 1;
                    } else if (move == 'R')
                    {
                        newKey = 3;
                    }
                    break;

                case 3:
                    if (move == 'D')
                    {
                        newKey = 6;
                    } else if (move == 'L')
                    {
                        newKey = 2;
                    }
                    break;

                case 4:
                    if (move == 'U')
                    {
                        newKey = 1;
                    } else if (move == 'D')
                    {
                        newKey = 7;
                    } else if (move == 'R')
                    {
                        newKey = 5;
                    }
                    break;

                case 5:
                    if (move == 'U')
                    {
                        newKey = 2;
                    } else if (move == 'D')
                    {
                        newKey = 8;
                    } else if (move == 'L')
                    {
                        newKey = 4;
                    } else if (move == 'R')
                    {
                        newKey = 6;
                    }
                    break;

                case 6:
                    if (move == 'U')
                    {
                        newKey = 3;
                    } else if (move == 'D')
                    {
                        newKey = 9;
                    } else if (move == 'L')
                    {
                        newKey = 5;
                    }
                    break;

                case 7:
                    if (move == 'U')
                    {
                        newKey = 4;
                    } else if (move == 'R')
                    {
                        newKey = 8;
                    }
                    break;

                case 8:
                    if (move == 'U')
                    {
                        newKey = 5;
                    } else if (move == 'L')
                    {
                        newKey = 7;
                    } else if (move == 'R')
                    {
                        newKey = 9;
                    }
                    break;

                case 9:
                    if (move == 'U')
                    {
                        newKey = 6;
                    } else if (move == 'L')
                    {
                        newKey = 8;
                    }
                    break;
            }
            
            return newKey;
        }

        public char PartTwo(char moveTwo, char currentTwo)
        {
            switch (currentTwo)
            {
                case '1':
                    if (moveTwo == 'D')
                    {
                        newKeyTwo = '3';
                    }
                    break;

                case '2':
                    if (moveTwo == 'D')
                    {
                        newKeyTwo = '6';
                    }
                    else if (moveTwo == 'R')
                    {
                        newKeyTwo = '3';
                    }
                    break;

                case '3':
                    if (moveTwo == 'U')
                    {
                        newKeyTwo = '1';
                    }
                    else if (moveTwo == 'D')
                    {
                        newKeyTwo = '7';
                    }
                    else if (moveTwo == 'L')
                    {
                        newKeyTwo = '2';
                    }
                    else if (moveTwo == 'R')
                    {
                        newKeyTwo = '4';
                    }
                    break;

                case '4':
                    if (moveTwo == 'D')
                    {
                        newKeyTwo = '8';
                    }
                    else if (moveTwo == 'L')
                    {
                        newKeyTwo = '3';
                    }
                    break;

                case '5':
                    if (moveTwo == 'R')
                    {
                        newKeyTwo = '6';
                    }
                    break;

                case '6':
                    if (moveTwo == 'U')
                    {
                        newKeyTwo = '2';
                    }
                    else if (moveTwo == 'D')
                    {
                        newKeyTwo = 'A';
                    }
                    else if (moveTwo == 'L')
                    {
                        newKeyTwo = '5';
                    }
                    else if (moveTwo == 'R')
                    {
                        newKeyTwo = '7';
                    }
                    break;

                case '7':
                    if (moveTwo == 'U')
                    {
                        newKeyTwo = '3';
                    }
                    else if (moveTwo == 'D')
                    {
                        newKeyTwo = 'B';
                    }
                    else if (moveTwo == 'L')
                    {
                        newKeyTwo = '6';
                    }
                    else if (moveTwo == 'R')
                    {
                        newKeyTwo = '8';
                    }
                    break;

                case '8':
                    if (moveTwo == 'U')
                    {
                        newKeyTwo = '4';
                    }
                    else if (moveTwo == 'D')
                    {
                        newKeyTwo = 'C';
                    }
                    else if (moveTwo == 'L')
                    {
                        newKeyTwo = '7';
                    }
                    else if (moveTwo == 'R')
                    {
                        newKeyTwo = '9';
                    }
                    break;

                case '9':
                    if (moveTwo == 'L')
                    {
                        newKeyTwo = '8';
                    }
                    break;

                case 'A':
                    if (moveTwo == 'U')
                    {
                        newKeyTwo = '6';
                    } else if (moveTwo == 'R')
                    {
                        newKeyTwo = 'B';
                    }
                    break;

                case 'B':
                    if (moveTwo == 'U')
                    {
                        newKeyTwo = '7';
                    } else if (moveTwo == 'D')
                    {
                        newKeyTwo = 'D';
                    } else if (moveTwo == 'L')
                    {
                        newKeyTwo = 'A';
                    } else if (moveTwo == 'R')
                    {
                        newKeyTwo = 'C';
                    }
                    break;

                case 'C':
                    if (moveTwo == 'U')
                    {
                        newKeyTwo = '8';
                    } else if (moveTwo == 'L')
                    {
                        newKeyTwo = 'B';
                    }
                    break;

                case 'D':
                    if (moveTwo == 'U')
                    {
                        newKeyTwo = 'B';
                    }
                    break;
            }

            return newKeyTwo;
        }

    }
}
