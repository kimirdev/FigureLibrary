using System;
using Xunit;

namespace FigureLibrary.Tests
{
    public class TriangleTest
    {
        [Fact]
        public void ValidSidesAreaTest()
        {
            IFigure figure = new Triangle(3, 4, 5);

            var result = figure.Area();

            Assert.Equal(6, result);
        }

        [Fact]
        public void ValidSidesPerimeterTest()
        {
            IFigure figure = new Triangle(3, 4, 5);

            var result = figure.Perimeter();

            Assert.Equal(12, result);
        }

        [Fact]
        public void InvalidSides_OneBiggerSide_Test()
        {
            Assert.Throws<Exception>(() => new Triangle(1, 1, 5));
        }

        [Fact]
        public void InvalidSides_NegaiveSide_Test()
        {
            Assert.Throws<Exception>(() => new Triangle(3, -4, 5));
        }

        [Fact]
        public void RightTriangleTest()
        {
            Triangle triangle = new Triangle(3, 4, 5);

            var result = triangle.IsRight();

            Assert.True(result);
        }

        [Fact]
        public void NotRightTriangleTest()
        {
            Triangle triangle = new Triangle(3, 4, 6);

            var result = triangle.IsRight();

            Assert.False(result);
        }
    }
}
