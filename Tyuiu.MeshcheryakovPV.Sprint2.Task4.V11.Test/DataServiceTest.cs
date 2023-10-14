using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MeshcheryakovPV.Sprint2.Task4.V11.Lib;

namespace Tyuiu.MeshcheryakovPV.Sprint2.Task4.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void VolidCondition1()
        {
            DataService ds = new DataService();
            double x = -10;
            double y = 10;
            double res = ds.Calculate(x, y);
            double wait = 76825.813;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void VolidCondition2()
        {
            DataService ds = new DataService();
            double x = 51;
            double y = 40;
            double res = ds.Calculate(x, y);
            double wait = -53719.685;
            Assert.AreEqual(wait, res);
        }
    }
}
