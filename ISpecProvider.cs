using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_figure_square
{
    public interface ISpecProvider<T>
    {
        T ProvideSpecs();
    }
}
