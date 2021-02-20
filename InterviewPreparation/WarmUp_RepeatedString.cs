using System;

namespace HackerRank_CSharp
{
    public class RepeatedString
    {
        static long repeatedString(string s, long n)
        {
            var sLength = s.Length;
            
            long noOfStrings = n / sLength;
            long partialLength = n % sLength;
            int aInString = 0;
            int aInPartialString = 0;

            for (int i = 0; i < sLength; i++)
            {
                if (s[i] == 'a')
                {
                    aInString++;
                    if (i < partialLength)
                    {
                        aInPartialString++;
                    }
                }
            }

            return (noOfStrings * aInString) + aInPartialString;
        }

        public static void Main(string[] args) {
            string s = "aba";

            long n = 10;

            long result = repeatedString(s, n);

            Console.WriteLine(result);
        }
    }
}