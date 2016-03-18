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

        [Test]
        public void Should_print_1__as_a_string_given_1_as_a_number()
        {
            var expected = "1";
            
            var result = _fizzBuzz.From(1);

            Assert.AreEqual(expected,result);
        }

        [Test]
        public void Should_print_Fizz_given_3_as_a_number()
        {
            var expected = "Fizz";

            var result = _fizzBuzz.From(3);
            
            Assert.AreEqual(expected, result);
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
