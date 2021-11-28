using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public abstract class Triangle : Shape
    {
        private int Length1 { get; set; }
        private int Length2 { get; set; }
        private int Length3 { get; set; }
        public override void Print()
        {
            _IFigure.Draw($"triangle {Length1} : {Length2} : {Length3}");
        }
    }
}
