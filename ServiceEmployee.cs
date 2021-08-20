using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP_ex1_
{
    class ServiceEmployee
    {
        private readonly IServicePayment _servicePayment;

        public int hoursService;
        public double hourlyRate;
        public ServiceEmployee(IServicePayment servicePayment)
        {
            _servicePayment = servicePayment;
        }

        public double getPayment()
        {
            return hoursService * hourlyRate;
        }

    }
}
