using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventofCode2016
{
    class Day3
    {
        string dayThreeAnswer;
        string[] input;
        string[] inputCut;
        List<string> inputList = new List<string>();
        int sideA, sideB, sideC;

        string startupPath = System.IO.Path.GetFullPath(@"..\..\");
        int count = 0;
        int countTwo = 0;

        public string DayThree()
        {
            using (StreamReader sr = new StreamReader(startupPath + @"\Day3\day3_input.txt"))
            {
                input = sr.ReadToEnd().Split('\r');
            }

            dayThreeAnswer = "Part 1: Total Possible Triangles: " + PartOne() + "\nDay 3: Part 2: Total Possible Triangles: " + PartTwo();
            return dayThreeAnswer;
        }

        public int PartOne()
        {
            foreach (string x in input)
            {
                inputCut = x.Trim().Replace("    ", ",").Replace("   ", ",").Replace("  ", ",").Replace(" ", ",").Split(',');

                sideA = Int32.Parse(inputCut[0]);
                sideB = Int32.Parse(inputCut[1]);
                sideC = Int32.Parse(inputCut[2]);

                if (sideA + sideB > sideC && sideA + sideC > sideB && sideB + sideC > sideA)
                {
                    count++;
                }
            }
            return count;
        }

        public int PartTwo()
        {
            foreach (string x in input)
            {
                inputList.Add(x.Substring(0, 6).Trim());
            }

            foreach (string x in input)
            {
                inputList.Add(x.Substring(6, 6).Trim());
            }

            foreach (string x in input)
            {
                inputList.Add(x.Substring(12).Trim());
            }

            for (int a = 0; a < inputList.Count-1; a += 3)
            {
                sideA = Int32.Parse(inputList[a]);
                sideB = Int32.Parse(inputList[a+1]);
                sideC = Int32.Parse(inputList[a+2]);

                if (sideA + sideB > sideC && sideA + sideC > sideB && sideB + sideC > sideA)
                {
                    countTwo++;
                }
            }

            return countTwo;
        }
    }
}
