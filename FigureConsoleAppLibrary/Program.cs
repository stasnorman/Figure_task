using LibraryFigureApp;
using LibraryFigureApp.Figure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureConsoleAppLibrary
{
    internal class Program
    {
        /// <summary>
        /// Тестовый пример реализации
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            FigureClassMain figureClassMain = new FigureClassMain();
            figureClassMain.StateFigureArea(new CircleClass(5));
            figureClassMain.StateFigureArea(new TriangleClass(9,12,15));
            Console.ReadKey();
        }
    }
}
