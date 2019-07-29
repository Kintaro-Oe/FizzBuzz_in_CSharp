using NUnit.Framework;

namespace CSFizzBuzz.Library.tests

{
    public class FizzBuzzTests
    {
        [Test]
        public void FizzBuzz_When1_Returns1()
        {
            // Arrange
            int input = 1;

            // Act 
            string output = FizzBuzz.GetValue(input);

            // Assert
            Assert.AreEqual("1", output);
        }

        [Test]
        public void FizzBuzz_When2_Returns2()
        {
            int input = 2;
            string output = FizzBuzz.GetValue(input);
            Assert.AreEqual("2", output);
        }

        [Test]
        public void FizzBuzz_WhenDivisibleBy3_ReturnsFizz(
            [Values(3, 6, 9)] int input)
        {
            string output = FizzBuzz.GetValue(input);
            Assert.AreEqual("Fizz", output);
        }

        [Test]
        public void FizzBuzz_WhenDivisibleBy5_ReturnsBuzz(
            [Values(5, 10, 20)] int input)
        {
            string output = FizzBuzz.GetValue(input);
            Assert.AreEqual("Buzz", output);
        }

        [Test]
        public void FizzBuzz_WhenDivisibleBy3And5_ReturnsFizzBuzz(
            [Values(15, 30)] int input)
        {
            string output = FizzBuzz.GetValue(input);
            Assert.AreEqual("FizzBuzz", output);
        }
    }
}
