using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.LomakinVI.Sprint6.TaskReview.V19.Lib;

namespace Tyuiu.LomakinVI.Sprint6.TaskReview.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMatrix()
        {
            DataService ds = new DataService();

            int[,] testArray = {{ 1, 3, 5, -7, 8},
                                { 5, 2, 6, -3, 1},
                                { 23, 12, 43, -32, 76},
                                { 3, 5, 1, -3, 34},
                                { 34, 67, 34, -67, 1} };

            int wait = 38;
            Assert.AreEqual(wait, ds.MatrixCalc(testArray, 3, 0, 5));

        }
    }
}
