using System;

namespace HackerRank_CSharp
{
    public class Arrays_2DArray
    {
        
        // Complete the hourglassSum function below.
        static int hourglassSum(int[][] arr)
        {
            int max = int.MinValue;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    var sum = arr[i]  [j] + arr[i]  [j+1] + arr[i]  [j+2] +
                                            arr[i+1][j+1] + 
                              arr[i+2][j] + arr[i+2][j+1] + arr[i+2][j+2];
                    if (max < sum)
                    {
                        Console.WriteLine($"at {i},{j}: {max} < {sum}");
                        max = sum;
                    }
                }
            }
            return max;
        }

        public static void Main(string[] args) {
            int[][] arr = {
                new []{1,1,1,0,0,0},
                new []{0,1,0,0,0,0},
                new []{1,1,1,0,0,0},
                new []{0,0,2,4,4,0},
                new []{0,0,0,2,0,0},
                new []{0,0,1,2,4,0}
                
            };

            int result = hourglassSum(arr);
            Console.WriteLine(result);
        }
    }
}