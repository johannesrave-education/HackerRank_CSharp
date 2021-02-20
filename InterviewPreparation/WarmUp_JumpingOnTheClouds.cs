using System;

namespace HackerRank_CSharp
{
    public class JumpingOnTheClouds
    {
        public static int jumpingOnClouds(int[] c) {
            int count = 0;
            for(int i = 0; i<c.Length;){
                Console.WriteLine(i);
                count++;
                if(i+2 == c.Length || i+3 == c.Length)
                {
                    break;
                }
            
                if (c[i+2]!=1)
                {
                    i+=2;
                }
                else
                {
                    i++;    
                }
            }
            return count;
        }
    }
}