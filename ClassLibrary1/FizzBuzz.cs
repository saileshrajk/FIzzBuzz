namespace ClassLibrary1
{
    public class FizzBuzz
    {
        private const string FIZZ = "Fizz";
        private const string BUZZ = "Buzz";
        private const string FIZZBUZZ = "FizzBuzz";

        public string From(int i)
        {
            if (i == 3)
            {
                return FIZZ;
            }
            if (i == 5)
            {
                return BUZZ;
            }
            if (i == 15)
            {
                return FIZZBUZZ;
            }
            return i.ToString();
        }
    }
}