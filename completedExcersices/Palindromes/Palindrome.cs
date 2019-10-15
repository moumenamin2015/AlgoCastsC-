using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoCastsCs.completedExcersices.Palindromes
{
    // --- Directions
    // Given a string, return true if the string is a palindrome
    // or false if it is not.  Palindromes are strings that
    // form the same word if it is reversed. *Do* include spaces
    // and punctuation in determining if the string is a palindrome.
    // --- Examples:
    //   palindrome("abba") === true
    //   palindrome("abcdefg") === false
    public static class Palindrome
    {
        public static bool PalindromeProblem(string str)
        {
            var result = false;
            var reversedString = new string(str.Reverse().ToArray());
            result = str.Equals(reversedString, StringComparison.OrdinalIgnoreCase);
            return result;
        }

        public static void Test()
        {
            var result = PalindromeProblem("abba");
            Debug.Assert(result);
            result = PalindromeProblem("abcdefg");
            Debug.Assert(result == false);
        }
    }
}
