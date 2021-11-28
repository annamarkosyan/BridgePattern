using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Circle : Shape
    {
        private int Radius { get; set; }
        public override void Print()
        {
            _IFigure.Draw("circle");
        }
    }
}
