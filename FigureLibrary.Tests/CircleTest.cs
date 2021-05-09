using System;
using Xunit;

namespace FigureLibrary.Tests
{
    public class CircleTest
    {
        [Fact]
        public void ValidRadiusAreaTest()
        {
            IFigure figure = new Circle(3);

            var result = figure.Area();

            Assert.Equal(Math.PI * 9, result);
        }

        [Fact]
        public void ValidRadiusPerimeterTest()
        {
            IFigure figure = new Circle(3);

            var result = figure.Perimeter();

            Assert.Equal(Math.PI * 6, result);
        }

        [Fact]
        public void NegativeRadiusTest()
        {
            Assert.Throws<Exception>(() => new Circle(-3));
        }
    }
}
