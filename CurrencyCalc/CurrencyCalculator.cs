using System;
using System.Collections.Generic;
using System.Text;

namespace CurrencyCalc
{
    public class CurrencyCalculator
    {
        public IRateProvider _rateprovider;
        public CurrencyCalculator(IRateProvider rateProvider)
        {
            _rateprovider = rateProvider;
        }
        public double ChangePln2Euro(double pln)
        {
            return pln * _rateprovider.Pln2EuroRate();
        }
        public double ChangeEuro2Pln(double euro)
        {
            return euro * _rateprovider.Euro2PlnRate();
        }
    }
}
