using System;
using System.Linq;

namespace LongestCommonSubsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKey key = ConsoleKey.Escape;
            do
            {
                //"MZJAWXU", "XMJYAUZ"
                Console.Write("Enter first sequence of characters: ");
                var x = Console.ReadLine();
                Console.Write("Enter second sequence of characters: ");
                var y = Console.ReadLine();

                LCS first = new LCS(x, y);

                var allSubsequences = first.GetAllLongestSubsequences();
                Console.WriteLine($"Longest subsequence lenght: {(allSubsequences.Count > 0 ? allSubsequences.First().Length : 0)}.\nLongest subsequences:");
                foreach (string subsequence in allSubsequences)
                {
                    Console.WriteLine(subsequence);
                }
                Console.WriteLine("ESC to exit/Any to continue.");
                key = Console.ReadKey().Key;
            } while (key != ConsoleKey.Escape);
            
        }
    }
}
