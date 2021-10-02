using System;
using Secao14.Services;

namespace Secao14.Services
{
    class PaypalPaymentService : IPaymentService
    {
        public double Interest()
        {
            return 0.01;
        }

        public double Tax()
        {
            return 0.02;
        }
    }
}
