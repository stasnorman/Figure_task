using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryFigureApp
{
    /// <summary>
    /// Вывод площадей и информации
    /// </summary>
    public interface IFigure
    {
        double ResultArea();
        void ViewInfo();
    }

    public class FigureClassMain
    {
        /// <summary>
        /// Обработка и вывод данных
        /// </summary>
        /// <param name="figure">Обработка в IFigure</param>
        public void StateFigureArea(IFigure figure) {
            figure.ResultArea();
            figure.ViewInfo();
        }
    }
}
