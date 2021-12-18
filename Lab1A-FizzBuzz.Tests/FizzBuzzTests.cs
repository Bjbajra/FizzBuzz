using NUnit.Framework;
using System;

namespace Lab1A_FizzBuzz.Tests
{
    [TestFixture]
    public class FizzBuzzTests
    {
       
        [Test]
        [TestCase(1, "1")]
        [TestCase(3, "Fizz")]
        [TestCase(5, "Buzz")]
        [TestCase(15, "FizzBuzz")]
        [TestCase(30, "FizzBuzz")]
        public void FizzBuzz_GivenNumber_ReturnsCorrectResult(int numberToCheck, string expectedResult)
        {
            //Arrange

            //Act
            var actualResult = FizzBuzz.CaluclateFizzBuzz(numberToCheck);
            
            //Assert
            Assert.That(actualResult, Is.EqualTo(expectedResult),
                string.Format("result of entered number [{0}] is [{1}] but it should be [{2}]", numberToCheck,
                                           actualResult, expectedResult));                           
        }


        [Test]
        //[Ignore("Ignore a test")]        
        public void FizzBuzz_GivenNumberDivisibleBy3_ReturnsFizz()
        {
            //Arrange
            int numberToCheck = 3;

            //Act
            var result = FizzBuzz.CaluclateFizzBuzz(numberToCheck);

            //Assert
            Assert.That(result, Is.EqualTo("Fizz"),
                 string.Format("result of entered number [{0}] is [{1}] but it should be [{2}]", numberToCheck,
                                           result, "Fizz"));
            //Assert.That(FizzBuzz.CaluclateFizzBuzz(3), Is.EqualTo("Fizz"));
            //Assert.That(FizzBuzz.CaluclateFizzBuzz(6), Is.EqualTo("Fizz"));
            //Assert.That(FizzBuzz.CaluclateFizzBuzz(9), Is.EqualTo("Fizz"));
        }


        [Ignore("Ignore a test")]
        public void FizzBuzz_GivenNumberDivisibleBy5_ReturnsBuzz()
        {
            //Arrange

            //Act

            //Assert
            Assert.That(FizzBuzz.CaluclateFizzBuzz(5), Is.EqualTo("Buzz"));
            Assert.That(FizzBuzz.CaluclateFizzBuzz(20), Is.EqualTo("Buzz"));           
        }
        
      
        [Ignore("Ignore a test")]
        public void FizzBuzz_GivenNumberDivisibleBy15_ReturnsFizzBuzz()
        {
            //Arrange

            //Act

            //Assert
            Assert.That(FizzBuzz.CaluclateFizzBuzz(30), Is.EqualTo("FizzBuzz"));
            Assert.That(FizzBuzz.CaluclateFizzBuzz(45), Is.EqualTo("FizzBuzz"));
            Assert.That(FizzBuzz.CaluclateFizzBuzz(75), Is.EqualTo("FizzBuzz"));
        }
        
         
        
        [Ignore("Ignore a test")]
        public void FizzBuzz_GivenNumberIsNotDivisibleBy3_5_Or_15_ReturnsNumber()
        { 
            //Arrange
            
            //Act

            //Assert
            Assert.That(FizzBuzz.CaluclateFizzBuzz(7), Is.EqualTo("7"));
            Assert.That(FizzBuzz.CaluclateFizzBuzz(17), Is.EqualTo("17"));
            Assert.That(FizzBuzz.CaluclateFizzBuzz(1), Is.EqualTo("1"));
        }
    }
}