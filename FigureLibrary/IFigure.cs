using System;
using System.Collections.Generic;
using System.Text;

namespace FigureLibrary
{
    public interface IFigure
    {

        /// <summary>
        /// Периметр фигуры
        /// </summary>
        double Perimeter();


        /// <summary>
        /// Площадь фигуры
        /// </summary>
        double Area();
    }
}
