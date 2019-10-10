using System;
using ClassLibrary;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args[0] == "check" && args[1] != null && args[2] != null)
            {
                checkAnagram(args);
            }
        }

        private static void checkAnagram(string[] args)
        {
            var check = ClassLibrary.AnagramChecker.IsAnagram(args[1].ToCharArray(), args[2].ToCharArray());

            if (check)
            {
                Console.WriteLine(args[1] + " and " + args[2] + "are anagrams.");
            }
            else
            {
                Console.WriteLine(args[1] + " and " + args[2] + "are not anagrams.");
            }
        }
    }
}
