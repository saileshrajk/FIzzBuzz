namespace ClassLibrary1
{
    public class FizzBuzz
    {
        public string From(int i)
        {
            if (i == 3)
            {
                return "Fizz";
            }
            if (i == 5)
            {
                return "Buzz";
            }
            return i.ToString();
        }
    }
}