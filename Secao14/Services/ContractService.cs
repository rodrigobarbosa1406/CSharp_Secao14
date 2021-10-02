using System;
using System.Collections.Generic;
using Secao14.Entities;
using Secao14.Services;

namespace Secao14.Services
{
    class ContractService
    {
        public double ValueQuota { get; set; }
        public int QuantityInstallments { get; set; }
        private IPaymentService _paymentService;

        public ContractService(double valueQuota, int quantityInstallments, IPaymentService paymentService)
        {
            ValueQuota = valueQuota;
            QuantityInstallments = quantityInstallments;
            _paymentService = paymentService;
        }

        public void processContract(Contract contract)
        {
            double interest = _paymentService.Interest();
            double tax = _paymentService.Tax();
            List<Installment> installments = new List<Installment>();

            for (int i = 1; i <= QuantityInstallments; i++)
            {
                DateTime date = contract.Date.AddMonths(i);

                double valueInstallment = ValueQuota;

                valueInstallment += ((valueInstallment * interest) * i);
                valueInstallment += (valueInstallment * tax);

                installments.Add(new Installment(i, date, valueInstallment));
            }

            contract.Installments = installments;
        }
    }
}
