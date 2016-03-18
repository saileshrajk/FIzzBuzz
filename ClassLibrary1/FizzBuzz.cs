using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace ClassLibrary1
{
    public class FizzBuzz
    {
        private const string FIZZ = "Fizz";
        private const string BUZZ = "Buzz";
        private const string FIZZBUZZ = "FizzBuzz";

        public string From(int i)
        {
            if (i % 15 == 0)
            {
                return FIZZBUZZ;
            }
            if (i % 3 == 0)
            {
                return FIZZ;
            }
            if (i % 5 == 0)
            {
                return BUZZ;
            }
            
            return i.ToString();
        }

        public List<string> Print1To100()
        {
            var printedNumbers = new List<string>();
            for (int i = 1; i <= 100; i++)
            {
                printedNumbers.Add(From(i));
            }
            return printedNumbers;
        }
    }
}