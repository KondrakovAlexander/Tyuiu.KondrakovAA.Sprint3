using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KondrakovAA.Sprint3.Task5.V11.Lib;

namespace Tyuiu.KondrakovAA.Sprint3.Task5.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService resp = new DataService();
            Assert.AreEqual(64.233565113654, resp.GetSumSumSeries(1,1,3,10,5));
        }
    }
}
