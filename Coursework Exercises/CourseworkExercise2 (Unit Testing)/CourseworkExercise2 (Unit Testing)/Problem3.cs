using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace CourseworkExercise2__Unit_Testing_
{
    [TestClass]
    public class Problem3
    {
        [TestMethod]
        public void Problem3_ShouldReturnTheDifferenceOf2640GivenThatSumOfSquaresOfFirst100Is385AndTheSquareOfSumIs3025()
        {
            // Arrange
            var Calculations = new Calculations(10);

            // Act
            var result = Calculations.getDifference();

            // Assert
            Assert.AreEqual(result, 2640);
        }

        [TestMethod]
        public void Problem3_ShouldReturnTheDifferencesOf25164150GivenThatSumOfSquaresOfFirst100Is338350AndTheSquareOfSumIs25502500()
        {
            // Arrange
            var Calculations = new Calculations(100);

            // Act
            var result = Calculations.getDifference();

            // Assert
            Assert.AreEqual(result, 25164150);
        }

        //[TestMethod]
        //public void Problem3_TestingExtra()
        //{
        //    // Arrange
        //    var Calculations = new Calculations(200);

        //    // Act
        //    var result = Calculations.getDifference();

        //    // Assert
        //    Assert.AreEqual(result, 401323300);
        //}
    }

    class Calculations
    {
        private int startNumber = 0;
        private int finishNumber;

        public Calculations(int finishNum)
        {
            finishNumber = finishNum;
        }

        public int getDifference()
        {
            List<int> resultSet = new List<int>();

            for (int i = startNumber; i <= finishNumber; i++)
            {
                int answer = i * i;
                resultSet.Add(answer);
            }

            List<int> newResultSet = new List<int>();
            int result = startNumber;

            for (int i = startNumber; i <= finishNumber; i++)
            {
                result = result + i;
            }

            int total = result;
            int squaredResult = result * result;

            int finalAnswer = squaredResult - resultSet.Sum();


            return finalAnswer;
        }
    }
}
