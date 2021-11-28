using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public abstract class Shape
    {
        public IFigure _IFigure;
        public Shape()
        {
            _IFigure = new Figure();
        }
        public abstract void Print();
    }
}
