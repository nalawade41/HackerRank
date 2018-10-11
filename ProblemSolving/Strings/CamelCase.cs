using HackerRank.Interface;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.ProblemSolving.Strings
{
    class CamelCase: ISolver
    {
        public void Solve()
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string s = Console.ReadLine();

            int result = camelcase(s);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }

        private int camelcase(string s)
        {
            int count = 1;
            foreach (char c in s)
            {
                if (c >= 65 && c <= 90)
                    count++;
            }
            return count;

        }
    }
}
