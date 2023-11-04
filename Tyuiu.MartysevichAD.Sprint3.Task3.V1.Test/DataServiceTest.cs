using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MartysevichAD.Sprint3.Task3.V1.Lib;

namespace Tyuiu.MartysevichAD.Sprint3.Task3.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            string value = "have a nice time";
            char item = 'a';

            double res = ds.GetCharCount(value, item);
            int wait = 2;

            Assert.AreEqual(wait, res);
        }
    }
}
