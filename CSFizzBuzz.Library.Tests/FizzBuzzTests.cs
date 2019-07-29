//using CSFizzBuzz.Library;
using NUnit.Framework;

//namespace Tests
namespace CSFizzBuzz.Library.tests

{
    public class FizzBuzzTests
    {
        //[SetUp]
        //public void Setup()
        //{
        //}

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
        public void FizzBuzz_When3_ReturnsFizz()
        {
            int input = 3;
            string output = FizzBuzz.GetValue(input);
            Assert.AreEqual("Fizz", output);
        }
    }
}
