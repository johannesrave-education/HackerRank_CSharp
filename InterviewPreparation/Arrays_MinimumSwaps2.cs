using System;
using Xunit;

namespace HackerRank_CSharp
{
    public class Arrays_MinimumSwaps2
    {
        static int minimumSwaps(int[] arr)
        {
            int swaps = 0;
            bool[] loopCheck = new bool[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == i + 1 || loopCheck[i])
                {
                    continue;
                }
                // Console.WriteLine($"Found swappable {arr[i]} at index {i}, it should be at index {arr[i]+1}.");
                
                bool searchingForClosedLoop = true;
                int testedPosition = i;
                int testedNumber = arr[i];

                while (searchingForClosedLoop)
                {
                    if (!loopCheck[testedPosition] && testedPosition != testedNumber-1)
                    {
                        loopCheck[testedPosition] = true;
                        testedPosition = arr[testedNumber-1];
                        testedNumber = arr[testedPosition];
                        Console.WriteLine($"{testedNumber} should be at index {testedNumber-1} but is at index {testedPosition}.");
                        swaps++;
                        
                    }
                    else
                    {
                        Console.WriteLine($"Loop completed: {testedNumber} at index{testedPosition} has already been marked.");
                        swaps--;
                        searchingForClosedLoop = false;
                    }
                }
            }

            return swaps;
        }


        public static void Main(string[] args)
        {
            int[] arr = {2,3,4,1,5};
            
            int res = minimumSwaps(arr);

            Assert.Equal(3,minimumSwaps(arr));
            
            // Console.WriteLine(res);
        }
    }
}