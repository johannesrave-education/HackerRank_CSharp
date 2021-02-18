namespace HackerRank_CSharp
{
    class SockMerchant {

        // There is a large pile of socks that must be paired by color.
        // Given an array of integers representing the color of each sock,
        // determine how many pairs of socks with matching colors there are.
        public static int sockMerchant(int n, int[] socks)
        {
            bool[] socksChecked = new bool[socks.Length];
            int noOfPairs = 0;
            
            for (int i = 0; i < socks.Length; i++)
            {
                if (socksChecked[i]) continue;
            
                for (int j = i+1; j < socks.Length; j++)
                {
                    if (socksChecked[j]) continue;
                    
                    if (socks[i] == socks[j])
                    {
                        noOfPairs++;
                        socksChecked[i] = true;
                        socksChecked[j] = true;
                        break;
                    }
                }
            }

            return noOfPairs;
        }
        /*
        static void Main(string[] args) {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine());

            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
                ;
            int result = sockMerchant(n, ar);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
        */
    }
}