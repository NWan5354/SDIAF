using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CourseworkExercise2__Unit_Testing_
{

    [TestClass]
    public class Problem2
    {
        [TestMethod]
        public void Problem2_ShouldReturn2520WhenNumbers1To10CanBeDivisibleWithoutRemainder()
        {
            // Arrange
            var number = new number(10);

            // Act
            var result = number.calculateResult();

            // Assert
            Assert.AreEqual(result, 2520);
        }

        [TestMethod]
        public void Problem2_ShouldReturn232792560WhenNumbers1To20CanBeDivisibleWithoutRemainder()
        {
            // Arrange
            var number = new number(20);

            // Act
            var result = number.calculateResult();

            // Assert
            Assert.AreEqual(result, 232792560);
        }

    }

    class number
    {
        private int startNumber = 1;
        private int _numTo;

        public number(int numTo)
        {
            _numTo = numTo; 
        }

        public int calculateResult()
        {

            var num = startNumber; // Variable var num is equal to 1
            for (int i = num; i <= _numTo; i++)
            // for int i is equal to 1, i is less than or equal to 20, i gets incremented by one
            {
                var sum = num; // variable sum is equal to 1
                while (sum % i != 0) // while (True) sum (1) is divided by i (1) is not equal to 0 
                {
                    sum += num; // Do this if true else move on
                }

                num = sum; 
            }

            return num;

        }

    }
}
