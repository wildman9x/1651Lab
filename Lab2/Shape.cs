// Shape class with String color default red, boolean filled trrue

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class Shape
    {
        private String color;
        private bool filled;

        public Shape()
        {
            color = "red";
            filled = true;
        }

        public Shape(String color, bool filled)
        {
            this.color = color;
            this.filled = filled;
        }

        public String Color
        {
            get { return color; }
            set { color = value; }
        }

        public bool Filled
        {
            get { return filled; }
            set { filled = value; }
        }

        public override string ToString()
        {
            return string.Format("A Shape with color of {0} and {1}", color, filled ? "filled" : "not filled");
        }
    }
