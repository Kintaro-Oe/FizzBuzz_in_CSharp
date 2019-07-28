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
    }
}
