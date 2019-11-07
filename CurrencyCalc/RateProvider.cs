using System;
using System.Collections.Generic;
using System.Text;

namespace CurrencyCalc
{
    public class RateProvider : IRateProvider
    {
        public double Pln2EuroRate()
        {
            return 0.25;
        }
        public double Euro2PlnRate()
        {
            return 4.25;
        }
    }
}
