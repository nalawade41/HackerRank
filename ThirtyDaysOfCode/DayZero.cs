using HackerRank.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.ThirtyDaysOfCode
{
    class DayZero: ISolver
    {
        public void Solve()
        {
            // Declare a variable named 'inputString' to hold our input.
            string inputString;

            // Read a full line of input from stdin (cin) and save it to our variable, input_string.
            inputString = Console.ReadLine();

            // Print a string literal saying "Hello, World." to stdout using cout.
            Console.WriteLine("Hello, World.");

            // Line of code here that prints the contents of input_string to stdout.
            Console.WriteLine(inputString);
        }
    }
}
