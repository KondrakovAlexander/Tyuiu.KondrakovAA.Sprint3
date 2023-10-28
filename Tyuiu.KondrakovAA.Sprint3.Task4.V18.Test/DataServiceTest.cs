using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KondrakovAA.Sprint3.Task4.V18.Lib;

namespace Tyuiu.KondrakovAA.Sprint3.Task4.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService resp = new DataService();
            Assert.AreEqual(2.9928724055779, resp.Calculate(-5, 5));
        }
    }
}
