using System;

namespace CurrencyCalc
{
    class Program
    {
        static void Main(string[] args)
        {

            var rateProvider = new RateProvider();
            var calculator = new CurrencyCalculator(rateProvider);

            Console.WriteLine(calculator.ChangeEuro2Pln(5));
            //double money = double.Parse(Console.ReadLine());
            //Console.WriteLine("1 Convert Euro to PLN");
            //Console.WriteLine("2 Convert PLN to Euro");
            //var selection = Console.ReadLine();

            //switch (selection)
            //{
            //    case 1:
            //        break;
            //    default:
            //        break;
            //}

            //double amount = double.Parse(Console.ReadLine());
            //Euro euro = new Euro();
            //var exchange = euro.ToEuro(amount);
            //Console.WriteLine(exchange);
            //Console.Read();
        }
    }
}
