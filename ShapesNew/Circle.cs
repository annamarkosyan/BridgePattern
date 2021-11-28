using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesNew
{
    public class Circle : Shape
    {
        private double radius;
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public override void Draw()
        {
            _IFigure.Draw($"Circle with radius: {radius}");
        }
    }
}
