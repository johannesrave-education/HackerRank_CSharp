using System;
using System.Linq;

class CountingValleys
{

    /*
     * Complete the 'countingValleys' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER steps
     *  2. STRING path
     */

    public static int countingValleys(int steps, string path)
    {
        int noOfValleys = 0;
        int altitude = 0;

        path.ToArray().ToList().ForEach(c =>
        {
            Console.WriteLine($"letter:{c} altitude:{altitude}");
            if(c == 'D')
            {
                if(altitude == 0)
                    noOfValleys++;
                altitude--;
            }
            else if (c == 'U')
            {
                altitude++;
            }
        });
        
        return noOfValleys;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine(countingValleys(0, "DDUUUUDDDDDDDUU"));
    }
}
