﻿using System;

namespace CSFizzBuzz.Library
{
    public class FizzBuzz
    {
        public static string GetValue(int input)
        {
            if (input == 3)
            {
                return "Fizz";
            }

            return input.ToString();
        }
    }
}
