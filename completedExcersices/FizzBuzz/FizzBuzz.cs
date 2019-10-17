using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoCastsCs.completedExcersices.FizzBuzz
{
    // --- Directions
    // Write a program that console logs the numbers
    // from 1 to n. But for multiples of three print
    // “fizz” instead of the number and for the multiples
    // of five print “buzz”. For numbers which are multiples
    // of both three and five print “fizzbuzz”.
    // --- Example
    //   fizzBuzz(5);
    //   1
    //   2
    //   fizz
    //   4
    //   buzz
    public static class FizzBuzz
    {
        public static List<string> FizzBuzzProblem(int n)
        {
            List<string> result = new List<string>();
            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    result.Add("fizzbuzz");
                }
                else if (i % 5 == 0)
                {
                    result.Add("buzz");
                }
                else if (i % 3 == 0)
                {
                    result.Add("fizz");
                }
                else
                {
                    result.Add(i.ToString());
                }
            }

            return result;
        }

        public static void Test()
        {
            List<string> expectedResult = new List<string>()
            {
                "1",
                "2",
                "fizz",
                "4",
                "buzz",
                "fizz",
                "7",
                "8",
                "fizz",
                "buzz",
                "11",
                "fizz",
                "13",
                "14",
                "fizzbuzz"
            };
            var result = FizzBuzzProblem(15);
            for (int i = 0; i < result.Count; i++)
            {
                Debug.Assert(result[i] == expectedResult[i]);
            }
        }
    }
}
