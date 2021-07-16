using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_figure_square
{
    public class ConsoleProvider: ISpecProvider<double>
    {
        private readonly string value;
        public ConsoleProvider()
        {
            value = Console.ReadLine();
            if(value == null)
                throw new ArgumentNullException(nameof(value));
        }
        public double ProvideSpecs()
        {
            if (Double.TryParse(value, out double num))
                return num;
            throw new InvalidCastException(nameof(value));
        }
    }
}
