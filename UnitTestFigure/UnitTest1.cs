using LibraryFigureApp;
using LibraryFigureApp.Figure;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestFigure
{
    [TestClass]
    public class UnitTest1
    {
        #region Positive

        /// <summary>
        /// Данные по расчету корректные
        /// </summary>
        [TestMethod]
        public void TestCircleMethod()
        {
            double radius = 5d;
            CircleClass circleClass = new CircleClass(radius);
            Assert.AreEqual(Math.Round(circleClass.ResultArea(), 2), 78.54, "Данные по расчету некорректны");
        }

        /// <summary>
        /// Данные что производится расчет площади исходя из 3 сторон
        /// </summary>
        [TestMethod]
        public void TestTriangleMethod()
        {
            double[] arrayData = { 9, 12, 15 };
            TriangleClass triangleClass = new TriangleClass(arrayData);
            Assert.AreEqual(triangleClass.ResultArea(), 54);
        }

        /// <summary>
        /// Проверка что вводимые данные не относятся к прямоугольному треугольнику
        /// false - не относятся, статус Pass
        /// true - относятся, статус Fail
        /// </summary>

        [TestMethod]
        public void TestTriangleIsNotStraight()
        {
            double[] arrayData = { 9, 12, 12 };
            TriangleClass triangleClassIsStraight = new TriangleClass(arrayData);
            Assert.AreEqual(triangleClassIsStraight.EventCheck, false, "Проверка пройдена");
        }

        /// <summary>
        /// Проверка что вводимые данные относятся к прямоугольному треугольнику
        /// false - не относятся, статус Pass
        /// true - относятся, статус Fail
        /// </summary>

        [TestMethod]
        public void TestTriangleIsStraight()
        {
            double[] arrayData = { 9, 12, 15 };
            TriangleClass triangleClassIsStraight = new TriangleClass(arrayData);
            Assert.AreEqual(triangleClassIsStraight.EventCheck, false, "Проверка пройдена");
        }

        #endregion

        #region Negative
        /// <summary>
        /// Данные по расчету некорректные
        /// </summary>
        [TestMethod]
        public void FailTestCircleMethod()
        {
            double radius = Convert.ToDouble('!');
            CircleClass circleClass = new CircleClass(radius);
            Assert.AreEqual(Math.Round(circleClass.ResultArea(), 2), 78.54, "Данные по расчету некорректны");
        }

        /// <summary>
        /// Определение что именно 3 стороны у треуольника, а не 4
        /// </summary>
        [TestMethod]
        public void FailTestTriangleMethod()
        {
            double[] arrayData = { 9, 12, 15, 5 };
            TriangleClass triangleClass = new TriangleClass(arrayData);
            Assert.AreEqual(triangleClass.ResultArea(), 54);
        }

        /// <summary>
        /// Проверка что вводимые данные не относятся к прямоугольному треугольнику
        /// false - не относятся, статус Pass
        /// true - относятся, статус Fail
        /// </summary>

        [TestMethod]
        public void FailTestTriangleIsNotStraight()
        {
            double[] arrayData = { 9, 12, 12 };
            TriangleClass triangleClassIsStraight = new TriangleClass(arrayData);

            Assert.AreEqual(triangleClassIsStraight.EventCheck, true, "Проверка пройдена");
        }

        /// <summary>
        /// Проверка что вводимые данные НЕ относятся к прямоугольному треугольнику
        /// false - не относятся, статус Pass
        /// true - относятся, статус Fail
        /// </summary>

        [TestMethod]
        public void FailTestTriangleIsStraight()
        {
            double[] arrayData = { 9, 12, 12 };
            TriangleClass triangleClassIsStraight = new TriangleClass(arrayData);

            Assert.AreEqual(triangleClassIsStraight.EventCheck, true, "Проверка пройдена");
        }
        #endregion
    }
}
