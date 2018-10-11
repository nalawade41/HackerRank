using HackerRank.Interface;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.ProblemSolving
{
    class TimeConversion: ISolver
    {
        public void Solve()
        {
            TextWriter tw = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string s = Console.ReadLine();

            string result = timeConversion(s);

            tw.WriteLine(result);

            tw.Flush();
            tw.Close();
        }

        private string timeConversion(string s)
        {
            DateTime dateTime = DateTime.ParseExact(s, "hh:mm:sstt", System.Globalization.CultureInfo.InvariantCulture);
            return dateTime.ToString("HH:mm:ss");
        }
    }
}
