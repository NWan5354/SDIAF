using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace CourseworkExercise2__Unit_Testing_
{
    [TestClass]
    public class Problem1
    {
        [TestMethod]
        public void Problem1_ShouldReturnASumOf23GivenThatTheMultiplesAre3Or5AndLessThan10()
        {
            // Arrange
            var multiple = new Multiple(3, 5, 10);

            // Act
            var result = multiple.calculateAnswer();

            // Assert
            Assert.AreEqual(result, 23);

        }

        [TestMethod]
        public void Problem1_ShouldReturnASumOf233168GivenThatTheMultiplesAre3Or5AndLessThan1000()
        {
            // Arrange
            var multiple = new Multiple(3, 5, 1000);

            // Act
            var result = multiple.calculateAnswer();

            // Assert
            Assert.AreEqual(result, 233168);

        }
    
    }

    class Multiple // Creating a new class of Multiple
    {
        private int total = 0;

        private int _startNumber = 0;
        private int _firstMultiple;
        private int _secondMultiple;
        private int _endNumber;

        public Multiple(int firstMultiple, int secondMultiple, int endNum)
        {
            _firstMultiple = firstMultiple;
            _secondMultiple = secondMultiple;
            _endNumber = endNum;
        }

        public int calculateAnswer()
        {
            for (int i = _startNumber; i < _endNumber; i++)
            {
                if (i % _firstMultiple == 0 || i % _secondMultiple == 0)
                {
                    total += i;
                }
            }
            return total;
        }
    }
}
