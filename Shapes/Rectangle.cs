using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Rectangle : Shape
    {
        private int Height { get; set; }
        private int Length { get; set; }

        public Rectangle() { }
        public Rectangle(int height, int length)
        {
            Height = height;
            Length = length;
        }

        public override void Print()
        {
            _IFigure.Draw($"rectangle with length {Length} and height {Height}");
        }

    }
}
