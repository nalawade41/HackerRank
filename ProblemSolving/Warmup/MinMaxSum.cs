using HackerRank.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.ProblemSolving
{
    class MinMaxSum:ISolver
    {
        public void Solve()
        {
            long[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt64(arrTemp));
            miniMaxSum(arr);
        }

        private void miniMaxSum(long[] arr)
        {
            long sum = arr.Sum();
            long max = arr.Max();
            long min = arr.Min();
            Console.Write((sum - max) + " " + (sum - min));
        }
    }
}
