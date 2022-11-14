// class shape with private string color and getArea() method and toString() method

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Shape2
    {
        private String color;

        public String Color
        {
            get { return color; }
            
        }
        public Shape2()
        {
            color = "red";
        }

        public Shape2(String color)
        {
            this.color = color;
        }

        public double getArea()
        {
            return 0.0;
        }

        public override string ToString()
        {
            return "Shape[color=" + color + "]";
        }
    }
}