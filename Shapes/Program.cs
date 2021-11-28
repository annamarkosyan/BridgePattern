using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape shape = new Rectangle(10,20);
            shape.Print();

            shape = new Line(50);
            shape.Print();
        }
    }
}
