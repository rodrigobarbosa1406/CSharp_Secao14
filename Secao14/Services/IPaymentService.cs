using System;
using System.Collections.Generic;
using System.Text;

namespace Secao14.Services
{
    interface IPaymentService
    {
        public double Interest();
        public double Tax();
    }
}
