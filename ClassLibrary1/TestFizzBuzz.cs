using System;
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
        [TestCase(5, "Buzz")]
        [TestCase(15, "FizzBuzz")]
        [TestCase(14, "14")]
        public void Should_print_fizz_or_buzz_or_number_as_a_string_given_a_number(int inputNumber, string expected)
        {
            var result = _fizzBuzz.From(inputNumber);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Should_produce_a_list_of_100_items()
        {
            var expectedListCount = 100;

            var printedNumbers = _fizzBuzz.Print1To100();

            Assert.AreEqual(expectedListCount, printedNumbers.Count);
        }

        [TestCase(new[] { "73", "74", "4", "Fizz", "Buzz", "FizzBuzz" }, new[] { 73, 74, 4, 3, 5, 15 })]
        [TestCase(new[] { "Fizz", "Buzz", "FizzBuzz" }, new[] { 12, 50, 60 })]
        public void Should_return_list_with_specified_value_in_specified_index(string[] expectedValues, int[] index)
        {
            var actualValues = new List<string>();
            var printedNumbers = _fizzBuzz.Print1To100();
            foreach (var i in index)
            {
                actualValues.Add(printedNumbers[i - 1]);
            }

            Assert.AreEqual(expectedValues, actualValues);
        }


    }
}
