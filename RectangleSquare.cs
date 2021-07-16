using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_figure_square
{
    public class RectangleSquare : ISquareCaculator
    {
        private readonly double sideX;
        private readonly double sideY;
        public RectangleSquare(Rectangle obj)
        {
            sideX = obj.SideX;
            sideY = obj.SideY;
        }
        public double CalculateSquare() => (sideX * 2) + (sideY * 2);
    }
}
