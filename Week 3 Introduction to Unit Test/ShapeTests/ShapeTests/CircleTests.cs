using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ShapeTests
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod] // Calculating the area of a circle
        public void Should_ReturnAreaOfOneHundredAndThirteenPointFour()
        {
            // Arrange
            var circle = new Circle(6, 0);
            // Act
            var result = circle.getArea();
            // Assert
            Assert.AreEqual(result, 113);
        }

        [TestMethod] // C = 3.14 X Diameter
        public void Should_ReturnCircumferenceOfThreeHundredAndForteen()
        {
            // Arrange
            var circle = new Circle(0, 100);
            // Act
            var result = circle.getCircumference();
            // Assert
            Assert.AreEqual(result, 314);
        }
    }

    class Circle
    {
        private int _radius;
        //double pi = Math.PI;
        double pi = 3.14;
        private int _diameter;

        

        public Circle(int radius1, int diameter)
        {
            _radius = radius1;
            _diameter = diameter;
            
        }

        public int getArea()
        {
            var result =  _radius * _radius * pi;
            return (int)result;
        }

         public double getCircumference()
        {
            return _diameter * pi;
        }
    }
}
