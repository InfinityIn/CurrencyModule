using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NemoTravelTest
{
    public class MainService
    {
        /// <summary>
        /// Конвертация денежной суммы в новую валюту
        /// </summary>
        /// <param name="amount">Денежная сумма</param>
        /// <param name="newCurrency">Новая валюта</param>
        public static void ConvertAmount(Amount amount, Currency newCurrency)
        {
            if (amount is null)
                throw new Exception("Укажите корректную сумму");

            if (newCurrency is null)
                throw new Exception("Укажите корректную новую валюту");

            Changer.ChangeCurrency(amount,newCurrency);
        }

        /// <summary>
        /// Суммирует значения указанных денежных сумм в базовой валюте и конвертирует в нужную валюту
        /// </summary>
        /// <param name="amount1">Первая денежная сумма</param>
        /// <param name="amount2">Вторая денежная сумма</param>
        /// <param name="resultCurrency">Необходимая валюта результата</param>
        /// <returns>Возвращает денежную сумму в указаной валюте</returns>
        public static Amount GetSumOfAmounts(Amount amount1, Amount amount2, Currency resultCurrency)
        {
            if ((amount1 is null)|| (amount2 is null))
                throw new Exception("Укажите корректные суммы");            

            if (resultCurrency is null)
                throw new Exception("Укажите корректную результирующую валюту");

            var resultAmount = new Amount(Getter.GetStandartValue(amount1) + Getter.GetStandartValue(amount2), new Currency(1, "Basic"));
            ConvertAmount(resultAmount, resultCurrency);
            return resultAmount;
        }
    }
}
