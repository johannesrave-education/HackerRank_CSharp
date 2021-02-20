using System;
using System.Linq;

namespace HackerRank_CSharp
{
    public class Arrays_LeftRotation
    {

        // Complete the rotLeft function below.
        static int[] rotLeft(int[] a, int d)
        {
            int len = a.Length;
            int offset = d % len;
            
            int[] res = new int[len];
            Array.Copy(a, res, 0);
            
            for (int i = 0; i < len; i++)
            {
                int oldIndex = i + offset;
                int newIndex = (oldIndex < len) ? oldIndex : oldIndex - len;
                res[i] = a[newIndex];
            }

            return res;
        }

        public static void Main(string[] args)
        {

            int n = 4;

            int d = 4;

            int[] a = new int[] {1, 2, 3, 4, 5};

            int[] result = rotLeft(a, d);

            Console.WriteLine(String.Join(",", result));
        }
    }
}