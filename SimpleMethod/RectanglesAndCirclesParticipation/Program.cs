using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectanglesAndCirclesParticipation
{
    class Program
    {
        static void Main(string[] args)
        {

            Rectangles Rect1 = new Rectangles();
            Rect1.Width = 5;
            Rect1.Length = 6;
           

            Rectangles Rect2 = new Rectangles();
            Rect2.Width = 22;
            Rect2.Length = 12;

            Console.WriteLine($"The area for the first rectangle is { Rect1.CalculateArea()}");
            Console.WriteLine($"The perimeter for the first rectangle is { Rect1.CalculatePerimeter()}");
            Console.WriteLine($"The area for the second rectangle is { Rect2.CalculateArea()}");
            Console.WriteLine($"The perimeter for the second rectangle is { Rect2.CalculatePerimeter()}");

            Circle Circ1 = new Circle();
            Circ1.Radius = 4;

            Circle Circ2 = new Circle();
            Circ2.Radius = 33;

            Console.WriteLine($"The area for the first circle is { Circ1.CalculateArea()}");
            Console.WriteLine($"The perimeter for the first circle is { Circ1.CalculatePerimeter()}");
            Console.WriteLine($"The area for the second circle is { Circ2.CalculateArea()}");
            Console.WriteLine($"The perimeter for the second circle is { Circ2.CalculatePerimeter()}");




            Console.ReadKey();
        }
    }
}
