using System;
using System.Globalization;
using Secao14.Entities;
using Secao14.Services;

namespace Secao14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data");
            
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());

            Console.Write("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

            Console.Write("Contract Value: ");
            double value = double.Parse(Console.ReadLine());

            Contract contract = new Contract(number, date, value);

            Console.WriteLine();

            Console.Write("Enter number of installments: ");
            int installments = int.Parse(Console.ReadLine());

            double valueQuota = value / installments;

            ContractService contractService = new ContractService(valueQuota, installments, new PaypalPaymentService());
            contractService.processContract(contract);

            Console.WriteLine();
            Console.WriteLine("Installments:");

            foreach (Installment installment in contract.Installments)
            {
                Console.WriteLine(installment);
            }
        }
    }
}
