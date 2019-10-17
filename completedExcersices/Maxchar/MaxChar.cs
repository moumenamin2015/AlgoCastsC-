using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoCastsCs.completedExcersices.Maxchar
{

    // --- Directions
    // Given a string, return the character that is most
    // commonly used in the string.
    // --- Examples
    // maxChar("abcccccccd") === "c"
    // maxChar("apple 1231111") === "1"
    public static class MaxChar
    {
        public static char MaxCharProblem(string str)
        {
            var result = char.MinValue;
            Dictionary<char, int> dictionary = new Dictionary<char, int>();
            foreach (var character in str)
            {
                if (dictionary.ContainsKey(character))
                    dictionary[character]++;
                else
                    dictionary.Add(character, 1);
            }

            int maxCount = 0;
            foreach (var charCount in dictionary)
            {
                if (charCount.Key > maxCount)
                    result = charCount.Key;
            }
            return result;
        }

        public static void Test()
        {
            Debug.Assert(MaxCharProblem("abcdefghijklmnaaaaa") == 'a');
            Debug.Assert(MaxCharProblem("ab1c1d1e1f1g1") == '1');            
        }
    }
}
