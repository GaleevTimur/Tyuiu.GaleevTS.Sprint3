using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GaleevTS.Sprint3.Task1.V14.Lib;

namespace Tyuiu.GaleevTS.Sprint3.Task1.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double value = 0.7;
            int startValue = 1;
            int stopValue = 14;
            double res = ds.GetSumSeries(value, startValue, stopValue);
            double wait = 1.773;
            Assert.AreEqual(wait, res);
        }
    }
}
