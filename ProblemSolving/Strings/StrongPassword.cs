using HackerRank.Interface;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.ProblemSolving.Strings
{
    class StrongPassword: ISolver
    {
        public void Solve()
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine());

            string password = Console.ReadLine();

            int answer = minimumNumber(n, password);

            textWriter.WriteLine(answer);

            textWriter.Flush();
            textWriter.Close();
        }

        private int minimumNumber(int n, string password)
        {
            // Return the minimum number of characters to make the password strong
            bool isNumebr = false;
            bool isLowerCase = false;
            bool isUpperCase = false;
            bool isSpecialCharacter = false;
            string special_characters = "!@#$%^&*()-+";
            foreach (char c in password)
            {
                if (c >= 65 && c <= 90)
                    isUpperCase = true;
                if (c >= 97 && c <= 122)
                    isLowerCase = true;
                if (c >= 48 && c <= 57)
                    isNumebr = true;
                if (special_characters.Contains(c))
                    isSpecialCharacter = true;

                if (isUpperCase && isLowerCase && isNumebr && isSpecialCharacter) break;
            }

            if (isUpperCase && isLowerCase && isNumebr && isSpecialCharacter && n > 5)
            {
                return 0;
            }
            int count = 0;
            count += isUpperCase ? 0 : 1;
            count += isLowerCase ? 0 : 1;
            count += isNumebr ? 0 : 1;
            count += isSpecialCharacter ? 0 : 1;
            return Math.Max(count, 6 - password.Length);
        }
    }
}
