using HackerRank.Interface;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.ProblemSolving
{
    class DigonalDifferences: ISolver
    {
        public void Solve()
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine());

            int[][] arr = new int[n][];

            for (int i = 0; i < n; i++)
            {
                arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            }

            int result = diagonalDifference(arr);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }

        private int diagonalDifference(int[][] arr)
        {
            int leftDigonal = 0;
            int rightDigonal = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                leftDigonal += arr[i][i];
                rightDigonal += arr[i][(arr.Length - 1) - i];
            }
            return Math.Abs(leftDigonal - rightDigonal);
        }

    }
}
