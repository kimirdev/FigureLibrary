using System;

namespace FigureLibrary
{
    public class Triangle : IFigure
    {
        private readonly double a;
        private readonly double b;
        private readonly double c;

        /// <summary>
        /// Треугольник
        /// a, b, c - стороны треугольника
        /// </summary>
        public Triangle(double a, double b, double c)
        {
            if (!IsValid(a, b, c))
                throw new Exception("Invalid triangle");
            this.a = a;
            this.b = b;
            this.c = c;
        }

        private bool IsValid(double a, double b, double c)
        {
            var arr = new double[] { a, b, c };
            Array.Sort(arr);
            if (arr[2] > arr[1] + arr[0])
                return false;
            if (arr[0] < 0)
                return false;
            return true;
        }

        /// <summary>
        /// Площадь треугольника
        /// </summary>
        public double Area()
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        /// <summary>
        /// Периметр треугольника
        /// </summary>
        public double Perimeter()
        {
            return a + b + c;
        }

        // Проверка на то, является ли треугольник прямоугольным
        public bool IsRight()
        {
            var arr = new [] { a, b, c };

            Array.Sort(arr);

            return arr[2] * arr[2] == arr[1] * arr[1] + arr[0] * arr[0];
        }
    }
}
