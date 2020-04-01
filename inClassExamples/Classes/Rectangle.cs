using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Rectangle
    {
        public double Width { get; set;  }
        
        public double Length { get; set; }

        private DateTime LastModified;

      

        //Default/empty constructor for the Rectangle class thats sets the width and length to zero
        public Rectangle()
        {
            Width = 0;
            Length = 0;
            LastModified = DateTime.Now;

        }

        //This is the overloaded constructor that takes the width followed by the length as parameters
        public Rectangle (double width, double length)
        {
            Width = width;
            Length = length;
            LastModified = DateTime.Now;
        }

        //This calculates the area of the rectangle, returns double 
        public double Area()
        {
            double a = Width * Length;
            return a;

        }

    }
}
