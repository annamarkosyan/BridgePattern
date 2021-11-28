using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesNew
{
    public class Rectangle : Shape
    {
        protected double height;
        private double length;
        public Rectangle(double height)
        {
            this.height = height;
        }
        public Rectangle(double length, double height)
        {
            this.length = length;
            this.height = height;
        }
        public override void Draw()
        {
            _IFigure.Draw($"Rectangle {height} x {length}");
        }
    }
}
