using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KondrakovAA.Sprint3.Task3.V13.Lib;

namespace Tyuiu.KondrakovAA.Sprint3.Task3.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService a = new DataService();
            Assert.AreEqual(5, a.ConvertStringToInt("asdfafadfafadsfad1"));
        }
    }
}
