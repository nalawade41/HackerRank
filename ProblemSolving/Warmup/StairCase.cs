using HackerRank.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.ProblemSolving
{
    class StairCase: ISolver
    {
        public void Solve()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            staircase(n);
        }

        private void staircase(int n)
        {
            for (int i = 0; i < n; i++)
                Console.WriteLine(new String('#', i + 1).PadLeft(n, ' '));
        }
    }
}
