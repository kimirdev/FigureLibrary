using System;
using System.Collections.Generic;
using System.Text;

namespace FigureLibrary
{
    public class Circle : IFigure
    {
        private readonly double _radius;

        public Circle(double radius)
        {
            if (!IsValid(radius))
                throw new Exception("Invalid circle");
            _radius = radius;
        }

        private bool IsValid(double radius)
        {
            if (radius < 0)
                return false;
            return true;
        }


        /// <summary>
        /// Площадь круга
        /// </summary>
        public double Area()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }


        /// <summary>
        /// Периметр окружности
        /// </summary>
        public double Perimeter()
        {
            return 2 * Math.PI * _radius;
        }
    }
}
