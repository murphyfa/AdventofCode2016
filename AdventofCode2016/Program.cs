using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventofCode2016
{
    class Program
    {
        static void Main(string[] args)
        {
            Day1 dayOne = new Day1();
            Console.WriteLine("Day 1: " + dayOne.DayOne());

            Day2 dayTwo = new Day2();
            Console.WriteLine("Day 2: " + dayTwo.DayTwo());


            Console.ReadLine();
        }
    }
}
