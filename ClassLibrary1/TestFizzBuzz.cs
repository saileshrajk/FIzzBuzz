﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ClassLibrary1
{
    [TestFixture]
    public class TestFizzBuzz
    {
        private FizzBuzz _fizzBuzz;

        [SetUp]
        public void Setup()
        {
            _fizzBuzz = new FizzBuzz();    
        }

        [TestCase(1, "1")]
        [TestCase(3, "Fizz")]
        public void Should_print_fizz_or_buzz_or_number_as_a_string_given_a_number(int inputNumber, string expected)
        {
            var result = _fizzBuzz.From(inputNumber);

            Assert.AreEqual(expected,result);
        }

        [Test]
        public void Should_print_Buzz_given_5_as_a_number()
        {
            var expected = "Buzz";

            var result = _fizzBuzz.From(5);

            Assert.AreEqual(expected, result);
        }
    }
}
