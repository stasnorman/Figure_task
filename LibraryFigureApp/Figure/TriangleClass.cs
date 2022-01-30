using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryFigureApp.Figure
{
    /// <summary>
    /// Работа через interface
    /// </summary>
    public class TriangleClass : IFigure
    {
        public double[] arrayData { get; set; }
        public double HalfPerimeter { get; set; }
        public bool EventCheck { get; set; } = true; // Определение осуществляется через логическое свойство

        /// <summary>
        /// Работа через interface
        /// </summary>
        /// <param name="data">Массив, для более удобной обработки данных</param>
        public TriangleClass(params double[] data)
        {
            arrayData = data;
        }

        public double ResultArea()
        {
            if (arrayData.Length != 3)
            {
                return 0;
            }
            else
            {
            #region Опредение является ли треугольник прямоугольным
                if (Math.Pow(arrayData[0], 2) + Math.Pow(arrayData[1], 2) == Math.Pow(arrayData[2], 2))
                {
                    EventCheck = false;
                }
            #endregion

                for (int i = 0; i < arrayData.Length; i++)
                {
                    HalfPerimeter += arrayData[i];
                }
                HalfPerimeter = HalfPerimeter / 2;
                return Math.Sqrt(HalfPerimeter * (HalfPerimeter - arrayData[0]) *
                                                            (HalfPerimeter - arrayData[1]) *
                                                            (HalfPerimeter - arrayData[2]));

            }
        }

        public void ViewInfo()
        {
            if (EventCheck != true) Console.WriteLine("Треугольник прямоугольный");
            Console.WriteLine(ResultArea());
        }
    }
}
