using System;
using System.Collections.Generic;

namespace DevInterviewQuestions
{
    class Program
    {
        static void Main(string[] args)
        {
            string reversedString = ReverseString("Hello");

            Console.WriteLine(reversedString);

            var input = new int[][] { new[] { 1, 1, 5, 8 }, new[] { 1, 0, 9, 6 }, new[] { 4, 5, 7, 9 } };
            var output = new int[][] { new[] { 1, 0, 5, 8 }, new[] { 0, 0, 0, 0 }, new[] { 4, 0, 7, 9 } };



            Console.ReadLine();
        }


        public static string ReverseString(string input)
        {
            int strLength = input.Length;

            string output = new string("");

            for (int i = strLength-1; i > -1; i--)
            {
                output = string.Concat(output, input[i]);
            }

            return output;
        }

        public int[][] Answer(int[][] input)
        {
            var rows = input.Length;
            var columns = input[0].Length;

            var zeroCoordinates = new List<int[]>();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (input[i][j] == 0)
                    {
                        zeroCoordinates.Add(new[] { i, j });
                    }
                }
            }

            foreach (int[] coordinate in zeroCoordinates)
            {

            }
        }
    }
}
