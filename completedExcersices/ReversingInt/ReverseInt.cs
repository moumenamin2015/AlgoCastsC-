using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AlgoCastsCs.completedExcersices.ReversingInt
{
    // --- Directions
    // Given an integer, return an integer that is the reverse
    // ordering of numbers.
    // --- Examples
    //   reverseInt(15) === 51
    //   reverseInt(981) === 189
    //   reverseInt(500) === 5
    //   reverseInt(-15) === -51
    //   reverseInt(-90) === -9
    public static class ReverseInt
    {
        public static int ReverseIntProblem(int n)
        {
            var numberSign = Math.Sign(n);
            var numberString = Math.Abs(n).ToString();
            var reversedNumberString = new string(numberString.Reverse().ToArray());
            var result = Convert.ToInt32(reversedNumberString) * numberSign;
            return result;
        }

        public static void Test()
        {
            Debug.Assert(ReverseIntProblem(0) == 0);
            Debug.Assert(ReverseIntProblem(5) == 5);
            Debug.Assert(ReverseIntProblem(15) == 51);
            Debug.Assert(ReverseIntProblem(90) == 9);
            Debug.Assert(ReverseIntProblem(2359) == 9532);
            Debug.Assert(ReverseIntProblem(-5) == -5);
            Debug.Assert(ReverseIntProblem(-15) == -51);
            Debug.Assert(ReverseIntProblem(-90) == -9);
            Debug.Assert(ReverseIntProblem(-2359) == -9532);
        }
    }
}
