using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesNew
{
    public class Square : Rectangle
    {
        public Square(double height) : base(height)
        {
        }
        public override void Draw()
        {
            _IFigure.Draw($"Square {height}");
        }
    }
}
