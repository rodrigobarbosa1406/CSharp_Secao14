using System;
using System.Collections.Generic;
using Secao14.Entities;

namespace Secao14.Entities
{
    class Contract
    {
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public double Value { get; set; }
        public List<Installment> Installments { get; set; }

        public Contract(int number, DateTime date, double value)
        {
            Number = number;
            Date = date;
            Value = value;
            Installments = null;
        }
    }
}
