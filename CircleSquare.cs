using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_figure_square
{
    public class CircleSquare : ISquareCaculator
    {
        private readonly double radius;
        public CircleSquare(Circle obj) => radius = obj.Radius;
        public double CalculateSquare() => radius * 2 * Math.PI;
    }
}
