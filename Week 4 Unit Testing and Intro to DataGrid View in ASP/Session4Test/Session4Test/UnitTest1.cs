using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Session4Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            Calculations calculations = new Calculations();

            // Act
            var result = calculations.getSum();

            // Assert - A result is equal to an answer
            Assert.AreEqual(result, 18);
        }

        [TestMethod]
        public void TestThatFailed()
        {
            // Arrange
            Calculations calculations = new Calculations();

            // Act
            var result = calculations.getSum();

            // Assert - A result is equal to an answer
            Assert.AreEqual(result, 23);
        }
    }

        class Calculations
        {
            private int total = 0;
            public int getSum()
            {
                for (int i = 0; i < 10; i++)
                {
                    if (i % 3 == 0)
                    {
                        total += i;
                    }
                }
                return total;
            }
        }

}

