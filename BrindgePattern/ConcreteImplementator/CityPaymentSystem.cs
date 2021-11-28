using BrindgePattern.Implementator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrindgePattern.ConcreteImplementator
{
    public class CityPaymentSystem : IPaymentSystem
    {
        public void ProcessPayment(string paymentSystem)
        {
            Console.WriteLine("Using CityBank gateway for " + paymentSystem);
        }
    }
}
