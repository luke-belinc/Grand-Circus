using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace DataStructures
{
    class Program
    {
        // long variable to store time in milliseconds, static and global to Program class
        static long timer;

        static string ReverseStringStack(string str)
        {
            // get starting time in milliseconds
            timer = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;

            // initialize empty string to concatenate to
            List<string> wordList = new List<string>();

            foreach (string word in str.Split(" "))
            {
                // initialize stack using input string str
                Stack<char> strStack = new Stack<char>(word);
                // temporary string varaible
                string temp = "";
                // reverse string by popping stack
                while (strStack.Count > 0) temp += strStack.Pop();
                // add reversed word to wordList, keeping its place in original string
                wordList.Add(temp);
            }

            string reversed = string.Join(" ", wordList);

            // subtract starting time from ending time in milliseconds to get elapsed time
            timer = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond - timer;

            // join strings in wordList with a space and return that string
            return reversed;
        }

        static string ReverseStringLinq(string str)
        {
            // get current time
            timer = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
            // using Select to split string into words and then words into chars
            // Per each word create new string from letters starting at the end of the string, (e.g. using (^i+1))
            string reversed = string.Join(" ", str.Split(' ').Select(w => string.Concat(w.ToCharArray().Select((c, i) => w[^(i+1)]))));
            // subtract timer from current time to get elapsed time in millieseconds
            timer = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond - timer;

            // return reversed string
            return reversed;
        }

        static void Main(string[] args)
        {
            // get string from user
            Console.Write("\n\nPlease enter a string to be reversed (do not include numbers or symbols): ");
            string inStr = Console.ReadLine();

            // validate input using regex
            while (Regex.IsMatch(inStr, "[\\d!<,>.?\\/:;\"'{[}\\]|\\\\\\-_+=)(*&^%$#@!`~]+"))
            {
                Console.WriteLine($"Invalid input: \"{inStr}\"");
                Console.Write("\nPlease enter a string to be reversed without symbols or numbers: ");
                inStr = Console.ReadLine();
            }

            // output reversed string using ReverseStringStack
            Console.WriteLine("\n\nReversing using ReverseStringStack..." +
                              $"\nOutput: {ReverseStringStack(inStr)}" +
                              $"\nTotal time to reverse string: {timer} milliseconds\n");

            // output reversed string using ReverseStringLinq
            Console.WriteLine("\nReversing using ReverseStringLinq..." +
                              $"\nOutput: {ReverseStringLinq(inStr)}" +
                              $"\nTotal time to reverse string: {timer} milliseconds\n");
        }
    }
}
