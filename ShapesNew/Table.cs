using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesNew
{
    public class Table : Shape
    {
        private int col;
        private int row;
        public Table(int col, int row)
        {
            this.col = col;
            this.row = row;
        }
        public override void Draw()
        {
            _IFigure.Draw($"Table {col} x {row}");
        }
    }
}
