using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Rectangle> rectangles new List<Rectangle>();
            double w, l;

            w = 5;
            l = 6;

            Rectangle rect1 = new Rectangle();
            rect1.Length = 8;
            rect1.Width = 10;

            Rectangle rect2 = new Rectangle(w, l);

            Rectangle rect3 = new Rectangle(77, 8.2);

            rectangles.Add(rect1);

            foreach (var rectangle in rectangles)
            {
                OutputAreaofRect(rectangle);
            }



            Console.ReadKey();


        }

        static void OutputAreaofRect(Rectangle r)
        {
            Console.WriteLine($"The rectangle with {r.Length} length and {r.Width} width has an area of {r.Area()}");


        }
    }
}
