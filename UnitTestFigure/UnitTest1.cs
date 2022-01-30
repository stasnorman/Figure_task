using LibraryFigureApp;
using LibraryFigureApp.Figure;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestFigure
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestTriangleMethod()
        {
            double[] arrayActual = {4, 5, 6, 5};
            double[] arrayArrange = {4, 5, 6};

            FigureClassMain figureClassMain = new FigureClassMain();
            
            //Arrange
            figureClassMain.StateFigureArea(new TriangleClass(arrayArrange));


            //Assert
            Assert.AreEqual(figureClassMain.StateFigureArea(new TriangleClass(2,3,4)), false, "Данные некорректные");
        }
    }
}
