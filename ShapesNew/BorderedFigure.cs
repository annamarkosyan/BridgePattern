using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesNew
{
    public class BorderedFigure : IFigure
    {
        private string BorderStyle { get; set; }
        public BorderedFigure(string borderStyle)
        {
            BorderStyle = borderStyle;
        }
        public void Draw(string shape)
        {
            Console.WriteLine(BorderStyle + " " + shape);
        }
    }
}
