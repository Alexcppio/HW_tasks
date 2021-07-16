using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_figure_square
{
    class Program
    {
        static void Main(string[] args)
        {
            var obj = new CircleSquare(new Circle(new ConsoleProvider()));
            Console.WriteLine(obj.CalculateSquare());
            var obj2 = new RectangleSquare(new Rectangle(new ConsoleProvider(), new ConsoleProvider()));
            Console.WriteLine(obj2.CalculateSquare());
            var obj3 = new CircleSquare(new Circle(new FileProvider("test.txt", "radius", '=')));
            Console.WriteLine(obj3.CalculateSquare());
            var obj4 = new RectangleSquare(new Rectangle(new FileProvider("test.txt", "sideX", '='), new FileProvider("test.txt", "sideY", '=')));
            Console.WriteLine(obj4.CalculateSquare());
        }
    }
}
