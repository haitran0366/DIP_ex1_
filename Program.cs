using System;

namespace DIP_ex1_
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceEmployee = new ServiceEmployee(new ServicePayment());
            serviceEmployee.hourlyRate = 50;
            serviceEmployee.hoursService = 40;
            Console.WriteLine($"The Total Pay is {serviceEmployee.getPayment()}");

        }
    }
}
