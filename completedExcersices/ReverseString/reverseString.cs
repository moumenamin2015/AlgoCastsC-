using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoCastsCs.completedExcersices.reverseString
{
    // --- Directions
    // Given a string, return a new string with the reversed
    // order of characters
    // --- Examples
    //   reverse('apple') === 'leppa'
    //   reverse('hello') === 'olleh'
    //   reverse('Greetings!') === '!sgniteerG'
    public static class ReverseString
    {
        public static string ReverseStringProblem(string str)
        {
            if (string.IsNullOrEmpty(str)) return null;
            string result = "";
            for (int i = str.Length - 1; i > -1; i--)
            {
                result += str[i];
            }           
            return result;
        }
        public static void Test()
        {
            var reversed = ReverseStringProblem("abcd");
            Debug.Assert(reversed == "dcba");
        }
    }
}
