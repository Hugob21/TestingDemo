using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    [TestFixture]
    public class OperationsNUnitTest
    {
        [Test]
        public void Add_InputNumbers_ReturnNumber() 
        {
            // 1. Arrange
            Operations operations = new Operations();
            int number1 = 2;
            int number2 = 5;
            int expectedResult = 7;
            
            // 2. Act
            int result = operations.Add(number1, number2);

            // 3. Assert
            Assert.That(result, Is.EqualTo(expectedResult));
            Assert.That(result, Is.Not.EqualTo(8));
            Assert.That(result, Is.Not.EqualTo(6));
        }

        [Test]
        [TestCase(10)]
        [TestCase(12)]
        [TestCase(14)]

        public void IsEven_InputNumber_ReturnTrue(int number)
        {
            // 1. Arrange
            Operations operations = new Operations();
            //int number = 12;

            // 2. Act
            var result = operations.IsEven(number); 
            
            // 3. Assert
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(2.2, 1.2)]
        //[TestCase(2.23, 1.24)]

        public void AddDecimal_InputDoubleNumbers_ReturnDoubleNumber(double number1, double number2)
        {
            Operations operations = new Operations();

            var result = operations.AddDecimal(number1, number2);
            
            Assert.That(result, Is.EqualTo(3.4).Within(0.1));

        }

        public void GetEvenNumbers_InputRange_ReturnEvenNumbers()
        {
            //1. Arrange
            Operations operations = new();
            int start = 0;
            int end = 10;

            //2. Act 
            var result = operations.GetEvenNumbers(start, end);

            //3. Assert

            Assert.That(result, Is.Not.Empty);
            Assert.That(result.Count, Is.EqualTo(5));
            Assert.That(result, Has.Exactly(5).Items);

        }
    }
}
