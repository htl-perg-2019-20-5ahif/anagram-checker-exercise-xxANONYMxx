using System;

namespace ClassLibrary
{
    public class AnagramChecker
    {
        public static Boolean IsAnagram(char[] wordArrayOne, char[] wordArrayTwo)
        {
            Array.Sort(wordArrayOne);
            Array.Sort(wordArrayTwo);

            string wordOne = new String(wordArrayOne);
            string wordTwo = new String(wordArrayTwo);

            if (wordOne == wordTwo)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
