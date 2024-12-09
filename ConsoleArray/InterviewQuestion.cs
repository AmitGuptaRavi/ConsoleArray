using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleArray
{
    public static class InterviewQuestion
    {
        public static string top2mostrepetingcaharactor()
        {
            string str = "Hello, World!"; 
            char[] charArray = str.ToCharArray(); 
            var charGroups = charArray
                .Where(c => Char.IsLetter(c)) // Filter to count only letters
                .GroupBy(c => c)               // Group by character
                .Select(g => new { Char = g.Key, Count = g.Count() })  // Select the character and its count
                .OrderByDescending(x => x.Count) // Order by frequency in descending order
                .Take(2); // Get the top 2 most frequent characters

            // Output the two most frequent characters
            Console.WriteLine("The two most frequent characters are:");
            foreach (var item in charGroups)
            {
                Console.WriteLine($"Character: '{item.Char}' appears {item.Count} times.");
            }
            Console.ReadLine();
            return "";
        }
    }
}
