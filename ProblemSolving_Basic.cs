using System;
using System.Collections.Generic;
using System.Linq;

class ProblemSolving_Basic
{

    /*
     * Complete the 'stringAnagram' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts following parameters:
     *  1. STRING_ARRAY dictionary
     *  2. STRING_ARRAY query
     */

    public static List<int> stringAnagram(List<string> dictionary, List<string> query)
    {
        int[] anagramsInQuery = new int[query.Count];
        int[] noOfAnagrams = new int[query.Count];
        
        anagramsInQuery = anagramsInQuery.Select(i => -1).ToArray();
        
        // First to check whether any query strings are already anagrams.
        for(int i = 0; i < query.Count; i++)
        {
            if (anagramsInQuery[i] != -1) continue;
            char[] A = query[i].ToCharArray();
            Array.Sort(A);

            for(int j = i+1; j < query.Count; j++)
            {
                char[] B = query[j].ToCharArray();
                
                if(A.Length != B.Length) continue;                               
                Array.Sort(B);
                
                if (Enumerable.SequenceEqual(A, B))
                {
                    anagramsInQuery[j] = i;
                    break;
                }
            }           
        }
        
        
        for(int i = 0; i < query.Count; i++)
        {
            if (anagramsInQuery[i] != -1) {
                noOfAnagrams[i] = noOfAnagrams[anagramsInQuery[i]];
                continue;
            }
            char[] A = query[i].ToCharArray();
            Array.Sort(A);

            for(int j = 0; j < dictionary.Count; j++)
            {
                char[] B = dictionary[j].ToCharArray();
                
                if(A.Length != B.Length) continue;
                
                               
                Array.Sort(B);
                
                if (Enumerable.SequenceEqual(A, B))
                {
                    //Console.WriteLine($"Anagram found! {query[i]} and {dictionary[j]}");
                    noOfAnagrams[i]++;
                    
                }
            }
            
            //Console.WriteLine($"{query[i]} has {noOfAnagrams[i]} anagrams.");
        }

        return noOfAnagrams.ToList();
    }
}