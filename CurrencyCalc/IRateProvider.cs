using System;
using System.Collections.Generic;
using System.Text;

namespace CurrencyCalc
{
    public interface IRateProvider
    {
        double Pln2EuroRate();
        double Euro2PlnRate();
    }
}
