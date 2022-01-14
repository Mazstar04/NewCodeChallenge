using System;
using System.Collections.Generic;
using System.Linq;

namespace LongestPossibleSubstring
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] arrayOfInt = new int[]{1,6,1};
            distanceAmongAllPairs(arrayOfInt, 3);
            

        }

        public static void distanceAmongAllPairs (int[] arrayOfInt, int k)
        {
            List<int> diff = new List<int>();

            for(int i = 0; i<arrayOfInt.Length; i++)
            {
                for(int j = i+1; j< arrayOfInt.Length; j++)
                {
                    if(j != i && i != arrayOfInt.Count()-1)
                    {
                     diff.Add(Math.Abs(arrayOfInt[i] - arrayOfInt[j]));
                    }
                }
            }
            diff.Sort();
            Console.WriteLine(diff[k-1]);
        }
    }
}
