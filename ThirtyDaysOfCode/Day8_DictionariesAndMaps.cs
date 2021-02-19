namespace HackerRank_CSharp.ThirtyDaysOfCode
{
    using System;
    using System.Collections.Generic;
    class Solution {
    
        static Dictionary<string, string> phoneBook = new Dictionary<string, string>();
    
        static void SaveToPhoneBook(string name, string number)
        {
            phoneBook.Add(name, number);
        }
    
        static void PrintNumber(string name)
        {
            if (!phoneBook.ContainsKey(name))
            {
                Console.WriteLine("Not found");
            }
            else
            {
                Console.WriteLine($"{name}={phoneBook[name]}");
            }
        }
    
        static void Main(String[] args) 
        {
            int noOfEntries = int.Parse(Console.ReadLine());
            for (int i = 0; i < noOfEntries; i++)
            {
                var entry = Console.ReadLine().Split(' ');
                var name = entry[0];
                var number = entry[1];
                SaveToPhoneBook(name, number);
            }
        
            string lookup;
            while ((lookup = Console.ReadLine()) != null) 
            {
                PrintNumber(lookup);
            }
        }
    }
}