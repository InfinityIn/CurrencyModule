using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NemoTravelTest
{
    /// <summary>
    /// Реализация класса "Валюта"
    /// _courseValue - текущий курс валюты
    /// Name - наименование валюты
    /// Чтобы создать экземпляр валюты, нужно указать курс относительно базовой валюты и наименование валюты
    /// </summary>
    public class Currency
    {        
        public double CourseValue { get; set; }
        public string Name { get; set; }

        public Currency(double courseValue, string name)
        {
            CourseValue = courseValue;
            Name = name;
        }

        
    }

    /// <summary>
    /// Реализация класса "Денежная сумма"
    /// Value - значение суммы
    /// _currency - Текущая валюта
    /// Чтобы создать экземпляр класса, нужно указать значение денежной суммы и заранее созданную валюту
    /// </summary>
    public class Amount
    {
        public double Value { get; set; }
        public Currency Currency { get; set; }

        public Amount(double value, Currency currency)
        {
            Value = value;
            Currency = currency;
        }
        

        
    }

    public class Changer
    {
        public static void ChangeCourseValue(Currency currency, double newCourse)
        {
            currency.CourseValue = newCourse;
        }

        public static void ChangeCurrency(Amount amount, Currency newCurrency)
        {
            amount.Value = Getter.GetStandartValue(amount) / Getter.GetCourseValue(newCurrency);
            amount.Currency = newCurrency;
        }
    }

    public class Getter
    {
        public static double GetCourseValue(Currency currency)
        {
            return currency.CourseValue;
        }
        public static double GetStandartValue(Amount amount)
        {
            return amount.Value * Getter.GetCourseValue(amount.Currency);
        }

        public static double GetValue(Amount amount)
        {
            return amount.Value;
        }

        public static string GetCurrencyName(Amount amount)
        {
            return amount.Currency.Name;
        }
    }
}
