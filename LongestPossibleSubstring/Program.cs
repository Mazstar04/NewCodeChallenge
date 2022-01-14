using System;

namespace LongestPossibleSubstring
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "croboorocoboo";
            LongestSubstring(word);
        }

        public static void LongestSubstring(string word)
        {
            string replica = word;
            string t = "";
            string subString = "";
            for (int i = 0; i < word.Length; i++)
            {
                t = replica[0].ToString();
                replica = replica.Remove(0, 1);


                if (subString == "")
                {
                    if (replica.Contains(t))
                    {
                        subString += t;
                    }
                    continue;
                }
                else
                {
                    if (replica.Contains(subString + t))
                    {
                        subString += t;

                    }
                }
            }
            Console.WriteLine(subString);
        }
    }
}


