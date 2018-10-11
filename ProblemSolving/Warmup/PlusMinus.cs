using HackerRank.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.ProblemSolving
{
    class PlusMinus :ISolver
    {
        public void Solve()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            plusMinus(arr);
        }

        private void plusMinus(int[] arr)
        {
            int negetive = 0;
            int positive = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                positive += arr[i] > 0 ? 1 : 0;
                negetive += arr[i] < 0 ? 1 : 0;
            }
            Console.WriteLine(string.Format("{0:0.000000}", (decimal)positive / arr.Length));
            Console.WriteLine(string.Format("{0:0.000000}", (decimal)negetive / arr.Length));
            Console.WriteLine(string.Format("{0:0.000000}", (decimal)Math.Abs(arr.Length - (positive + negetive)) / arr.Length));
        }
    }
}
