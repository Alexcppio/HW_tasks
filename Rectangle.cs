using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_figure_square
{
    public class Rectangle
    {
        public double SideX { get; }
        public double SideY { get; }
        public Rectangle(ISpecProvider<double> obj, ISpecProvider<double> obj2)
        {
            SideX = obj.ProvideSpecs();
            SideY = obj2.ProvideSpecs();
        }
    }
}
