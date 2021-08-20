using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP_ex1_
{
    interface IServicePayment
    {
        public double CalcServicePayment(int hoursService, double hourlyRate);
    }
}
