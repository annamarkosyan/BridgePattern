using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NVI
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new Derived();
            myClass.DoWork();
        }

        class MyClass
        {
            public void DoWork()
            {
                Console.WriteLine("DoWork");
                CoreDoWork();
            }
            protected virtual void CoreDoWork()
            {
                Console.WriteLine("CoreDoWork");
            }
        }

        class Derived : MyClass
        {
            protected override void CoreDoWork()
            {
                Console.WriteLine("Derived DoWork");
            }
        }

    }
}
