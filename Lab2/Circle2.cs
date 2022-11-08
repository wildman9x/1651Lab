// Circle with double radius and three constructors
//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class Circle2 : Shape
    {
        private double radius;

        public Circle2()
        {
            radius = 1.0;
        }

        public Circle2(double radius)
        {
            this.radius = radius;
        }

        public Circle2(double radius, String color, bool filled) : base(color, filled)
        {
            this.radius = radius;
        }

        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        public double getArea()
        {
            return radius * radius * Math.PI;
        }

        public double getPerimeter()
        {
            return 2 * radius * Math.PI;
        }

        public override string ToString()
        {
            return string.Format("A Circle with radius={0}, which is a subclass of {1}", radius, base.ToString());
        }
    }
