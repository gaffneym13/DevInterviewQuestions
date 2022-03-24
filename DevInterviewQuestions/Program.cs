using System;

namespace DevInterviewQuestions
{
    class Program
    {
        static void Main(string[] args)
        {
            string reversedString = ReverseString("Hello");

            Console.WriteLine(reversedString);

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
    }
}
