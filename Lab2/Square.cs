// Square class with double side, width and length override to side
//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class Square : Rectangle
    {
        private double side;

        public Square()
        {
            side = 1.0;
        }

        public Square(double side)
        {
            this.side = side;
        }

        public Square(double side, String color, bool filled) : base(side, side, color, filled)
        {
            this.side = side;
        }

        public double Side
        {
            get { return side; }
            set { side = value; }
        }

        public override string ToString()
        {
            return string.Format("A Square with side={0}, which is a subclass of {1}", side, base.ToString());
        }
    }
