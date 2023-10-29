using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MartysevichAD.Sprint3.Task7.V13.Lib;

namespace Tyuiu.MartysevichAD.Sprint3.Task7.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;

            int len = stopValue - startValue + 1;
            double[] ValueWaitArray;
            ValueWaitArray = new double[len];
            ValueWaitArray[0] = -9.10;
            ValueWaitArray[1] = 1.55;
            ValueWaitArray[2] = 292.78;
            ValueWaitArray[3] = -0.57;
            ValueWaitArray[4] = -0.35;
            ValueWaitArray[5] = 2;
            ValueWaitArray[6] = 4.35;
            ValueWaitArray[7] = 4.57;
            ValueWaitArray[8] = -288.78;
            ValueWaitArray[9] = 2.45;
            ValueWaitArray[10] = 13.10;

            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(ValueWaitArray, res);
        }
    }
}
