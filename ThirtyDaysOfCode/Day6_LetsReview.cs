using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_CSharp.ThirtyDaysOfCode
{
    public class Day6_LetsReview
    {
        public static void Main(string[] args) {
            int noOfEntries = int.Parse(Console.ReadLine());
            var result = new List<string>();
            
            for (int j = 0; j < noOfEntries; j++)
            {
                string s = Console.ReadLine();

                var s0 = new StringBuilder();
                var s1 = new StringBuilder();

                for (int i = 0; i < s.Length; i++)
                {
                    if (i % 2 == 0) s0.Append(s[i]);
                    else s1.Append(s[i]);
                }
                result.Add(s0.Append(" ").Append(s1).ToString());
            }

            foreach (var s in result)
            {
                Console.WriteLine(s);
            }
            
            
        }
    }
}