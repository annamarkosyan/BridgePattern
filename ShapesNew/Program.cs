using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesNew
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape shape = new Rectangle(10,20)
            {
                _IFigure = new ColorFigure("Red")
            };
            shape.Draw();


            shape = new Circle(25)
            {
                _IFigure = new BorderedFigure("Dotted")
            };
            shape.Draw();

            shape = new Table(2,10)
            {
                _IFigure = new ColorFigure("Purple")
            };
            shape.Draw();
            shape._IFigure = new BorderedFigure("DoubleLined");
            shape.Draw();
        }
    }

}
