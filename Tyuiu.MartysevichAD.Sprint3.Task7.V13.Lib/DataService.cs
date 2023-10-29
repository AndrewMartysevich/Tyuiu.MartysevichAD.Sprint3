using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MartysevichAD.Sprint3.Task7.V13.Lib
{
    public class DataService : ISprint3Task7V17
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            double y;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                double z = x / (Math.Cos(x) + 1);
                y = Math.Round(3 * x + 2 - z, 2);
                valueArray[count] = y;
                count++;
                if (Math.Cos(x) +1 == 0)
                {
                    throw new ArgumentException($"На ноль делить нельзя");       
                }
                z = 0;
            }
            return valueArray;
        }
    }
}
