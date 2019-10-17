﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgoCastsCs.completedExcersices.Maxchar;
using AlgoCastsCs.completedExcersices.Palindromes;
using AlgoCastsCs.completedExcersices.reverseString;

namespace AlgoCastsCs
{
    class Program
    {
        static void Main(string[] args)
        {
            ReverseString.ReverseStringProblem("abcd");
            ReverseString.ReverseStringProblem2("abcd");
            ReverseString.Test();
            /////////////////////////////////////// 
            Palindrome.PalindromeProblem("ab  ba");
            Palindrome.PalindromeProblem("abcdefg");
            Palindrome.Test();
            ///////////////////////////////////////
            MaxChar.MaxCharProblem("abcdefghijklmnaaaaa");
            MaxChar.MaxCharProblem("ab1c1d1e1f1g1");
            Palindrome.Test();
        }

    }
}
