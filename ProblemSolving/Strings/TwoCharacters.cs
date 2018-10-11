using HackerRank.Interface;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.ProblemSolving.Strings
{
    class TwoCharacters: ISolver
    {
        public void Solve()
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int l = Convert.ToInt32(Console.ReadLine().Trim());

            string s = Console.ReadLine();

            int result = alternate(s);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }

        private int alternate(string s)
        {
            int count = 0;
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = i + 1; j < s.Length; j++)
                {
                    if (s[i] != s[j])
                    {
                        bool validString = true;
                        Stack<char> sta = new Stack<char>();
                        foreach (char c in s)
                        {
                            if (c == s[i] || c == s[j])
                            {
                                sta.Push(c);
                            }
                        }
                        char[] ca = sta.ToArray();
                        for (int k = 0; k < ca.Length - 1; k++)
                        {
                            if (ca[k] != ca[k + 1] && validString == true)
                            {
                                validString = true;
                            }
                            else
                            {
                                validString = false;
                            }
                        }
                        if (validString == true && ca.Length > count)
                        {
                            count = ca.Length;
                        }
                    }
                }
            }
            return count;
        }
    }
}
