// Rectangle class with private int Length and Width properties.
// double override GetArea()
// toString() method

namespace Lab3 {
    class Rectangle : Shape {
        private int length = 0;
        private int width = 0;

        public Rectangle() : base() {
            length = 1;
            width = 1;
        }
        public Rectangle(int length, int width) {
            this.length = length;
            this.width = width;
        }

        // constructor that also takes in a color
        public Rectangle(int length, int width, string color) : base(color) {
            this.length = length;
            this.width = width;
        }

        public override double GetArea() {
            return length * width;
        }
        public override string ToString() {
            return "Rectangle with length " + length + " and width " + width;
        }
    }
}