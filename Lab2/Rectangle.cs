// Rectangle class with double width and length default to 1.0
//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Rectangle : Shape
    {
        public virtual double Width { get; set; }
        public virtual double Length { get; set; }

        public Rectangle()
        {
            Width = 1.0;
            Length = 1.0;
        }

        public Rectangle(double width, double length)
        {
            this.Width = width;
            this.Length = length;
        }

        public Rectangle(double width, double length, String color, bool filled) : base(color, filled)
        {
            this.Width = width;
            this.Length = length;
        }

        

        public double getArea()
        {
            return Width * Length;
        }

        public double getPerimeter()
        {
            return 2 * (Width + Length);
        }

        public override string ToString()
        {
            return string.Format("A Rectangle with width={0}, length={1}, which is a subclass of {2}", Width, Length, base.ToString());
        }
    }
}