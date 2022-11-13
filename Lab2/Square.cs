// Square class with double side, width and length override to side
//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2 {
    public class Square : Rectangle
    {

        // override width and length to always be equal
        public override double Width
        {
            get
            {
                return base.Width;
            }
            set
            {
                base.Width = value;
                base.Length = value;
            }
        }

        public override double Length
        {
            get
            {
                return base.Length;
            }
            set
            {
                base.Length = value;
                base.Width = value;
            }
        }

        public Square()
        {
            Width = 1.0;
        }

        public Square(double side) : base(side, side)
        {
            Width = side;
        }

        public Square(double side, String color, bool filled) : base(side, side, color, filled)
        {
            Width = side;
        }



        public override string ToString()
        {
            return string.Format("A Square with side={0}, which is a subclass of {1}", Width, base.ToString());
        }
    }
}
