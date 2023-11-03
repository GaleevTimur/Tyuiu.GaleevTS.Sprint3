using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.GaleevTS.Sprint3.Task0.V2.Lib
{
    public class DataService : ISprint3Task0V2
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double multSeries = 1;
            int k;
            for (k = startValue; k <= stopValue; k++) ;
            {
                multSeries = multSeries * (Math.Pow(k / (Math.Pow(Math.Sin(1), -7)), -2));
                return Math.Round(multSeries, 3) ;
            }
        }
    }
}
