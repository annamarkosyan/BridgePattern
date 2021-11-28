using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Arrow : Shape
    {
        private string Direction { get; set; }
        public override void Print()
        {
            _IFigure.Draw($"arrow with direction {Direction}");
        }
    }
}
