namespace Assignment_7_2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Assignment 7.2.3
             * 
             * Given two strings s and t, return true if t is an anagram of s, and false otherwise.
             * An Anagram is a word or phrase formed by rearranging the letters of a different word 
             * or phrase, typically using all the original letters exactly once.
             */

            string s = "Oneeyo";
            string t = "Eeonyy";

            Console.WriteLine($"The word {t} is an anagram of {s}: {IsAnagram(s, t)}");
        }

        static bool IsAnagram( string s_, string t_ )
        {
            // Edge case
            // If the lengths do not match then it cannot be an anagram
            if ( s_.Length != t_.Length )
                return false;

            s_ = s_.ToLower();
            t_ = t_.ToLower();

            Dictionary<Char, int> dict = new Dictionary<Char, int>();

            foreach ( char c in s_)
            {
                if (dict.ContainsKey(c))
                    dict[c]++;
                else dict[c] = 1;
            }

            foreach ( char c in t_)
            {
                if (!dict.ContainsKey(c) || dict[c] == 0)
                    return false;
                dict[c]--;
            }

            return true;
        }
    }
}
