using System;
using System.Text;

namespace P13308092022HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task  1
            //Console.WriteLine("Cumleni Daxil Et:");
            //string sentences = Console.ReadLine();

            //ReverseSentences(sentences);
            #endregion

            #region Task 2
            Console.WriteLine("Daxil Et:");
            string sentences = Console.ReadLine();
            Console.WriteLine(LongWordInSentences(sentences));
            #endregion
        }

        #region Task 1
        static StringBuilder ReverseSentences(string sentences)
        {
            string[] words = sentences.Split(' ');
            StringBuilder result = new StringBuilder();

            foreach (string word in words)
            {
                for (int i = word.Length - 1; i >= 0; i--)
                {
                    result.Append(word[i]);
                }

                if (word != words[words.Length - 1])
                {
                    result.Append('-');
                }
            }

            return result;
        }
        #endregion

        #region Task 2
        static string LongWordInSentences(string sentences)
        {
            string[] words = sentences.Split(' ');
            string word = "";
            int maxLength = 0;

            foreach (string item in words)
            {
                if (item.Length > maxLength)
                {
                    maxLength = item.Length;
                    word = item;
                }
            }

            return word;
        }
        #endregion
    }
}
