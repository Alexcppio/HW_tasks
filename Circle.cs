using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_figure_square
{
    public class Circle
    {
        public double Radius { get; }
        public Circle(ISpecProvider<double> obj) => Radius = obj.ProvideSpecs();
    }
}
