using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesNew
{
    public class ColorFigure : IFigure
    {
        private string Color { get; set; }
        public ColorFigure(string color)
        {
            Color = color;
        }
        public void Draw(string shape)
        {
            Console.WriteLine(Color + " " + shape);
        }
    }
}
