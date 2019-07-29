using System;

namespace CSFizzBuzz.Library
{
    public class FizzBuzz
    {
        public static string GetValue(int input)
        {
            if (input % 3 == 0)
            {
                return "Fizz";
            }
            else if (input == 5)
            {
                return "Buzz";
            }
            return input.ToString();
        }
    }
}
