using ShapeLibrary.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLibrary.Tests
{
    public class CircleTests
    {
        [Fact]
        public void Circle_ValidRadius_ReturnsArea()
        {
            var circle = new Circle(5);
            double area = circle.GetArea();
            Assert.Equal(78.53981633974483, area, 5);
        }

        [Fact]
        public void Circle_InvalidRadius_ThrowsException()
        {
            Assert.Throws<ArgumentException>(() => new Circle(-1));
        }
    }

    public class TriangleTests
    {
        [Fact]
        public void Triangle_ValidSides_ReturnsArea()
        {
            var triangle = new Triangle(3, 4, 5);
            double area = triangle.GetArea();
            Assert.Equal(6, area, 5);
        }

        [Fact]
        public void Triangle_InvalidSides_ThrowsException()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(1, 1, 10));
        }

        [Fact]
        public void Triangle_RightTriangle_ReturnsTrue()
        {
            var triangle = new Triangle(3, 4, 5);
            Assert.True(triangle.IsRightTriangle());
        }
    }

    public class AreaCalculatorTests
    {
        [Fact]
        public void CalculateArea_AnyShape_CalculatesCorrectly()
        {
            IShape circle = new Circle(1);
            IShape triangle = new Triangle(3, 4, 5);

            Assert.Equal(Math.PI, AreaCalculator.CalculateArea(circle), 5);
            Assert.Equal(6, AreaCalculator.CalculateArea(triangle), 5);
        }
    }
}
