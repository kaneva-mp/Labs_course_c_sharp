using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace lab_8
{
    /// <summary>
	/// Класс записи
	/// </summary>
    public class PaymentRecord
    {
        public static string[] paymentsType = { "квартплата", "газ", "вода", "электричество" };
        public string houseNumber { get; set; }

        public string apartNumber { get; set; }

        public string lastname { get; set; }

        public string paymentType { get; set; }

        public string paymentDate { get; set; }

        public string paymentSum { get; set; }

        public string pennyPercent { get; set; }

        public string paymentDaysLeft { get; set; }

        /// <summary>
		/// Конструктор
		/// </summary>
		/// <param name="houseNumber">Номер дома</param>
		/// <param name="apartNumber">Номер квартиры</param>
		/// <param name="lastname">Фамилия владельца</param>
		/// <param name="paymentType">Вид платежа</param>
		/// <param name="paymentDate">Дата платежа</param>
		/// <param name="paymentSum">Сумма платежа</param>
		/// <param name="pennyPercent">Процент пенни</param>
		/// <param name="paymentDaysLeft">Дней просрочено</param>
        public PaymentRecord(string houseNumber,
            string apartNumber,
            string lastname,
            string paymentType,
            string paymentDate,
            string paymentSum,
            string pennyPercent,
            string paymentDaysLeft)
        {
            this.houseNumber = houseNumber;
            this.apartNumber = apartNumber;
            this.lastname = lastname;
            this.paymentType = paymentType;
            this.paymentDate = paymentDate;
            this.paymentSum = paymentSum;
            this.pennyPercent = pennyPercent;
            this.paymentDaysLeft = paymentDaysLeft;
        }

        /// <summary>
		/// Проверка на корректность данных
		/// </summary>
		/// <returns>Корректные данные или нет</returns>
        public bool isCorrect()
        {
            return isNotNull() && isValid();
        }

        /// <summary>
		/// Проверка на то, что все поля непустые
		/// </summary>
		/// <returns>Есть пустые строки или нет</returns>
        private bool isNotNull()
        {
            return !(String.IsNullOrEmpty(houseNumber) || String.IsNullOrEmpty(apartNumber) ||
                String.IsNullOrEmpty(lastname) || String.IsNullOrEmpty(paymentType) ||
                String.IsNullOrEmpty(paymentDate) || String.IsNullOrEmpty(paymentSum) ||
                String.IsNullOrEmpty(pennyPercent) || String.IsNullOrEmpty(paymentDaysLeft));
        }

        /// <summary>
		/// Проверка формата данных
		/// </summary>
		/// <returns>Корректный формат или нет</returns>
        private bool isValid()
        {
            DateTime temp = new DateTime();
            return houseNumber.All(Char.IsDigit) && apartNumber.All(Char.IsDigit)
                    && lastname.All(Char.IsLetter)
                    && paymentsType.Contains(paymentType.ToLower())
                    && Regex.IsMatch(paymentSum, "\\d+(\\.\\d{1,2})?")
                    && Regex.IsMatch(pennyPercent, "^0(.\\d{1,2})?")
                    && paymentDaysLeft.All(Char.IsDigit)
                    && DateTime.TryParseExact(paymentDate, "dd.MM.yyyy",
                    System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None,
                    out temp);

        }

        /// <summary>
		/// Функция сравнение двух записей
		/// </summary>
		/// <param name="data">Запись, с которой нужно сравнивать</param>
		/// <returns>Эквивалентны записи или нет</returns>
        public bool isEqual(PaymentRecord data)
        {
            return houseNumber == data.houseNumber &&
             apartNumber == data.apartNumber &&
             lastname == data.lastname &&
             paymentType == data.paymentType &&
             paymentSum == data.paymentSum &&
             pennyPercent == data.pennyPercent &&
             paymentDaysLeft == data.paymentDaysLeft &&
             paymentDate == data.paymentDate;
        }
    }
}
