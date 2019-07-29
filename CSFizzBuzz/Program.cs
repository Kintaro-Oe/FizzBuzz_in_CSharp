using System;
using CSFizzBuzz.Library;

namespace CSFizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(FizzBuzz.GetValue(i));
            }
        }
    }
}
