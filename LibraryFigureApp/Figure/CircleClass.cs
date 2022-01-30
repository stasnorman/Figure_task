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
    public class CircleClass : IFigure
    {
        public double radius { get; set; }

        /// <summary>
        /// Работа через interface
        /// </summary>
        /// <param name="RadiusCircle">Радиус</param>
        public CircleClass(double RadiusCircle)
        {
            radius = RadiusCircle;
        }
        public double ResultArea()
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        public void ViewInfo() {
            Console.WriteLine(ResultArea());
        }
    }
}
