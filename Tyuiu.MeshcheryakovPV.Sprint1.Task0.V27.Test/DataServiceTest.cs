using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MeshcheryakovPV.Sprint1.Task0.V27.Lib;

namespace Tyuiu.MeshcheryakovPV.Sprint1.Task0.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCompareOperations1()
        {
            DataService ds = new DataService();
            int x = 1305; 
            int y = 275;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);
            bool[] wait = new bool[6] { true, false, true, false, false, true };

            //CollectionAssert.AreEqual(wait, res);

        }
    }
}
