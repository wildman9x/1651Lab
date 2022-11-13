// Rectangle class with private int Length and Width properties.
// double override GetArea()
// toString() method

namespace Lab3 {
    class Rectangle : Shape {
        private int Length { get; set; }
        private int Width { get; set; }

        public Rectangle() : base() {
            Length = 1;
            Width = 1;
        }
        public Rectangle(int length, int width) {
            Length = length;
            Width = width;
        }

        // constructor that also takes in a color
        public Rectangle(int length, int width, string color) : base(color) {
            Length = length;
            Width = width;
        }

        public override double GetArea() {
            return Length * Width;
        }
        public override string ToString() {
            return "Rectangle with length " + Length + " and width " + Width;
        }
    }
}