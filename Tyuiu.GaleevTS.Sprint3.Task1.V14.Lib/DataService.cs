using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.GaleevTS.Sprint3.Task1.V14.Lib
{
    public class DataService : ISprint3Task1V14
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double sumSeries = 0;
            while (startValue <= stopValue)
            {
                sumSeries = sumSeries + ((Math.Pow(value, startValue) + (1 / (startValue + 1))) * Math.Cos(value));
                startValue++;
            }
            return Math.Round(sumSeries, 3);
        }

    }
}
