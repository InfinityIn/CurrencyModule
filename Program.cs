using System;

namespace NemoTravelTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var Dollar = new Currency(60, "Dollar");
            var Euro = new Currency(50, "Euro");
            var Yuan = new Currency(10, "Yuan");
            var CHF = new Currency(70, "CHF");

            var summ = new Amount(100, Dollar);
            WriteLineResult(summ);

            //MainService.ConvertAmount(summ, Euro);
            //WriteLineResult(summ);

            var summ2 = new Amount(200, Yuan);
            var summRes = MainService.GetSumOfAmounts(summ, summ2, Euro);

            WriteLineResult(summRes);
        }

        public static void WriteLineResult(Amount summ)
        {
            Console.WriteLine(Getter.GetStandartValue(summ) + " " + Getter.GetValue(summ) + " " + Getter.GetCurrencyName(summ));
        }
    }
}
