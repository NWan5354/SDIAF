using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ShapeAreaTests
{
    [TestClass]
    public class RectangleTests
    {
        [TestMethod] // Testing the area of a rectangle
        public void Should_ReturnAreaOf20WhenLengthIs10AndWidthIs2()
        {
            // Arrange
            var rectangle = new Rectangle(10, 2);
            // Act
            var result = rectangle.getArea();
            // Assert
            Assert.AreEqual(result, 20);
        }

        [TestMethod]
        public void Should_ReturnAreaof25WhenLengthIs5AndWidthIs5()
        {
            // Arrange
            var rectangle = new Rectangle(5, 5);

            // Act
            var result = rectangle.getArea();
            
            // Assert
            Assert.AreEqual(result, 25);
        }

        [TestMethod] // Testing the perimeter of a rectangle
        public void Should_ReturnPerimeterof40WhenLengthIs10AndWidthIs10()
        {
            // Arrange
            var rectangle = new Rectangle(10, 10);

            // Act
            var result = rectangle.getPerimeter();

            // Assert
            Assert.AreEqual(result, 40);
        }
    }

    class Rectangle
    {
        // Can only be accessed directly through the class / constructor
        private int _length;
        private int _width;

        public Rectangle(int length, int width)
        {
            _length = length;
            _width = width;
        }

        // It does not return a value void

        public int getArea()
        {
            return _length * _width;
        }

        public int getPerimeter()
        {
            return _length + _length + _width + _width;
        }
    }
}
