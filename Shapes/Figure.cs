using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Figure : IFigure
    {
        public void Draw(string figure)
        {
            Console.WriteLine($"Figure is {figure}");
        }

    }
}
