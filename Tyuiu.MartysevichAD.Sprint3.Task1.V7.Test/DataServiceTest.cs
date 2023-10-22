﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MartysevichAD.Sprint3.Task1.V7.Lib;

namespace Tyuiu.MartysevichAD.Sprint3.Task1.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double value = 1;
            int startValue = 1;
            int stopValue = 9;

            double res = ds.GetMultiplySeries(value, startValue, stopValue);
            double wait = -351.018;

            Assert.AreEqual(wait, res);

        }
    }
}
