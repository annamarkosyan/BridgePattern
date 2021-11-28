using BrindgePattern.Abstraction;
using BrindgePattern.RefinedAbstraction;
using BrindgePattern.ConcreteImplementator;
using BrindgePattern.Implementator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrindgePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Payment order = new CardPayment();
            order._IPaymentSystem = new CityPaymentSystem();
            order.MakePayment();

            order._IPaymentSystem = new IDBIPaymentSystem();
            order.MakePayment();

            order = new NetBankingPayment();
            order._IPaymentSystem = new CityPaymentSystem();
            order.MakePayment();

        }
    }
}
