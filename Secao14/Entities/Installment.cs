using System;
using System.Globalization;

namespace Secao14.Entities
{
    class Installment
    {
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }

        public Installment(int number, DateTime date, double amount)
        {
            Number = number;
            Date = date;
            Amount = amount;
        }

        public override string ToString()
        {
            return Number
                + " - "
                + Date.ToString("dd/MM/yyyy")
                + " - "
                + Amount.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
