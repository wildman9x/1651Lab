// Rectangle class with double width and length default to 1.0
//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class Rectangle : Shape
    {
        private double width;
        private double length;

        public Rectangle()
        {
            width = 1.0;
            length = 1.0;
        }

        public Rectangle(double width, double length)
        {
            this.width = width;
            this.length = length;
        }

        public Rectangle(double width, double length, String color, bool filled) : base(color, filled)
        {
            this.width = width;
            this.length = length;
        }

        public double Width
        {
            get { return width; }
            set { width = value; }
        }

        public double Length
        {
            get { return length; }
            set { length = value; }
        }

        public double getArea()
        {
            return width * length;
        }

        public double getPerimeter()
        {
            return 2 * (width + length);
        }

        public override string ToString()
        {
            return string.Format("A Rectangle with width={0}, length={1}, which is a subclass of {2}", width, length, base.ToString());
        }
    }
